namespace celilcavus.models;

public class User
{
    public Guid id { get; set; } = Guid.NewGuid();
    public int ListNumber { get; set; }
    public string Name { get; set; } = String.Empty;
    public string Lastname { get; set; } = String.Empty;
    public DateTime CreatedDate { get; init; }
    public DateTime UpdateDate { get; set; }

    public User()
    {
        CreatedDate = DateTime.Now;
        UpdateDate = DateTime.Now;

        
    }
}