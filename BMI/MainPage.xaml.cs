namespace BMI;

public partial class MainPage : ContentPage
{
	double highti = 110;
	double wighti = 1;
    double BMI = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{

	}

    private void calc_Clicked(object sender, EventArgs e)
    {
       highti = hight.Value;
        wighti = weight.Value;
        BMI = wighti / (highti / 100 * highti / 100) ;
        BMI = BMI % 100;

        if (BMI < 18.5)
        {
            bmival.Text = $" your BMI is : {BMI.ToString("F1")}" +
                $" you are Under weight";
        }
        else if (BMI < 25 && BMI> 18.5)
        {
            bmival.Text = $" your BMI is : {BMI.ToString("F1")} " +
                $"you are in Proper weight";
        }
        else if (BMI < 25 && BMI < 29.9)
        {
            bmival.Text = $" your BMI is : {BMI.ToString("F1")  }  you are Over weight";
        }
        else if (BMI> 30)
        {
            bmival.Text = $" your BMI is : {BMI.ToString("F1")}" 
                +
                 " you are in obesity";
        }

        
    }

   
}
