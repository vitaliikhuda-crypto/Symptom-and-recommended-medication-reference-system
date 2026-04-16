using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;
using System.Windows.Input;

namespace MedSearchWPF.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private Page _currentPage;

        public Page CurrentPage
        {
            get => _currentPage;
            set
            {
                _currentPage = value;
                OnPropertyChanged();
            }
        }

        public ICommand NavigateCommand { get; }

        public MainViewModel()
        {
            NavigateCommand = new RelayCommand(Navigate);

            // стартова сторінка
            CurrentPage = new AllPage();
        }

        private void Navigate(object parameter)
        {
            string page = parameter.ToString();

            CurrentPage = page switch
            {
                "search" => new AllPage(),
                "medicines" => new MedicineEditPage(),
                "list" => new AllPage(),
                "settings" => new AllPage(),
                _ => new AllPage()
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
