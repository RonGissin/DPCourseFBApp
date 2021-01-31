using System.Collections.Generic;
using FacebookWrapper.ObjectModel;

namespace FBAppCore
{
    public interface IPhotoGrid
    {
        void SetGrid(IEnumerable<Photo> i_Photos, IEnumerable<string> i_Captions = null);
    }
}