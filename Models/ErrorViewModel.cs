namespace Paupers.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }
        public string Results { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}