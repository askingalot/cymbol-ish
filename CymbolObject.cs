using System;

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
