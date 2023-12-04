namespace FlexLayoutPresentation;

public partial class FlexWrapPage : ContentPage
{
	public FlexWrapPage()
	{
		InitializeComponent();
	}

	public void PageLayoutClicked(object sender, EventArgs e)
	{
		Navigation.PushAsync(new PageLayoutFlex());
	}
}