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
                await DisplayAlert("Liat Woi", error, "Ok");
                return;
            }

            await this.TranslateTo(-this.Width, 0, 220, Easing.CubicInOut);

            Application.Current.MainPage = new AppShell();

            this.TranslationX = 0;
        }
        private string? ValidateLogin(string? username, string? password)
        {
            if (string.IsNullOrWhiteSpace(username) && string.IsNullOrWhiteSpace(password))
                return "Anda bodoh ya?";

            if (string.IsNullOrWhiteSpace(username))
                return "Username wajib diisi";

            if (string.IsNullOrWhiteSpace(password))
                return "Password wajib diisi";

            if (username == "admin" && password == "admin")
                return "Anda bukan Admin";

            return null;
        }

    }

}
