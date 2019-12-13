using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AnotadorTruco
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Anotador : ContentPage
	{
		public Anotador ()
		{
			InitializeComponent ();

            
		}


        void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            _rotatingLabel.Rotation = value;
           // _rotatingLabel2.Rotation = value;
            ContadorEquipo1.Text = string.Format("{0}", value);
            if (value == 18)
                DisplayAlert("Ganador", labelEquipoNegro.Text, "Continuar");

        }

        void OnStepperValueChanged2(object sender, ValueChangedEventArgs e)
        {
            double value2 = e.NewValue;
            _rotatingLabel2.Rotation = value2;
            ContadorEquipo2.Text = string.Format("{0}", value2);
            if (value2 == 18)
               DisplayAlert("Ganador", labelEquipoBlanco.Text, "Continuar");
        }

        

    }
}