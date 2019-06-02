using System;
using System.Collections.Generic;
using System.Linq;

public static class Builtins
{
    public static Dictionary<string, Func<ICymbolObject, ICymbolObject>> OneArgFunctions =
        new Dictionary<string, Func<ICymbolObject, ICymbolObject>>() {
            {"len", Len},
            {"range", Range},
        };

    public static Dictionary<string, Func<ICymbolObject, ICymbolObject, ICymbolObject>> TwoArgFunctions =
        new Dictionary<string, Func<ICymbolObject, ICymbolObject, ICymbolObject>>() {
            {"concat", Concat},
        };

    public static ICymbolObject Len(ICymbolObject arg)
    {
        switch (arg)
        {
            case CymbolObject<string> str:
                return CymbolObject.From(str.Value.Length);
            case CymbolObject<ICymbolObject[]> lst:
                return CymbolObject.From(lst.Value.Count());
            default:
                throw new Exception($"Cannot call 'len()' on {arg.Type.Name}");
        }
    }

    public static ICymbolObject Range(ICymbolObject arg)
    {
        var count = ((CymbolObject<int>)arg).Value;
        return CymbolObject.From(
            Enumerable
                .Range(0, count)
                .Select(n => CymbolObject.From(n))
                .Cast<ICymbolObject>()
                .ToArray());
    }

    public static ICymbolObject Concat(ICymbolObject first, ICymbolObject second)
    {
        switch (first)
        {
            case CymbolObject<string> str when second.Type == typeof(string):
                return CymbolObject.From(str.Value + second.ObjectValue.ToString());
            case CymbolObject<ICymbolObject[]> lst when second.Type == typeof(ICymbolObject[]):
                return CymbolObject.From(
                    lst.Value
                       .Concat((ICymbolObject[])second.ObjectValue)
                       .ToArray()
                );
            default:
                throw new Exception($"Invalid arguments to 'concat()'");
        }

    }
}