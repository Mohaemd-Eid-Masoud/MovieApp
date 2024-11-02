public class Review
{
    public long Id { get; set; }
    public long MovieId { get; set; }
    public string Text { get; set; }
    public int Rating { get; set; }
    public DateTime DatePosting { get; set; }
    public long UserId { get; set; }

    public User User { get; set; }
    public Movie Movie { get; set; }
}
