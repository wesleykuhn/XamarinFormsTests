using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Testes.Models;

namespace XF.Testes.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class UsuarioDetailsView : ContentView
    {
        public static BindableProperty UsuarioProperty =
            BindableProperty.Create(nameof(Usuario), typeof(UsuarioModel), typeof(UsuarioDetailsView), null);

        public UsuarioModel Usuario
        {
            get => (UsuarioModel)GetValue(UsuarioProperty);
            set => SetValue(UsuarioProperty, value);
        }

        public UsuarioDetailsView()
        {
            InitializeComponent();
        }
    }
}