using System;

namespace Messages.Models
{
    public enum Alignment
    {
        Left,
        Right
    }

    public class Message
    {
        public int MessageId { get; set; }
        public string Text { get; set; }
        public int SenderId { get; set; }
        public Sender Sender { get; set; }
        public int ReceiverId { get; set; }
        public Receiver Receiver { get; set; }
        public DateTime DateTimeSend { get; set; }
        public DateTime DateTimeRead { get; set; }
        public bool IsDeletedForSender { get; set; }
        public bool IsDeletedForReceiver { get; set; }
        public Alignment Alignment { get; set; }

        public Message()
        {

        }

        //message alignment logic

        public override string ToString()
        {
            return DateTimeSend.ToString() + "\n" + Text;
        }
    }
}
