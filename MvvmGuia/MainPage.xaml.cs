using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MvvmGuia
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Ok", "Esta es una alerta", "OK");
        }
    }
}
