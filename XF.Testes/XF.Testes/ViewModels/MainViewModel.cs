using System.Collections.ObjectModel;
using XF.Testes.Models;

namespace XF.Testes.ViewModels
{
    public class MainViewModel : BaseViewModel
    {

        private ObservableCollection<ListagemModel> _listagens;
        public ObservableCollection<ListagemModel> Listagens
        {
            get => _listagens;
            set => SetProperty(ref _listagens, value);
        }

        public MainViewModel()
        {
            var array = new ListagemModel[]
            {
                new()
                {
                    Tipo = TipoEnum.Carro,
                    Carro = new(){ Codigo = 122, Marca = "Gol" }
                },
                new()
                {
                    Tipo = TipoEnum.Fruta,
                    Fruta = new(){ Id = 84420, Cor = "Verde" }
                },
                new()
                {
                    Tipo = TipoEnum.Usuario,
                    Usuario = new(){ Id = 10, Name = "João" }
                }
            };

            Listagens = new ObservableCollection<ListagemModel>(array);
        }
    }
}
