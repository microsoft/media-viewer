using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Media.Imaging;
using Microsoft.Xna.Framework.Media;

namespace MediaViewer.ViewModels
{
    /// <summary>
    /// Model for picture preview page
    /// </summary>
    public class PicturePreviewModel
    {
        /// <summary>
        /// Title of the picture
        /// </summary>
        public string Title { get; private set; }

        /// <summary>
        /// Creation date
        /// </summary>
        public string Created { get; private set; }

        /// <summary>
        /// Resolution of the picture
        /// </summary>
        public string Resolution { get; private set; }

        /// <summary>
        /// Image source
        /// </summary>
        public BitmapImage ImageSource { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public PicturePreviewModel(Picture picture)
        {
            Title = picture.Name;

            Created = picture.Date.ToString();

            Resolution = picture.Height.ToString() + "x" + picture.Width.ToString();

            // load source of the image
            ImageSource = new BitmapImage();
            System.IO.Stream stream = picture.GetImage();

            ImageSource.SetSource(stream);            
        }
    }
}
