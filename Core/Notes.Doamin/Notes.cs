namespace Notes.Domain;

public class Note
{
    public Guid USerId { get; set; }
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Details { get; set; }
    public DateTime CreationDate { get; set; }
    public DateOnly? EditDateTime { get; set; }
}