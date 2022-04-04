using System;
using System.Collections.Generic;
using System.Linq;

namespace Messages.Models
{
    public class Chat
    {
        public int ChatId { get; set; }
        public Profile Sender { get; set; }
        public Profile Receiver { get; set; }
        public Message LastMessage { get; set; }
        public IEnumerable<Message> Messages { get; set; }
        public Chat()
        {

        }
    }
}
