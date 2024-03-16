using AvaloniaApplication6.Services;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace AvaloniaApplication6.ViewModels
{
    public class HomePageViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        public HomePageViewModel()
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
        {
            // Этот конструктор класса я использую, чтобы не было ошибки в MainPageViewModel
        }

        public HomePageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateCommand = new RelayCommand(Navigate);
        }

        public ICommand NavigateCommand { get; }

        private void Navigate()
        {
            _navigationService.NavigateTo(new TestPageViewModel());
        }
    }
}
