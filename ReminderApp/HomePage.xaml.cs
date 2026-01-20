namespace ReminderApp;

[QueryProperty(nameof(Username), "username")]
public partial class HomePage : ContentPage
{
    private string _username;

    public string Username
    {
        get => _username;
        set
        {
            _username = Uri.UnescapeDataString(value);
            UsernameLabel.Text = $"Halo {_username}";
        }
    }
	public HomePage()
	{
		InitializeComponent();
	}
    private void OnLogoutClicked(object sender, EventArgs e)
    {
        Application.Current.MainPage = new LoginPage();
    }
    private void OnGoToMenu(object sender, EventArgs e)
    {
        Application.Current.MainPage = new MenuPage();
    }
    protected override async void OnAppearing()
    {
        base.OnAppearing();

        await Task.Yield();

        this.TranslationX = this.Width <= 0 ? 400 : this.Width;

        await this.TranslateTo(0, 0, 150, Easing.CubicInOut);
    }
}