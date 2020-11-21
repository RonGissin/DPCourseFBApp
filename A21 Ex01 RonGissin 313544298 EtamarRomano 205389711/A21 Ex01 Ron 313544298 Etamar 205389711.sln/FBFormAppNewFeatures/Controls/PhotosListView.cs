using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;
using FBAppCore;

namespace FBAppUI.Controls
{
    public class PhotosListView : ListView, IPhotoGrid
    {
        private const string k_InvalidNumOfCaptionsMessage = "Number of captions must be equal to the number of photos";

        public PhotosListView() : base()
        {
            this.GridLines = true;
            this.LabelWrap = true;
            this.View = View.LargeIcon;
        }

        public void SetGrid(IEnumerable<Photo> i_Photos, IEnumerable<string> i_Captions = null)
        {
            ImageList imageList = new ImageList();
            
            imageList.ImageSize = new Size(150, 150);
            Clear();

            foreach (Photo photo in i_Photos)
            {
                imageList.Images.Add(photo.ImageNormal);
            }
            
            if(i_Captions != null)
            {
                if (i_Photos.Count() != i_Captions.Count())
                {
                    throw new InvalidOperationException(k_InvalidNumOfCaptionsMessage);
                }

                insertIndexedCaptions(i_Captions);
            }
            else
            {
                indexImages(i_Photos);
            }
            
            SmallImageList = imageList;
            LargeImageList = imageList;
        }

        private void indexImages(IEnumerable<Photo> i_Photos)
        {
            int imageIndex = 0;

            foreach(Photo photo in i_Photos)
            {
                ListViewItem item = new ListViewItem();
                item.ImageIndex = imageIndex;
                Items.Add(item);
                imageIndex++;
            }
        }

        private void insertIndexedCaptions(IEnumerable<string> i_Captions)
        {
            int photoIndex = 0;

            foreach (string caption in i_Captions)
            {
                Items.Add(caption, photoIndex);
                photoIndex++;
            }
        }
    }
}
