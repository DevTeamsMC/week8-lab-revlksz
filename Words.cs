public enum Levels{
    Easy,
    Medium,
    Hard
}

public class Words
{
    public string Word { get; set; }
    public string Hint { get; set; }
    public Levels Level { get; set; }
    public string Category { get; set; }
}