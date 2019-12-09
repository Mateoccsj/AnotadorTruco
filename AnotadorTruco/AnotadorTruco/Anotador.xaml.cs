using System;
using System.Collections.Generic;
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

            
           // lblEquipo1.Text = e1;

           // lblEquipo2.Text = e2;
		}


        void OnStepperValueChanged(object sender, ValueChangedEventArgs e)
        {
            double value = e.NewValue;
            _rotatingLabel.Rotation = value;
           // _rotatingLabel2.Rotation = value;
            ContadorEquipo1.Text = string.Format("{0}", value);
           // ContadorEquipo2.Text = string.Format("{0}", value);
        }

        void OnStepperValueChanged2(object sender, ValueChangedEventArgs e)
        {
            double value2 = e.NewValue;
            _rotatingLabel2.Rotation = value2;
            ContadorEquipo2.Text = string.Format("{0}", value2);
        }

    }
}