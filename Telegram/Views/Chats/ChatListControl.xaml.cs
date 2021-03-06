using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
using Messages.Models;
using Messages.Models.Models;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// Документацию по шаблону элемента "Пользовательский элемент управления" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234236

namespace Messages.Desktop.UWP.Views.Chats
{
    public sealed partial class ChatListControl : UserControl
    {
        public ChatListControl()
        {
            this.InitializeComponent();
            DataStructure.GenerateData();
            //var chats = DataStructure.Chats.Where(x => x.Receiver.ProfileId == 1).ToList();
            //ListViewChats.ItemsSource = chats;
        }
    }
}
