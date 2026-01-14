namespace ReminderApp
{
    public partial class MainPage : ContentPage
    {
        public int attemptlogin = 0;
        public MainPage()
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
                await DisplayAlert("Warning", error, "OK");
                return;
            }
        }

        private string? ValidateLogin(string? username, string? password)
        {
            if (string.IsNullOrWhiteSpace(username))
                return "Username wajib diisi";

            if (string.IsNullOrWhiteSpace(password))
                return "Password wajib diisi";

            return null;
        }

    }

}
