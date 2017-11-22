namespace Calabonga.ConfigurationDemo.Infrastructure
{
    /// <summary>
    /// System Configuration 
    /// </summary>
    public class ApplicationSettings
    {
        public string AdministrtorEmail { get; set; }
        public int DefaultPageSize { get; set; }
        public string ApplicationName { get; set; }
        public string ApplicationDomain { get; set; }
        public string SecretKey { get; set; }
        public EmailServer EmailServer { get; set; }
    }

    /// <summary>
    /// System Configuration: Email Server
    /// </summary>
    public class EmailServer
    {
        public string Host { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Port { get; set; }
    }
}
