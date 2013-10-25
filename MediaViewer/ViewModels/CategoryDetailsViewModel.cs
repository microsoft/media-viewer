using System;
using System.Net;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.Generic;
using Microsoft.Xna.Framework.Media;

namespace MediaViewer.ViewModels
{
    /// <summary>
    /// Base class for category models
    /// </summary>
    public abstract class CategoryDetailsViewModel
    {
        /// <summary>
        /// List of the category items. Category items are binded to the list displayed on main page.
        /// </summary>
        public abstract List<CategoryItem> Items{ get; protected set; }

        /// <summary>
        /// Category name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Check if there is any item available
        /// </summary>
        /// <returns>
        /// true if there is any valid item available, false otherwise
        /// </returns>
        public virtual bool IsAnyItemAvailable() { return false; }

        /// <summary>
        /// prepares selected item to preview
        /// </summary>
        /// <param name="itemIndex">
        /// index of the selected item
        /// </param>
        /// <returns>
        /// true if item is prepared successfully, false otherwise
        /// </returns>
        public virtual bool PrepareItemForPreview(int itemIndex) { return false; }
    }
}
