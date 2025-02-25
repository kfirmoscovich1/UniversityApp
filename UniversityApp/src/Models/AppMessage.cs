using System;
using System.Collections.Generic;

namespace UniversityApp
{
    public class AppMessage
    {
        public string Date { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Content { get; set; }
        public string Importance { get; set; }

        public AppMessage() { }
        

        public class MessagesRoot
        {
            public List<AppMessage> Messages { get; set; }
        }
    

    public AppMessage(string date, string sender, string receiver, string content, string importance)
        {
            Date = date;
            Sender = sender;
            Receiver = receiver;
            Content = content;
            Importance = importance;
        }

        public override string ToString()
        {
            return $"Date: {Date}, Sender: {Sender}, Receiver: {Receiver}, Content: {Content}, Importance: {Importance}";
        }
    }

    public class MessagesRoot
    {
        public List<Message> Messages { get; set; }
    }
}
