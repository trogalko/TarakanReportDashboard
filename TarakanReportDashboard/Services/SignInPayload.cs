namespace TarakanReportDashboard.Services
{
    public class SignInPayload
    {
        public string? UserId { get; set; }
        public string? UserName { get; set; }
        public string? Email { get; set; }

        public SignInPayload() { }

        public SignInPayload(string _userId, string _userName, string _email)
        {
            UserId = _userId;
            UserName = _userName;
            Email = _email;
        }
    }
}
