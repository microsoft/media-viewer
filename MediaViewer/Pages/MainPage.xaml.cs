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
    /// Main page class
    /// </summary>
    public partial class MainPage : PhoneApplicationPage
    {
        // reference to current Application
        private App app;

        /// <summary>
        /// Constructor
        /// </summary>
        public MainPage()
        {
            InitializeComponent();

            app = Application.Current as App;

            List<CategoryDetailsViewModel> items = new List<CategoryDetailsViewModel>();

            items.Add(app.PicturesModel);
            items.Add(app.MusicModel);

            // set a list containing both pictures and music model as item source for main pivot
            PivotControl.ItemsSource = items;
        }

        /// <summary>
        /// Event handler for PicturesListBox SelectionChanged event
        /// </summary>
        private void ItemsListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            ListBox list = (ListBox)sender;

            int selectedCategoryIndex = list.SelectedIndex;

            // If selected index is -1 (no selection) do nothing
            if (selectedCategoryIndex == -1)
                return;

            List<CategoryDetailsViewModel> model = PivotControl.ItemsSource as List<CategoryDetailsViewModel>;

            // check the model assigned to current pivot item and navigate, depending on the result, to proper page
            if (model[PivotControl.SelectedIndex].IsAnyItemAvailable())
            {
                if (model[PivotControl.SelectedIndex].PrepareItemForPreview(selectedCategoryIndex))
                {
                    if (model[PivotControl.SelectedIndex] is MusicCategoryModel)
                    {
                        NavigationService.Navigate(new Uri("/Pages/SongDetailsPage.xaml?SelectedItem=" + selectedCategoryIndex, UriKind.Relative));
                    }
                    else if (model[PivotControl.SelectedIndex] is PicturesCategoryModel)
                    {
                        NavigationService.Navigate(new Uri("/Pages/PicturePreviewPage.xaml?SelectedItem=" + selectedCategoryIndex, UriKind.Relative));
                    }
                }
                // show warining dialog it there are any probles with previewing selected item
                else
                    MessageBox.Show("Warining!\n\nUnable to open selected file.\nMake sure that your device is disconnected from the computer.");
            }

            // Reset selected index to -1 (no selection)
            list.SelectedIndex = -1;
        }
    }
}