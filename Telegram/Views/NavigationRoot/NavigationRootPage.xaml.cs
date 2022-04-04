using System.ComponentModel;
using System.Runtime.CompilerServices;
using Messages.Desktop.UWP.Views.Chats;
using Messages.Desktop.UWP.Views.Settings;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using MUXC = Microsoft.UI.Xaml.Controls;

// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234238

namespace Messages.Desktop.UWP.Views.NavigationRoot
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class NavigationRootPage : Page, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Thickness ProfileNameThickness { get; set; } = new Thickness(50, 0, 0, 0);
        public NavigationRootPage()
        {
            this.InitializeComponent();
            NavigationViewRootFrame.Navigate(typeof(SettingsPage));
        }

        private void ChangeMenuProfileItem()
        {
            switch (NavigationViewRoot.IsPaneOpen)
            {
                case true:
                    ProfileNameThickness = new Thickness(10, 5, 5, 5);
                    ProfilePictrue.Width = 80;
                    ProfilePictrue.Height = 80;
                    break;
                case false:
                    ProfileNameThickness = new Thickness(50,0,0,0);
                    ProfilePictrue.Width = 25;
                    ProfilePictrue.Height = 25;
                    break;
            }
            OnPropertyChanged(nameof(ProfileNameThickness));
        }

        private void NavigationViewRoot_PaneClosing(MUXC.NavigationView sender, MUXC.NavigationViewPaneClosingEventArgs args)
        {
            ChangeMenuProfileItem();
        }

        private void NavigationViewRoot_PaneOpening(MUXC.NavigationView sender, object args)
        {
            ChangeMenuProfileItem();
        }

        private void NavigationViewRoot_SelectionChanged(MUXC.NavigationView sender, MUXC.NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
            {
                if (NavigationViewRootFrame.CurrentSourcePageType != typeof(SettingsPage))
                {
                    NavigationViewRootFrame.Navigate(typeof(SettingsPage));
                }
            }
            else
            {
                var item = NavigationViewRoot.SelectedItem as MUXC.NavigationViewItem;
                switch (item?.Tag.ToString())
                {
                    case "Profile":
                        NavigationViewRootFrame.Navigate(typeof(SettingsPage));
                        break;
                    case "Messages":
                        NavigationViewRootFrame.Navigate(typeof(ChatFieldPage));
                        break;
                    case "Calls":
                        NavigationViewRootFrame.Navigate(typeof(SettingsPage));
                        break;
                    case "Contacts":
                        NavigationViewRootFrame.Navigate(typeof(SettingsPage));
                        break;
                    case "New Contact":
                        NavigationViewRootFrame.Navigate(typeof(SettingsPage));
                        break;
                    case "New Group":
                        NavigationViewRootFrame.Navigate(typeof(SettingsPage));
                        break;
                    case "New Channel":
                        NavigationViewRootFrame.Navigate(typeof(SettingsPage));
                        break;
                }
            }
        }
    }
}
