public class WatchList
{
    public long Id { get; set; }
    public long MovieId { get; set; }
    public string Date { get; set; }
    public long UserId { get; set; }

    public User User { get; set; }
    public Movie Movie { get; set; }
}
