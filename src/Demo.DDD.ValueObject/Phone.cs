namespace Demo.DDD.ValueObject
{
    public record Phone
    {
        public string Number { get; init; }
        public string Type { get; init; }

        public Phone(string Number, string Type)
        {
            ArgumentNullException.ThrowIfNull("number");
            ArgumentNullException.ThrowIfNull("type");

            this.Number = Number;
            this.Type = Type;
        }
    }
}
