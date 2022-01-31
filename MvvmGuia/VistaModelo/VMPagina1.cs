using System;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmGuia.VistaModelo
{
    public class VMPagina1 : BaseViewModel
    {
        #region VARIABLES
        private string _N1;
        private string _N2;
        private string _Respuesta;
        #endregion
        #region CONSTRUCTOR
        public VMPagina1(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        public string N1
        {
            get => _N1;
            set => SetValue(ref _N1, value);
        }

        public string N2
        {
            get => _N2;
            set => SetValue(ref _N2, value);
        }
        public string Respuesta
        {
            get => _Respuesta;
            set => SetValue(ref _Respuesta, value);
        }
        #endregion
        #region PROCESOS
        public void Sumar()
        {
            double n1 = Convert.ToDouble(N1);
            double n2 = Convert.ToDouble(N2);
            double respuesta = n1 + n2;
            Respuesta = respuesta.ToString();
        }
        #endregion
        #region COMANDO 
        public ICommand SumarCommand => new Command(() => Sumar());
        #endregion
    }
}
