using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AnotadorTruco
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            
            btnAvanzar.Clicked += (sender,e) =>
           {

               Navigation.PushAsync(new Anotador());
           };
        }

       /* private async void BtnAvanzar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Anotador(Convert.ToString(lblEquipo1), Convert.ToString(lblEquipo2)));
        }*/


    }
}
