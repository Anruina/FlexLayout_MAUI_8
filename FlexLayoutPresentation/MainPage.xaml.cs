namespace FlexLayoutPresentation
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void GoToFlexPage(object sender, EventArgs eventArgs)
        {
            Navigation.PushAsync(new FlexLayoutPage());
        }
    }

}
