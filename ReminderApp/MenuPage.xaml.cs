namespace ReminderApp;

public partial class MenuPage : ContentPage
{
	public MenuPage()
	{
		InitializeComponent();
	}
    private async void OnReminderClicked(object sender, TappedEventArgs e)
    {
        Application.Current.MainPage = new ReminderPage();
    }
}