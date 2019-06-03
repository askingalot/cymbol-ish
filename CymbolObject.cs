using System;
using System.Collections.Generic;

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

public class RecursionResultCymbolObject : ICymbolObject
{
    public Type Type => throw new NotImplementedException();

    public object ObjectValue => throw new NotImplementedException();

    public Dictionary<string, ICymbolObject> Env { get; }

    public RecursionResultCymbolObject(Dictionary<string, ICymbolObject> env)
    {
        Env = env;
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
