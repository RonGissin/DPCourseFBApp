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
                if (m_Instance == null)
                {
                    lock (m_ObjLock)
                    {
                        if (m_Instance == null)
                        {
                            m_Instance = new AppXmlSettingsHandler();
                        }
                    }
                }

                return m_Instance;
            }
        }

        private static AppXmlSettingsHandler m_Instance = null;
        private static readonly object m_ObjLock = new object();
        private XmlSerializer m_Serializer;
        private const string c_XmlFilePath = @"C:\FBAppSettings.xml";

        private AppXmlSettingsHandler()
        {
            m_Serializer = new XmlSerializer(typeof(AppSettings));
        }

        public void SaveSettingsToFile(AppSettings i_AppSettings)
        {
            using (Stream fileStream = new FileStream(c_XmlFilePath, FileMode.OpenOrCreate, FileAccess.ReadWrite))
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

            using (Stream fileStream = new FileStream(c_XmlFilePath, FileMode.OpenOrCreate, FileAccess.Read))
            {
                settings = m_Serializer.Deserialize(fileStream) as AppSettings;
            }

            return settings;
        }
    }
}
