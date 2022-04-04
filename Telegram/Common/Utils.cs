using Messages.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace Messages.Desktop.UWP.Common
{
    public class Utils
    {
        public static HorizontalAlignment GetAlignment(Alignment alignment)
        {
            return alignment == Alignment.Left ? HorizontalAlignment.Left : HorizontalAlignment.Right;
        }
    }
}
