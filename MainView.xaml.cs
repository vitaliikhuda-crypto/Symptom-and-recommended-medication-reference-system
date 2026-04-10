using System.Windows;
using System.Windows.Controls;

namespace MedSearchApp.Views
{
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();

            ShowHome(null, null);
        }

        private void ShowHome(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new TextBlock
            {
                Text = "Головний екран",
                FontSize = 24,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };
        }

        private void ShowResults(object sender, RoutedEventArgs e)
        {
            string symptom = "кашель";

            MainFrame.Content = new TextBlock
            {
                Text = "Результати для: " + symptom,
                FontSize = 20,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };
        }

        private void ShowInfo(object sender, RoutedEventArgs e)
        {
            MainFrame.Content = new TextBlock
            {
                Text = "Інформація про програму",
                FontSize = 20,
                HorizontalAlignment = HorizontalAlignment.Center,
                VerticalAlignment = VerticalAlignment.Center
            };
        }
    }
}
