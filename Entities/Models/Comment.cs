namespace Entities.Models;

public class Comment
{
    public Guid Id { get; set; }
    public string UserName { get; set; }
    public string Text { get; set; }
    public DateTimeOffset CommentAt { get; set; }
    public Guid ProductId { get; set; }
    public int Rating { get; set; }

    public virtual Product Product { get; set; }
}