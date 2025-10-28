namespace SchoolTimetableSystem.Domain.Abstractions;

public record Error(string Code, string Description, Error.Type ErrorType)
{
    public static Error None = new(string.Empty, string.Empty, Type.None);
    public static Error NullValue = new("Error.NullValue", "A null value was entered.", Type.NullValue);

    public enum Type
    {
        None = 0,
        NullValue = 1,
        NotFound = 2,
        Domain = 3
    }
}