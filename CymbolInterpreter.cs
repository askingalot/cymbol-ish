using System;
using System.Collections.Generic;
using System.Linq;

public class CymbolInterpreter : CymbolBaseVisitor<ICymbolObject>
{
    private Stack<Dictionary<string, ICymbolObject>> _stack =
        new Stack<Dictionary<string, ICymbolObject>>();
    private Dictionary<string, CymbolParser.FunctionContext> _funcEnv =
        new Dictionary<string, CymbolParser.FunctionContext>();

    private string _currentFunctionName = null;

    public CymbolInterpreter()
    {
        _stack.Push(new Dictionary<string, ICymbolObject>());
    }

    public override ICymbolObject VisitStmts(CymbolParser.StmtsContext context)
    {
        return context.stmt()?.Select(Visit).ToArray().LastOrDefault() ?? CymbolObject.Unit;
    }

    public override ICymbolObject VisitDeclaration(CymbolParser.DeclarationContext context)
    {
        var typeName = context.type().GetText();
        var value = Visit(context.expr());

        switch (typeName)
        {
            case "int" when value.Type.Name != typeof(int).Name:
            case "bool" when value.Type.Name != typeof(bool).Name:
            case "string" when value.Type.Name != typeof(string).Name:
            case "list" when value.Type.Name != typeof(ICymbolObject[]).Name:
                throw new Exception(
                    $"Value type doesn't match annotation {context.type().Start.Line}:{context.type().Start.Column}");
            default:
                break;
        }
        _stack.Peek().Add(context.ID().GetText(), value);
        return value;
    }

    public override ICymbolObject VisitVariable(CymbolParser.VariableContext context)
    {
        return _stack.Peek()[context.ID().GetText()];
    }

    public override ICymbolObject VisitElement(CymbolParser.ElementContext context)
    {
        var list = _stack.Peek()[context.ID().GetText()]?.ObjectValue as ICymbolObject[];
        if (list == null)
        {
            throw new Exception(
                $"Indexing is only allowed in lists ({context.Start.Line}:{context.Start.Column})");
        }

        var index = (Visit(context.expr()) as CymbolObject<int>)?.Value;
        if (index == null)
        {
            throw new Exception(
                $"List index must be an int ({context.Start.Line}:{context.Start.Column})");
        }

        return list[index.Value];
    }


    public override ICymbolObject VisitInt(CymbolParser.IntContext context)
    {
        return CymbolObject.From(int.Parse(context.INT().GetText().Replace("_", "")));
    }

    public override ICymbolObject VisitBool(CymbolParser.BoolContext context)
    {
        return CymbolObject.From(bool.Parse(context.BOOL().GetText()));
    }

    public override ICymbolObject VisitString(CymbolParser.StringContext context)
    {
        return CymbolObject.From(context.STRING().GetText());
    }

    public override ICymbolObject VisitList(CymbolParser.ListContext context)
    {
        var elements = context.expr().Select(Visit).ToArray();
        if (!elements.Skip(1).All(el => el.Type == elements[0].Type))
        {
            throw new Exception(
                $"All elements of a list must be the same type ({context.Start.Line}:{context.Start.Column})");
        }
        return CymbolObject.From(elements);
    }

    public override ICymbolObject VisitEmptyList(CymbolParser.EmptyListContext context)
    {
        return CymbolObject.From(Enumerable.Empty<ICymbolObject>().ToArray());
    }

    public override ICymbolObject VisitNegate(CymbolParser.NegateContext context)
    {
        var op = context.op;
        var operandObject = Visit(context.expr());
        switch (operandObject)
        {
            case CymbolObject<int> operand when op.Type == CymbolParser.SUB:
                return CymbolObject.From(-operand.Value);
            case CymbolObject<bool> operand when op.Type == CymbolParser.NOT:
                return CymbolObject.From(!operand.Value);
            default:
                throw new Exception($"Invalid negation ({context.Start.Line}:{context.Start.Column})");
        }
    }

    public override ICymbolObject VisitMuldiv(CymbolParser.MuldivContext context)
    {
        var operands = context.expr().Select(Visit).Cast<CymbolObject<int>>().ToArray();
        var result = context.op.Type == CymbolParser.MUL
            ? operands[0].Value * operands[1].Value
            : operands[0].Value / operands[1].Value;

        return CymbolObject.From(result);
    }

    public override ICymbolObject VisitAddsub(CymbolParser.AddsubContext context)
    {
        var operands = context.expr().Select(Visit).Cast<CymbolObject<int>>().ToArray();
        var result = context.op.Type == CymbolParser.ADD
            ? operands[0].Value + operands[1].Value
            : operands[0].Value - operands[1].Value;

        return CymbolObject.From(result);
    }

    public override ICymbolObject VisitComp(CymbolParser.CompContext context)
    {
        var operands = context.expr().Select(Visit).ToArray();
        if (operands[0].Type != operands[1].Type)
        {
            throw new Exception(
                $"Cannot compare expressions of different types. ({context.Start.Line}:{context.Start.Column})");
        }
        var op = context.op;
        switch (operands[0])
        {
            case CymbolObject<int> lint:
                var rint = (CymbolObject<int>)operands[1];
                switch (op.Type)
                {
                    case CymbolParser.EQ:
                        return CymbolObject.From(lint.Value == rint.Value);
                    case CymbolParser.NE:
                        return CymbolObject.From(lint.Value != rint.Value);
                    case CymbolParser.GT:
                        return CymbolObject.From(lint.Value > rint.Value);
                    case CymbolParser.GE:
                        return CymbolObject.From(lint.Value >= rint.Value);
                    case CymbolParser.LT:
                        return CymbolObject.From(lint.Value < rint.Value);
                    case CymbolParser.LE:
                        return CymbolObject.From(lint.Value <= rint.Value);
                    default:
                        throw new Exception($"Unexpected operator {op.Text} ({op.Line}:{op.Column})");
                }
            case CymbolObject<bool> lbool:
                var rbool = (CymbolObject<bool>)operands[1];
                switch (op.Type)
                {
                    case CymbolParser.EQ:
                        return CymbolObject.From(lbool.Value == rbool.Value);
                    case CymbolParser.NE:
                        return CymbolObject.From(lbool.Value != rbool.Value);
                    case CymbolParser.GT:
                        // true > false
                        return CymbolObject.From(lbool.Value == true && rbool.Value == false);
                    case CymbolParser.GE:
                        // false >= false and true >= true and true >= false
                        return CymbolObject.From(lbool.Value == rbool.Value || lbool.Value == true);
                    case CymbolParser.LT:
                        // false < true
                        return CymbolObject.From(lbool.Value == false && rbool.Value == true);
                    case CymbolParser.LE:
                        // false >= false and true >= true and false <= true
                        return CymbolObject.From(lbool.Value == rbool.Value || lbool.Value == false);
                    default:
                        throw new Exception($"Unexpected operator {op.Text} ({op.Line}:{op.Column})");
                }
            case CymbolObject<string> lstring:
                var rstring = (CymbolObject<string>)operands[1];
                switch (op.Type)
                {
                    case CymbolParser.EQ:
                        return CymbolObject.From(lstring.Value == rstring.Value);
                    case CymbolParser.NE:
                        return CymbolObject.From(lstring.Value != rstring.Value);
                    case CymbolParser.GT:
                        return CymbolObject.From(string.Compare(lstring.Value, rstring.Value) > 0);
                    case CymbolParser.GE:
                        return CymbolObject.From(string.Compare(lstring.Value, rstring.Value) >= 0);
                    case CymbolParser.LT:
                        return CymbolObject.From(string.Compare(lstring.Value, rstring.Value) < 0);
                    case CymbolParser.LE:
                        return CymbolObject.From(string.Compare(lstring.Value, rstring.Value) <= 0);
                    default:
                        throw new Exception($"Unexpected operator {op.Text} ({op.Line}:{op.Column})");
                }
            default:
                throw new Exception($"Unknown error ({context.Start.Line}:{context.Start.Column})");
        }
    }

    public override ICymbolObject VisitRel(CymbolParser.RelContext context)
    {
        var operands = context.expr().Select(Visit).Cast<CymbolObject<bool>>().ToArray();
        var result = context.op.Type == CymbolParser.AND
            ? operands[0].Value && operands[1].Value
            : operands[0].Value || operands[1].Value;

        return CymbolObject.From(result);
    }

    public override ICymbolObject VisitParen(CymbolParser.ParenContext context)
    {
        return Visit(context.expr());
    }

    public override ICymbolObject VisitPrint(CymbolParser.PrintContext context)
    {
        var expr = context.expr();
        var value = expr != null ? Visit(expr) : null;

        switch (value?.ObjectValue)
        {
            case null:
                Console.WriteLine();
                break;
            case ICymbolObject[] list:
                var values = list.Select(el => el.ObjectValue.ToString());
                Console.WriteLine($"[{ string.Join(", ", values) }]");
                break;
            default:
                Console.WriteLine(value.ObjectValue);
                break;
        }

        return CymbolObject.Unit;
    }

    public override ICymbolObject VisitIf(CymbolParser.IfContext context)
    {
        // if, else if, else...

        var conditions = context.expr();
        var blocks = context.stmts();

        var hasElse = conditions.Length < blocks.Length;

        for (var i = 0; i < conditions.Length; i++)
        {
            var condition = (Visit(conditions[i]) as CymbolObject<bool>)?.Value;
            if (condition == null)
            {
                throw new Exception(
                    $"If conditions must be a 'bool' type ({conditions[i].Start.Line}:{conditions[i].Start.Column})");
            }
            if (condition.Value)
            {
                return Visit(blocks[i]);
            }
        }

        if (hasElse)
        {
            return Visit(blocks.Last());
        }

        return CymbolObject.Unit;
    }

    public override ICymbolObject VisitFunction(CymbolParser.FunctionContext context)
    {
        _funcEnv.Add(context.ID()[0].GetText(), context);
        return CymbolObject.Unit;
    }

    public override ICymbolObject VisitCall(CymbolParser.CallContext context)
    {
        var functionName = context.ID().GetText();
        var args = (context.expr()?.Select(Visit) ?? Enumerable.Empty<ICymbolObject>()).ToArray();

        if (Builtins.OneArgFunctions.ContainsKey(functionName))
        {
            return Builtins.OneArgFunctions[functionName](args.FirstOrDefault());
        }
        else if (Builtins.TwoArgFunctions.ContainsKey(functionName))
        {
            return Builtins.TwoArgFunctions[functionName](args[0], args[1]);
        }

        var functionContext = _funcEnv[functionName];
        var paramNames = functionContext.ID().Skip(1).Select(id => id.GetText());

        var env = new Dictionary<string, ICymbolObject>(
            paramNames.Zip(args,
                (param, arg) => new KeyValuePair<string, ICymbolObject>(param, arg))
        );

        // This madness is a for tail recursion
        // It should probably be tested more

        // FIXME Damnit...now it only does tail recursion!!!!!
        //  TODO: ensure there are no siblings to the right of the function call
        //        in the parse tree

        if (_currentFunctionName == functionName)
        {
            return new RecursionResultCymbolObject(env);
        }
        else
        {
            // god help me if there's ever parallel execution in this crazy language
            _currentFunctionName = functionName;

            _stack.Push(env);
            var result = functionContext.stmt().Select(Visit).ToArray().Last();
            _stack.Pop();

            while (result is RecursionResultCymbolObject recResult)
            {
                _stack.Push(recResult.Env);
                result = functionContext.stmt().Select(Visit).ToArray().Last();
                _stack.Pop();
            }

            _currentFunctionName = null;
            return result;
        }
    }
}