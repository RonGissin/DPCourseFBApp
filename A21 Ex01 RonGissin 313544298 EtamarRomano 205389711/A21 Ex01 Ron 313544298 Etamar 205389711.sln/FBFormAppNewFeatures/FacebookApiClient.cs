using FacebookWrapper;
using FacebookWrapper.ObjectModel;
using System.Threading.Tasks;

namespace FBFormAppNewFeatures
{
    internal class FacebookApiClient
    {
        private string m_AccessToken;

        public FacebookApiClient(string i_AccessToken)
        {
            m_AccessToken = i_AccessToken;    
        }

        public FacebookObjectCollection<Group> GetGroups()
        {
            return FacebookService.GetCollection<Group>(
                i_Connection: m_AccessToken,
                i_Limit: 10);
        }
    }
}