using System.Linq;
using System.Windows;

namespace CyberChatbot
{
    public partial class ActivityLogWindow : Window
    {
        public ActivityLogWindow()
        {
            InitializeComponent();
            LogList.ItemsSource = MainWindow.ActivityLog.TakeLast(10).Select(x => x.Action);
        }
    }
}
