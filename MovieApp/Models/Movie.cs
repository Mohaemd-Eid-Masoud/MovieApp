using Microsoft.AspNetCore.Mvc.ViewEngines;

public class Movie
{
    public long Id { get; set; }
    public string Title { get; set; }
    public DateTime ReleaseDate { get; set; }
    public string Synopsis { get; set; }
    public string Duration { get; set; }
    public byte[] CoverImage { get; set; }
    public long GenreName { get; set; }
    public string TrailerVideoPath { get; set; }
    public ICollection<Review> Reviews { get; set; }
    public ICollection<WatchList> WatchLists { get; set; }
}
