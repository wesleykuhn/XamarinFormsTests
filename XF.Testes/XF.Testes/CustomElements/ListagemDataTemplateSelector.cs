using System;
using Xamarin.Forms;
using XF.Testes.Models;

namespace XF.Testes.CustomElements
{
    public class ListagemDataTemplateSelector : DataTemplateSelector
    {
        public DataTemplate CarroTemplate { get; set; }
        public DataTemplate UsuarioTemplate { get; set; }
        public DataTemplate FrutaTemplate { get; set; }

        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            if (item is ListagemModel listagem)
            {
                switch (listagem.Tipo)
                {
                    case TipoEnum.Carro:
                        return CarroTemplate;

                    case TipoEnum.Fruta:
                        return FrutaTemplate;

                    case TipoEnum.Usuario:
                        return UsuarioTemplate;
                }
            }

            return null;
        }
    }
}
