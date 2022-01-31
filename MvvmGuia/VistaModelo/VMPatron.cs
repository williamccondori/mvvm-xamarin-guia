using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmGuia.VistaModelo
{
    public class VMPatron : BaseViewModel
    {
        #region VARIABLES
        string _Texto;
        #endregion
        #region CONSTRUCTOR
        public VMPatron(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region PROCESOS
        public async Task ProcesoAsyncrono()
        {

        }

        public void ProcesoSincrono()
        {

        }
        #endregion
        #region COMANDO
        public ICommand ProcesoAsyncCommand => new Command(async () => await ProcesoAsyncrono());
        public ICommand ProcesoSincronoCommand => new Command(() => ProcesoSincrono());
        #endregion
    }
}
