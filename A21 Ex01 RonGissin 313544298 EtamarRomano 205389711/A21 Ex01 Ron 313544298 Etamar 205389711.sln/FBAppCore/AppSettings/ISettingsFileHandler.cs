namespace FBAppCore.AppSettings
{
    public interface ISettingsFileHandler
    {
        void SaveSettingsToFile(AppSettings i_AppSettings);

        AppSettings LoadSettingsFromFile();
    }
}
