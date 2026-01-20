namespace ReminderApp
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private async void OnSubmitClicked(object sender, EventArgs e)
        {
            var username = UsernameEntry.Text;
            var password = PasswordEntry.Text;

            var error = ValidateLogin(UsernameEntry.Text, PasswordEntry.Text);

            if (error != null)
            {
                await DisplayAlert("Error", error, "Ok");
                UsernameEntry.Text = "";
                PasswordEntry.Text = "";
                return;
            }

            await this.TranslateTo(-this.Width, 0, 220, Easing.CubicInOut);

            Application.Current.MainPage = new AppShell();

            await Shell.Current.GoToAsync(
                $"{nameof(HomePage)}?username={Uri.EscapeDataString(username)}");

            this.TranslationX = 0;
        }
        private string? ValidateLogin(string? username, string? password)
        {
            if (string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(password))
                return "Lu bodoh ya?";

            if (string.IsNullOrWhiteSpace(username))
                return "Username wajib diisi";

            if (string.IsNullOrWhiteSpace(password))
                return "Password wajib diisi";

            if (password != "kambing")
                return "Password salah, coba lagi";

            if (username != "Rama")
                return "Lu siapa dah?";
            return null;
        }
    }
}
