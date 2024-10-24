using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Repaso_HACB
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(numero2Entry.Text)&& !string.IsNullOrEmpty(numero2Entry.Text))
            {
                int numero1 = int.Parse(numero1Entry.Text);
                int numero2 = int.Parse(numero2Entry.Text);

                int resultado = numero1 + numero2;

                resultadoLaber.Text = $"Resultado: {resultado}";
            }
            
        }
    }
}
