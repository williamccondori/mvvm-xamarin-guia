using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MvvmGuia.VistaModelo
{
    public class VMPagina1 : BaseViewModel
    {
        #region VARIABLES
        private string _Mensaje;
        #endregion
        #region CONSTRUCTOR
        public VMPagina1(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region OBJETOS
        public string Mensaje
        {
            get => _Mensaje;
            set => SetValue(ref _Mensaje, value);
        }
        #endregion
        #region PROCESOS
        public async Task AlertaAsync()
        {
            await DisplayAlert("Titulo", Mensaje, "OK");
        }

        public void Alerta()
        {

        }
        #endregion
        #region COMANDO
        public ICommand AlertaAsyncCommand => new Command(async () => await AlertaAsync());
        public ICommand AlertaCommand => new Command(() => Alerta());
        #endregion
    }
}
