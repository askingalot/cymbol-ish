using System;
using System.Collections.Generic;
using System.Linq;

public static class Builtins
{
    public static Dictionary<string, Func<ICymbolObject, ICymbolObject>> Functions =
        new Dictionary<string, Func<ICymbolObject, ICymbolObject>>() {
            {"len", Len},
            {"range", Range},
        };

    public static ICymbolObject Len(ICymbolObject arg)
    {
        return CymbolObject.From(
            (arg.ObjectValue as IEnumerable<object>).Count()
        );
    }

    public static ICymbolObject Range(ICymbolObject arg) {
        var count = ((CymbolObject<int>) arg).Value;
        return CymbolObject.From(
            Enumerable
                .Range(0, count)
                .Select(n => CymbolObject.From(n))
                .Cast<ICymbolObject>()
                .ToArray());
    }
}