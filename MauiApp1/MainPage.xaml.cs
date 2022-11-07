namespace MauiApp1;

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

	private void OnExtraClicked(object sender, EventArgs e)
	{
		
		if (Extra_Label.Text == "Hi you changed Me")
		{
			Extra_Label.Text = "Oops Something Differents";
		}
		else
		{
			Extra_Label.Text = "Hi you Changed Me";
		}
	}
}

