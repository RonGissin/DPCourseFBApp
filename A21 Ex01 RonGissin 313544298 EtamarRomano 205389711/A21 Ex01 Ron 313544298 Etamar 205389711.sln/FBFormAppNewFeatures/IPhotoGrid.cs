using FacebookWrapper.ObjectModel;
using System.Collections.Generic;

namespace FBFormAppNewFeatures
{
    public interface IPhotoGrid
    {
        void SetGrid(IEnumerable<Photo> photos, IEnumerable<string> captions = null);
    }
}