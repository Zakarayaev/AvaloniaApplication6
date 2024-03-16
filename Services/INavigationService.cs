using Avalonia.Controls;

namespace AvaloniaApplication6.Services
{
    public interface INavigationService
    {
        void Register<TViewModel, TView>() where TViewModel : class where TView : Control;
        void NavigateTo<TViewModel>(TViewModel viewModel) where TViewModel : class;
    }
}
