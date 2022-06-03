using System;
using System.Threading;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.IO;

namespace XF.Testes
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //minhaImagem.Source = new UriImageSource() { Uri = new Uri("https://media-exp1.licdn.com/dms/image/C5603AQFro1SoNFxlSw/profile-displayphoto-shrink_800_800/0/1633391050211?e=1649289600&v=beta&t=gVxD-MBVWJt2gzA_JWM-vAIAmtWUpewxbWTIEUu7Ygc") };
        }

        private void ButtonConverter_Clicked(object sender, EventArgs e)
        {
            //var converted = Converters.Image.ImageUriToBytes(EntryFotoUri.Text);

            //var ms = new MemoryStream(converted);

            //minhaImagem.Source = new StreamImageSource()
            //{
            //    Stream = async _ => ms
            //};
        }
    }
}
