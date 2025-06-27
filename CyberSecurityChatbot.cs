using System;
using System.Media;
using System.Windows;

namespace WpfApp1
{
    public class CyberSecurityChatbot
    {
        public void Run()
        {
            PlayVoiceGreeting();
            DisplayASCIIArt();
            InteractWithUser();
        }

        private void PlayVoiceGreeting()
        {
            try
            {
                using (SoundPlayer player = new SoundPlayer("johnny.wav"))
                {
                    player.PlaySync();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error playing sound: " + ex.Message);
            }
        }

        private void DisplayASCIIArt()
        {
            string art = @"
   _____           _     _                 _             
  / ____|         | |   (_)               | |            
 | |     ___ _ __ | |__  _ _ __ ___   __ _| |_ ___  _ __ 
 | |    / _ \\ '_ \\| '_ \\| | '_ ` _ \\ / _` | __/ _ \\| '__|
 | |___|  __/ | | | | | | | | | | | | (_| | || (_) | |   
  \\_____\\___|_| |_|_| |_|_|_| |_| |_|\\__,_|\\__\\___/|_|   
";
            MessageBox.Show(art, "ASCII Art");
        }

        private void InteractWithUser()
        {
            MessageBox.Show("Hello! I'm your cybersecurity chatbot.\n(This used to be console interaction.)");
        }
    }
}
