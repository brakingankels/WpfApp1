using System.Collections.Generic;
using System.Linq;
using System.Windows;

namespace CyberChatbot
{
    public partial class QuizWindow : Window
    {
        List<QuizQuestion> questions;
        int current = 0;
        int score = 0;

        public QuizWindow()
        {
            InitializeComponent();
            questions = LoadQuestions();
            ShowQuestion();
        }

        private List<QuizQuestion> LoadQuestions()
        {
            return new List<QuizQuestion>
            {
                new QuizQuestion {
                    Question = "What should you do if you receive an email asking for your password?",
                    Options = new List<string> { "A) Reply with password", "B) Delete it", "C) Report as phishing", "D) Ignore it"},
                    CorrectIndex = 2,
                    Explanation = "Reporting phishing helps prevent scams."
                },
                // Add 9 more questions here...
            };
        }

        private void ShowQuestion()
        {
            if (current < questions.Count)
            {
                var q = questions[current];
                QuestionText.Text = q.Question;
                OptionsList.ItemsSource = q.Options;
            }
            else
            {
                MessageBox.Show($"Quiz complete! Score: {score}/{questions.Count}");
                MainWindow.ActivityLog.Add(new LogEntry { Action = $"Completed Quiz. Score: {score}" });
                Close();
            }
        }

        private void Submit_Click(object sender, RoutedEventArgs e)
        {
            if (OptionsList.SelectedIndex == -1) return;

            var q = questions[current];

            if (OptionsList.SelectedIndex == q.CorrectIndex)
            {
                MessageBox.Show("Correct!\n" + q.Explanation);
                score++;
            }
            else
            {
                MessageBox.Show("Incorrect.\n" + q.Explanation);
            }

            current++;
            ShowQuestion();
        }
    }
}
