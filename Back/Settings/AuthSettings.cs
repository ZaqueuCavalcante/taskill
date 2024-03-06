namespace Taskill.Back.Settings;

public class AuthSettings
{
    public string GoogleClientId { get; set; }
    public string GoogleClientSecret { get; set; }

    public AuthSettings(IConfiguration configuration)
    {
        configuration.GetSection("Auth").Bind(this);
    }
}
