using System;
using Messages.Models;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;
using Windows.Storage.Pickers;
using System.Collections.Generic;
using Windows.Storage.Streams;
using Windows.Storage;
using Windows.UI.Text;
using Windows.Storage.Provider;
using Windows.UI.Popups;
using Messages.SqlServer;
using Windows.UI.Xaml.Input;

// Документацию по шаблону элемента "Пользовательский элемент управления" см. по адресу https://go.microsoft.com/fwlink/?LinkId=234236

namespace Messages.Desktop.UWP.Views.Chats
{
    public sealed partial class ChatControl : UserControl
    {
        public ChatControl()
        {
            this.InitializeComponent();

            ListViewMessages.ItemsSource = Connection.GetMessages(1);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SendMessage();
        }

        private void SendMessage()
        {
            RichEditBoxMessage.TextDocument.GetText(TextGetOptions.None, out string message);
            if (!string.IsNullOrWhiteSpace(message) && !string.IsNullOrEmpty(message) && !message.Contains("\r"))
            {
                Connection.SendMessage(message, 1, 2);
                RichEditBoxMessage.TextDocument.SetText(TextSetOptions.None, String.Empty);
                ListViewMessages.ItemsSource = Connection.GetMessages(1);
            }
        }

        //private async void SaveMessage()
        //{
        //    var messageDialog = new MessageDialog($"Сохранение файла!");
        //    _ = await messageDialog.ShowAsync();

        //    FileSavePicker savePicker = new FileSavePicker
        //    {
        //        SuggestedStartLocation = PickerLocationId.Desktop
        //    };

        //    // Dropdown of file types the user can save the file as
        //    savePicker.FileTypeChoices.Add("Rich Text Format", new List<string>() { ".rtf" });

        //    // Default file name if the user does not type one in or select a file to replace
        //    savePicker.SuggestedFileName = $"Message {DateTime.Now.ToLongTimeString()}";

        //    StorageFile file = await savePicker.PickSaveFileAsync();

        //    if (!(file is null))
        //    {
        //        // Prevent updates to the remote version of the file until we
        //        // finish making changes and call CompleteUpdatesAsync.
        //        CachedFileManager.DeferUpdates(file);
        //        // write to file
        //        IRandomAccessStream randomAccessStream =
        //            await file.OpenAsync(FileAccessMode.ReadWrite);

        //        RichEditBoxMessage.Document.SaveToStream(TextGetOptions.FormatRtf, randomAccessStream);

        //        // Let Windows know that we're finished changing the file so the
        //        // other app can update the remote version of the file.
        //        FileUpdateStatus status = await CachedFileManager.CompleteUpdatesAsync(file);
        //        if (status != FileUpdateStatus.Complete)
        //        {
        //            var errorBox = new MessageDialog($"Файл {file.Name} couldn't be saved.", "Ошибка сохранения файла");

        //            _ = await errorBox.ShowAsync();
        //        }
        //    }
        //}
    }
}
