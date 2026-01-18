namespace ReminderApp;

public partial class HomePage : ContentPage
{
	public HomePage()
	{
		InitializeComponent();
	}
    private void OnLogoutClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new LoginPage();
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await Task.Yield();

        this.TranslationX = this.Width <= 0 ? 400 : this.Width;

        await this.TranslateTo(0, 0, 120, Easing.CubicInOut);
    }
}