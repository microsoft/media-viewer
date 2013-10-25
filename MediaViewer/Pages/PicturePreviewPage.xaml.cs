using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

using MediaViewer.ViewModels;

namespace MediaViewer
{
    /// <summary>
    /// Pictures preview page 
    /// </summary>
    public partial class PicturePreviewPage : PhoneApplicationPage
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public PicturePreviewPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// From PhoneApplicationPage.
        /// Called when a page becomes the active page in a frame.
        /// </summary>
        protected override void OnNavigatedTo(System.Windows.Navigation.NavigationEventArgs e)
        {
            string selectedIndex;

            // check if navigation context contains selectedItem query string, if so get the value to obtain selected item index
            if (NavigationContext.QueryString.TryGetValue("SelectedItem", out selectedIndex))
            {
                int selIndex = int.Parse(selectedIndex);
                
                PicturesCategoryModel model = ((App)Application.Current).PicturesModel;

                // set model for selected image as a data context for page
                DataContext = model.GetModelForItem(selIndex);
            }
        }
    }
}