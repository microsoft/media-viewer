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

namespace MediaViewer.ViewModels
{
    /// <summary>
    /// Class representing single category list item
    /// </summary>
    public class CategoryItem
    {
        /// <summary>
        /// Main name of the item
        /// </summary>
        public string MainName { get; private set; }

        /// <summary>
        /// Subname of the item
        /// </summary>
        public string SubName { get; private set; }

        /// <summary>
        /// Constructor
        /// </summary>
        public CategoryItem(string mainName, string subName)
        {
            MainName = mainName;
            SubName = subName;
        }
    }
}
