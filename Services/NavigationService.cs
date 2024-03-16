using Avalonia.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AvaloniaApplication6.Services
{
    public class NavigationService : INavigationService
    {
        private readonly Window _mainWindow;
        private readonly Dictionary<Type, Type> _registrations;

        public NavigationService(Window mainWindow)
        {
            _mainWindow = mainWindow;
            _registrations = new Dictionary<Type, Type>();
        }

        public void Register<TViewModel, TView>() where TViewModel : class where TView : Control
        {
            _registrations[typeof(TViewModel)] = typeof(TView);
        }

        public void NavigateTo<TViewModel>(TViewModel viewModel) where TViewModel : class
        {
            if(_registrations.TryGetValue(typeof(TViewModel), out var viewType))
            {
                var view = (Control)Activator.CreateInstance(viewType)!;
                view.DataContext = viewModel;
                _mainWindow.Content = view;
            }
            else
            {
                throw new Exception($"View model {typeof(TViewModel)} is not registered");
            }
        }
    }
}
