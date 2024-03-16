using AvaloniaApplication6.Services;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Windows.Input;

namespace AvaloniaApplication6.ViewModels
{
    public class MainPageViewModel : ObservableObject
    {
        private readonly INavigationService _navigationService;

        public MainPageViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
            NavigateCommand = new RelayCommand(Navigate);
        }

        public ICommand NavigateCommand { get; }

        private void Navigate()
        {
            _navigationService.NavigateTo(new HomePageViewModel());
        }
    }
}