using Microsoft.Maui.Controls;

namespace Patel8sd_ContactList;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();

        MainPage = new NavigationPage(new MainPage());
    }
}
