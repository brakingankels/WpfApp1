using System;

namespace CyberChatbot
{
    public class TaskModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? ReminderDate { get; set; }
    }
}
