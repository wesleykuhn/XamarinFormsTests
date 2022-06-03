using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Testes.Models;

namespace XF.Testes.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FrutaDetailsView : ContentView
    {
        public static BindableProperty FrutaProperty =
            BindableProperty.Create(nameof(Fruta), typeof(FrutaModel), typeof(FrutaDetailsView), null);

        public FrutaModel Fruta
        {
            get => (FrutaModel)GetValue(FrutaProperty);
            set => SetValue(FrutaProperty, value);
        }
        public FrutaDetailsView()
        {
            InitializeComponent();
        }
    }
}