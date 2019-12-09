using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace AnotadorTruco
{
    public class MyContentPage : ContentPage
    {
        public MyContentPage()
        {


            var label = new Label
            {
                Text = "Primer equipo"
            };

            var txtNombre = new Entry
            {
                Placeholder = "Escribe tu nombre"
            };

            var label2 = new Label
            {
                Text = "Segundo equipo"
            };

            var txtNombre2 = new Entry
            {
                Placeholder = "Escribe tu nombre"
            };

            var btnAvanzar = new Button
            {
                Text = "Avanzar"
            };

            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 10,
                Children = { label, txtNombre, label2, txtNombre2, btnAvanzar}
            };



 
        }
    }
}
