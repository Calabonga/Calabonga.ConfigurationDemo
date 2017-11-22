namespace Calabonga.ConfigurationDemo.Infrastructure
{
    /// <summary>
    /// Settings manager
    /// </summary>
    public interface ISettingsManager
    {
        ApplicationSettings Config { get; }
    }
}