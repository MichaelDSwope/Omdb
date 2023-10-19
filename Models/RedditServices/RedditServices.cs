namespace Paupers.Models.RedditServices
{
    public interface IRedditService
    {
        Task<string> CreateNewAsync();
        
    }
}
