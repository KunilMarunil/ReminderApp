namespace ReminderApp
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;

            if (count == 1)
                CounterBtn.Text = $"Clicked {count} time";
            else
                CounterBtn.Text = $"Clicked {count} times";

            SemanticScreenReader.Announce(CounterBtn.Text);
        }

        void InputUsername(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;
            string myText = UsernameEntry.Text;
        }

        void InputUsernameDone (object sender, EventArgs e)
        {
            string text = ((Entry)sender).Text;
            OutputUsername.Text = text;
            SemanticScreenReader.Announce(OutputUsername.Text);
        }
    }

}
