using ModernWpf.Controls;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WindowsSettingsUi
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ContentFrame.Navigate(new Pages.HomePage());
        }

        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            if (args.InvokedItemContainer is NavigationViewItem item)
            {
                switch (item.Tag)
                {
                    case "home":
                        ContentFrame.Navigate(new Pages.HomePage());
                        break;
                    case "projects":
                        ContentFrame.Navigate(new Pages.AboutPage());
                        break;
                    case "about":
                        ContentFrame.Navigate(new Pages.AboutPage());
                        break;
                    case "settings":
                        ContentFrame.Navigate(new Pages.SettingsPage());
                        break;
                }
            }
        }
    }
}