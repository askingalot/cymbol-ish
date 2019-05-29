using System;
using System.Collections.Generic;
using System.Linq;

public class CymbolInterpreter : CymbolBaseVisitor<ICymbolObject>
{
    private Stack<Dictionary<string, ICymbolObject>> _stack =
        new Stack<Dictionary<string, ICymbolObject>>();
    private Dictionary<string, CymbolParser.FunctionContext> _funcEnv =
        new Dictionary<string, CymbolParser.FunctionContext>();

    public CymbolInterpreter()
    {
        _stack.Push(new Dictionary<string, ICymbolObject>());
    }

    public override ICymbolObject VisitStmts(CymbolParser.StmtsContext context) {
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

    public override ICymbolObject VisitInt(CymbolParser.IntContext context)
    {
        return CymbolObject.From(int.Parse(context.INT().GetText()));
    }

    public override ICymbolObject VisitBool(CymbolParser.BoolContext context)
    {
        return CymbolObject.From(bool.Parse(context.BOOL().GetText()));
    }

    public override ICymbolObject VisitString(CymbolParser.StringContext context) {
        return CymbolObject.From(context.STRING().GetText());
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

    public override ICymbolObject VisitPrint(CymbolParser.PrintContext context)
    {
        var expr = context.expr();
        var value = expr != null ? Visit(expr) : null;
        Console.WriteLine(value?.ObjectValue);
        return CymbolObject.Unit;
    }

    public override ICymbolObject VisitIf(CymbolParser.IfContext context)
    {
        var condition = (Visit(context.expr()) as CymbolObject<bool>)?.Value ?? null;
        if (condition == null) {
            throw new Exception("If conditions must be a 'bool' type.");
        }
        if (condition.Value) {
            return Visit(context.stmts());
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
        var functionContext = _funcEnv[context.ID().GetText()];
        var args = context.expr()?.Select(Visit).ToArray() ?? Enumerable.Empty<ICymbolObject>();
        var paramNames = functionContext.ID().Skip(1).Select(id => id.GetText());

        var env = new Dictionary<string, ICymbolObject>(
            paramNames.Zip(args,
                (param, arg) => new KeyValuePair<string, ICymbolObject>(param, arg))
        );

        _stack.Push(env);
        var result = functionContext.stmt().Select(Visit).ToArray().Last();
        _stack.Pop();

        return result;
    }
}


public interface ICymbolObject
{
    Type Type { get; }
    Object ObjectValue { get; }
}

public class CymbolObject<T> : ICymbolObject
{
    public Type Type => typeof(T);
    public Object ObjectValue => Value;
    public T Value { get; }

    public CymbolObject(T value)
    {
        Value = value;
    }

}


public static class CymbolObject
{
    public static CymbolObject<T> From<T>(T value)
    {
        return new CymbolObject<T>(value);
    }

    private static readonly CymbolObject<object> _unit = new CymbolObject<object>(null);
    public static CymbolObject<object> Unit => _unit;
}
