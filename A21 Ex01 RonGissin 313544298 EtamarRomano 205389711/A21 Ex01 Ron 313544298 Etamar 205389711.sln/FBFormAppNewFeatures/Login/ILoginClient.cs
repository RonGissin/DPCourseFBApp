using FacebookWrapper;

namespace FBFormAppNewFeatures
{
    public interface ILoginClient
    {
        LoginResult Login(params string[] i_Permissions);

        LoginResult Connect(string i_AccessToken);
    }
}