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
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Media;

namespace MediaViewer.ViewModels
{
    /// <summary>
    /// Model for music category
    /// </summary>
    public class MusicCategoryModel : CategoryDetailsViewModel
    {
        /// <summary>
        /// List of songs in music category
        /// </summary>
        private List<Song> Songs { get; set; }

        /// <summary>
        /// Overriden property from CategoryDetailsViewModel
        /// </summary>
        public override List<CategoryItem> Items
        {
            get
            {
                List<CategoryItem> names = new List<CategoryItem>();

                // if there are no songs on the list add one fake item saying that there are no items to display
                if (Songs.Count == 0)
                    names.Add(new CategoryItem("No items to display...", ""));
                else
                {
                    foreach (Song song in Songs)
                    {
                        names.Add(new CategoryItem(song.Name, song.Artist.Name));
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
        public MusicCategoryModel(string name, List<Song> songs)
        {
            Songs = songs;
            Name = name;
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
            if (Songs.Count != 0)
                return true;
            else
                return false;
        }

        /// <summary>
        /// Gets song object that is used for song details page
        /// </summary>
        /// <param name="itemIndex">
        /// index of the selected song       
        /// </param>
        /// <returns>
        /// selected song
        /// </returns>
        public Song GetModelForIndex(int itemIndex)
        {
            if (itemIndex < Songs.Count)
                return Songs[itemIndex];
            else
                return null;
        }

        /// <summary>
        /// Plays selected song
        /// </summary>
        public void PlaySong(int songIndex)
        {
            FrameworkDispatcher.Update();
            MediaPlayer.Play(Songs[songIndex]);
        }
        /// <summary>
        /// Stops playback
        /// </summary>
        public void StopPlayback()
        {
            MediaPlayer.Stop();
        }

        /// <summary>
        /// From CategoryDetailsViewModel
        /// tries to play selected song and returns false in case of any problems
        /// </summary>
        /// <param name="itemIndex">
        /// index of the selected item
        /// </param>
        /// <returns>
        /// true if song can be played, false otherwise
        /// </returns>
        public override bool PrepareItemForPreview(int itemIndex)
        {
            try
            {
                FrameworkDispatcher.Update();
                MediaPlayer.Play(Songs[itemIndex]);
                return true;
            }
            catch (InvalidOperationException exception)
            {
                return false;
            }
        }
    }
}
