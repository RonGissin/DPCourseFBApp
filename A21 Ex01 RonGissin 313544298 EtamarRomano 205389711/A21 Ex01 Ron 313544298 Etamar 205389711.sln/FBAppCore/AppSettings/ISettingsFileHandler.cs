using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FBAppCore.AppSettings
{
    public interface ISettingsFileHandler
    {
        void SaveSettingsToFile(AppSettings i_AppSettings);

        AppSettings LoadSettingsFromFile();
    }
}
