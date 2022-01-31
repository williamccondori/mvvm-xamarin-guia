using MvvmGuia.VistaModelo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MvvmGuia.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Pagina1 : ContentPage
    {
        public Pagina1()
        {
            InitializeComponent();
            BindingContext = new VMPagina1(Navigation);
        }
    }
}