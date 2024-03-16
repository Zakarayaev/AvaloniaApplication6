using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Data.Core;
using Avalonia.Data.Core.Plugins;
using Avalonia.Markup.Xaml;
using AvaloniaApplication6.Services;
using AvaloniaApplication6.ViewModels;
using AvaloniaApplication6.Views;

namespace AvaloniaApplication6
{
public partial class App : Application
{
public override void Initialize()
{
AvaloniaXamlLoader.Load(this);
}

public override void OnFrameworkInitializationCompleted()
{
if(ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
{
BindingPlugins.DataValidators.RemoveAt(0);
desktop.MainWindow = new MainWindow
{
DataContext = new MainWindowViewModel(),
};
// Create the navigation service and register the views and view models
var navigationService = new NavigationService(desktop.MainWindow);
navigationService.Register<MainPageViewModel, MainPageView>();
    navigationService.Register<HomePageViewModel, HomePageView>();
        navigationService.Register<TestPageViewModel, TestPageView>();

            // Navigate to the main page as the initial page
            navigationService.NavigateTo(new MainPageViewModel(navigationService));
            }

            base.OnFrameworkInitializationCompleted();
            }
            }
            }