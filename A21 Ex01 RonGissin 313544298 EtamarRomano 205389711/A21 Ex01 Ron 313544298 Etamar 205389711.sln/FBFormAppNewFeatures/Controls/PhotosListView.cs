using FacebookWrapper.ObjectModel;
using FBAppCore;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace FBFormAppNewFeatures
{
    public class PhotosListView : ListView, IPhotoGrid
    {
        private const string c_InvalidNumOfCaptionsMessage = "Number of captions must be equal to the number of photos";
        public PhotosListView() : base()
        {
            this.GridLines = true;
            LabelWrap = true;
            View = View.LargeIcon;
        }

        public void SetGrid(IEnumerable<Photo> photos, IEnumerable<string> captions = null)
        {
            ImageList imageList = new ImageList();
            imageList.ImageSize = new Size(150, 150);

            Clear();

            foreach (Photo photo in photos)
            {
                imageList.Images.Add(photo.ImageNormal);
            }
            
            if(captions != null)
            {
                if (photos.Count() != captions.Count())
                {
                    throw new InvalidOperationException(c_InvalidNumOfCaptionsMessage);
                }

                InsertIndexedCaptions(captions);
            }
            else
            {
                IndexImages(photos);
            }
            
            SmallImageList = imageList;
            LargeImageList = imageList;
        }

        private void IndexImages(IEnumerable<Photo> photos)
        {
            int imageIndex = 0;

            foreach(Photo photo in photos)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = imageIndex;
                Items.Add(item);
                imageIndex++;
            }
        }

        private void InsertIndexedCaptions(IEnumerable<string> captions)
        {
            int photoIndex = 0;

            foreach (string caption in captions)
            {
                Items.Add(caption, photoIndex);
                photoIndex++;
            }
        }
    }
}
