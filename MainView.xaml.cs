using System.Windows;

namespace MedSearchApp.Views
{
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            string symptom = SymptomTextBox.Text.ToLower();

            if (string.IsNullOrWhiteSpace(symptom))
            {
                MessageBox.Show("Будь ласка, введіть симптом.");
                return;
            }

            if (symptom == "кашель")
                ResultTextBox.Text = "Рекомендовано: сироп від кашлю";
            else if (symptom == "температура")
                ResultTextBox.Text = "Рекомендовано: парацетамол";
            else
                ResultTextBox.Text = "За даним симптомом інформацію не знайдено.";
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            SymptomTextBox.Clear();
            ResultTextBox.Clear();
        }

        private void Info_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("МедПошук\nДовідкова система для пошуку ліків за симптомами.", "Інформація");
        }
    }
}
