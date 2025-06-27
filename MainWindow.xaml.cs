using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace CyberChatbot
{
    public partial class MainWindow : Window
    {
        NLPProcessor nlp = new NLPProcessor();
        public static List<TaskModel> TaskList = new();
        public static List<LogEntry> ActivityLog = new();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Send_Click(object sender, RoutedEventArgs e)
        {
            string input = UserInput.Text;
            ChatHistory.Items.Add("You: " + input);

            string response = nlp.ProcessInput(input);
            ChatHistory.Items.Add("Bot: " + response);
            UserInput.Text = "";
        }

        private void OpenTasks_Click(object sender, RoutedEventArgs e)
        {
            TaskManager taskManager = new();
            taskManager.Show();
        }

        private void OpenQuiz_Click(object sender, RoutedEventArgs e)
        {
            QuizWindow quiz = new();
            quiz.Show();
        }

        private void OpenLog_Click(object sender, RoutedEventArgs e)
        {
            ActivityLogWindow logWindow = new();
            logWindow.Show();
        }
    }
}
