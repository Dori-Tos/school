namespace school.Views;

public partial class StudentsPage : ContentPage
{
	public StudentsPage()
	{
		InitializeComponent();
	}

    private async void OnAddEvalButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///AddEvalPage");
    }

    private async void OnBulletinButtonClicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("///BulletinPage");
    }
}