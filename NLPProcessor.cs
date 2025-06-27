using System;
using System.Linq;

namespace CyberChatbot
{
    public class NLPProcessor
    {
        public string ProcessInput(string input)
        {
            input = input.ToLower();

            if (input.Contains("add task") || input.Contains("set a reminder"))
            {
                MainWindow.TaskList.Add(new TaskModel
                {
                    Title = "Sample Task",
                    Description = "Example from input",
                    ReminderDate = DateTime.Now.AddDays(3)
                });
                MainWindow.ActivityLog.Add(new LogEntry { Action = "Added a task." });
                return "Task added. Check the Tasks window.";
            }
            else if (input.Contains("quiz"))
            {
                return "You can open the Quiz using the 'Quiz' button.";
            }
            else if (input.Contains("show activity log") || input.Contains("what have you done"))
            {
                string log = string.Join("\n", MainWindow.ActivityLog.Select(l => l.Action));
                return string.IsNullOrEmpty(log) ? "No recent activities." : log;
            }
            else if (input.Contains("hello") || input.Contains("hi"))
            {
                return "Hello! How can I help with your cybersecurity today?";
            }
            else
            {
                return "Sorry, I didn't understand that. Try 'Add task', 'Quiz' or 'Show activity log'.";
            }
        }
    }
}
