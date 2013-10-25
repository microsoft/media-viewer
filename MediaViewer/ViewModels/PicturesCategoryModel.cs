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
using System.Windows.Navigation;
using System.Windows.Media.Imaging;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Media;

namespace MediaViewer.ViewModels
{
    /// <summary>
    /// Model for pictures category
    /// </summary>
    public class PicturesCategoryModel : CategoryDetailsViewModel
    {
        /// <summary>
        /// List of pictures for pictures category
        /// </summary>
        private List<Picture> Pictures { get; set; }

        private PicturePreviewModel currentItemModel = null;

        /// <summary>
        /// Overriden property from CategoryDetailsViewModel
        /// </summary>
        public override List<CategoryItem> Items  
        { 
            get
            {
                // returns list of categor items basing on Pictures list
                List<CategoryItem> names = new List<CategoryItem>();

                // if there are no songs on the list add one fake item saying that there are no items to display
                if (Pictures.Count == 0)
                    names.Add(new CategoryItem("No items to display...", ""));
                else
                {
                    foreach (Picture picture in Pictures)
                    {
                        names.Add(new CategoryItem(picture.Name, picture.Date.ToString()));
                    }
                }
                return names;
            }
            protected set
            {
                Items = value;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        public PicturesCategoryModel(string name, List<Picture> pictures)
        {
            Name = name;

            Pictures = pictures;
        }

        /// <summary>
        /// From CategoryDetailsViewModel.
        /// Check if there is any item available.
        /// </summary>
        /// <returns>
        /// true if there is any valid item available, false otherwise
        /// </returns>
        public override bool IsAnyItemAvailable()
        {
            if (Pictures.Count != 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Gets pictures model for picture preview page
        /// </summary>
        /// <param name="itemIndex">
        /// index of the selected picture       
        /// </param>
        /// <returns>
        /// model based on selected picture
        /// </returns>
        public PicturePreviewModel GetModelForItem(int itemIndex)
        {
            return currentItemModel;
        }

        /// <summary>
        /// From CategoryDetailsViewModel
        /// prepares picture to preview and check if there are any problems with creating model
        /// </summary>
        /// <param name="itemIndex">
        /// index of the selected item
        /// </param>
        /// <returns>
        /// true if item succesfully prepared for preview, false otherwise
        /// </returns>
        public override bool PrepareItemForPreview(int itemIndex)
        {
            if (itemIndex < Pictures.Count)
            {
                // catch InvalidOperationException and return false in this case
                // this exception is thrown on WP7 7.0 when device is connected to the computer
                try
                {
                    currentItemModel = new PicturePreviewModel(Pictures[itemIndex]);
                    return true;
                }
                catch (InvalidOperationException exception)
                {
                    return false;
                }
            }
            else
                return false;
        }
    }
}
