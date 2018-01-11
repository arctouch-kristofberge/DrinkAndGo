using Xamarin.Forms;

namespace DrinkAndGo
{
    public partial class DrinkAndGoPage : ContentPage
    {
        public DrinkAndGoPage()
        {
            InitializeComponent();
        }

        private void OnFightClicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new FightPage());
        }
    }
}
