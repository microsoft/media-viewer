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
using Microsoft.Xna.Framework.Media;
using Microsoft.Xna.Framework;

using MediaViewer.ViewModels;

namespace MediaViewer
{
    /// <summary>
    /// Song details page class.
    /// </summary>
    public partial class SongPreviewPage : PhoneApplicationPage
    {
        public SongPreviewPage()
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

                MusicCategoryModel model = ((App)Application.Current).MusicModel;

                // set data context for the page
                DataContext = model.GetModelForIndex(selIndex);
            }
        }

        /// <summary>
        /// From PhoneApplicationPage.
        /// Called when a page is no longer the active page in a frame
        /// </summary>
        protected override void OnNavigatedFrom(System.Windows.Navigation.NavigationEventArgs e)
        {
            // stop playback
            MediaPlayer.Stop();
            base.OnNavigatedFrom(e);
        }
    }
}