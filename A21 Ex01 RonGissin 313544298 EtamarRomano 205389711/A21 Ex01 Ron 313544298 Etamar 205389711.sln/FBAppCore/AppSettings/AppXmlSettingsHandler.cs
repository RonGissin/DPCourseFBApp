using System.IO;
using System.Xml.Serialization;

namespace FBAppCore.AppSettings
{
    public sealed class AppXmlSettingsHandler : ISettingsFileHandler
    {
        public static AppXmlSettingsHandler Instance 
        { 
            get
            {
                if (s_Instance == null)
                {
                    lock (sr_ObjLock)
                    {
                        if (s_Instance == null)
                        {
                            s_Instance = new AppXmlSettingsHandler();
                        }
                    }
                }

                return s_Instance;
            }
        }

        private const string k_XmlFilePath = @"C:\FBAppSettings.xml";
        private static readonly object sr_ObjLock = new object();
        private static AppXmlSettingsHandler s_Instance = null;
        private XmlSerializer m_Serializer;

        private AppXmlSettingsHandler()
        {
            m_Serializer = new XmlSerializer(typeof(AppSettings));
        }

        public void SaveSettingsToFile(AppSettings i_AppSettings)
        {
            using (Stream fileStream = new FileStream(k_XmlFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                lock (fileStream)
                {
                    fileStream.SetLength(0);
                }

                m_Serializer.Serialize(fileStream, i_AppSettings);
            }
        }

        public AppSettings LoadSettingsFromFile()
        {
            AppSettings settings = null;

            using (Stream fileStream = new FileStream(k_XmlFilePath, FileMode.OpenOrCreate, FileAccess.Read))
            {
                settings = m_Serializer.Deserialize(fileStream) as AppSettings;
            }

            return settings;
        }
    }
}
