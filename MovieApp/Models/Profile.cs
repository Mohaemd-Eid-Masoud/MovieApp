public class Profile
{
    public long Id { get; set; }
    public byte[] ProfilePic { get; set; }
    public long UserId { get; set; }

    public User User { get; set; }
}
