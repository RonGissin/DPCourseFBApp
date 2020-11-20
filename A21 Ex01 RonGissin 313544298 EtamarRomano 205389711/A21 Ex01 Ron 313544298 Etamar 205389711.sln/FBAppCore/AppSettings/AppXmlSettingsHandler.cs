using FBAppCore.AppSettings;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace FBAppCore.AppSettings
{
    public sealed class AppXmlSettingsHandler : ISettingsFileHandler
    {
        public static AppXmlSettingsHandler Instance 
        { 
            get
            {
                lock (objLock)
                {
                    if(instance == null)
                    {
                        instance = new AppXmlSettingsHandler();
                    }

                    return instance;
                }
            } 
        }

        private static AppXmlSettingsHandler instance = null;
        private static readonly object objLock = new object();
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
