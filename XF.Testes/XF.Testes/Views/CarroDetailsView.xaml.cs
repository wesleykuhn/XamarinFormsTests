using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XF.Testes.Models;

namespace XF.Testes.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarroDetailsView : ContentView
    {
        public static BindableProperty CarroProperty =
            BindableProperty.Create(nameof(Carro), typeof(CarroModel), typeof(CarroDetailsView), null);

        public CarroModel Carro
        {
            get => (CarroModel)GetValue(CarroProperty);
            set => SetValue(CarroProperty, value);
        }

        public CarroDetailsView()
        {
            InitializeComponent();
        }
    }
}