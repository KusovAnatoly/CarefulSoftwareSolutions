using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Messages.Models.Models
{
    public static class DataStructure
    {
        public static ICollection<Profile> Profiles { get; set; }
        public static ICollection<Message> Messages { get; set; }
        public static ICollection<Chat> Chats { get; set; }

        public static void GenerateData()
        {
            //Profiles = new List<Profile>
            //{
            //    new Profile
            //    {
            //        ProfileId = 1,
            //        FirstName = "Иван",
            //        LastName = "Иванов",
            //        Nickname = "@IvanovIvan",
            //        Image = "https://images.unsplash.com/photo-1506794778202-cad84cf45f1d?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxzZWFyY2h8Mnx8cG9ydHJhaXQlMjBtYW58ZW58MHx8MHx8&w=1000&q=80",

            //    },
            //    new Profile
            //    {
            //        ProfileId = 2,
            //        FirstName = "Елизавета",
            //        LastName = "Петрова",
            //        Nickname = "@PetrovaLiza",
            //        Image = "https://docs.microsoft.com/windows/uwp/contacts-and-calendar/images/shoulder-tap-static-payload.png"
            //    }
            //};
            //var time = DateTime.Now;
            //Messages = new List<Message>
            //{
            //    new Message
            //    {
            //        DateTimeSend = time,
            //        DateTimeRead = time = time.AddSeconds(10),
            //        SenderId = Profiles..First(x => x.ProfileId == 1).Se,
            //        ReceiverId = Profiles.First(x => x.ProfileId == 2),
            //        Text = "Привет, Лиза!",
            //        Alignment = Alignment.Right
            //    },
            //    new Message
            //    {
            //        DateTimeSend = time = time.AddSeconds(10),
            //        DateTimeRead = time = time.AddSeconds(10),
            //        SenderId = Profiles.First(x => x.ProfileId == 2),
            //        ReceiverId = Profiles.First(x => x.ProfileId == 1),
            //        Text = "Привет, Ваня!",
            //        Alignment = Alignment.Left
            //    },
            //    new Message
            //    {
            //        DateTimeSend = time = time.AddSeconds(10),
            //        DateTimeRead = time = time.AddSeconds(10),
            //        SenderId = Profiles.First(x => x.ProfileId == 1),
            //        ReceiverId = Profiles.First(x => x.ProfileId == 2),
            //        Text = "Как поживаешь, Лиза!",
            //        Alignment = Alignment.Right
            //    },
            //    new Message
            //    {
            //        DateTimeSend = time = time.AddSeconds(10),
            //        DateTimeRead = time = time.AddSeconds(10),
            //        SenderId = Profiles.First(x => x.ProfileId == 2),
            //        ReceiverId = Profiles.First(x => x.ProfileId == 1),
            //        Text = "Отлично, Ваня!",
            //        Alignment = Alignment.Left
            //    }
            //};
            //Chats = new List<Chat>
            //{
            //    new Chat
            //    {
            //        Sender = Profiles.First(x => x.ProfileId == 1),
            //        Receiver = Profiles.First(x => x.ProfileId == 2),
            //        Messages = Messages.Where(x => x.Sender.ProfileId == 1),
            //        LastMessage = Messages.LastOrDefault(x => x.Sender.ProfileId == 1 && x.DateTimeSend <= DateTime.Now.AddSeconds(70))
            //    },
            //    new Chat
            //    {
            //        Sender = Profiles.First(x => x.ProfileId == 2),
            //        Receiver = Profiles.First(x => x.ProfileId == 1),
            //        Messages = Messages.Where(x => x.Sender.ProfileId == 2),
            //        LastMessage = Messages.LastOrDefault(x => x.Sender.ProfileId == 2 && x.DateTimeSend <= DateTime.Now.AddSeconds(70))
            //    }
            //};
        }
    }
}
