namespace FlexLayoutPresentation;

public partial class FlexLayoutPage : ContentPage
{
	public FlexLayoutPage()
	{
		InitializeComponent();
	}

	public void GoToWrapFlexPage(object sender, EventArgs e)
	{
		Navigation.PushAsync(new FlexWrapPage());
	}
}