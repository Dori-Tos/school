namespace school.Views;

public partial class TombolaPage : ContentPage
{
	public TombolaPage()
	{
		InitializeComponent();
	}
    private async void OnHomeButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///HomePage");
    }
}