using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Messages.Desktop.UWP.Views.NavigationRoot;
using Messages.Desktop.UWP.Views.Other;
using Messages.Desktop.UWP.Views.Settings;
using Messages.Models.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace Messages.Desktop.UWP
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static Frame NavigationFrame;

        public MainPage()
        {
            this.InitializeComponent();
            DataStructure.GenerateData();
            NavigationFrame = MainFrame;
            NavigationFrame.Navigate(typeof(NavigationRootPage));
        }
    }
}
