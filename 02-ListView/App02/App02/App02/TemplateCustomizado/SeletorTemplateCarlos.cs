using System.Runtime.InteropServices.WindowsRuntime;
using Xamarin.Forms;

namespace App02.TemplateCustomizado
{
    public class SeletorTemplateCarlos: DataTemplateSelector
    {
        public DataTemplate ItemPessoaObrigatoria { get; }
        public DataTemplate ItemPessoaNObrigatoria { get; }

        public SeletorTemplateCarlos()
        {
            ItemPessoaObrigatoria = new DataTemplate(typeof(ItemPessoaObrigatorioViewCell));
            ItemPessoaNObrigatoria = new DataTemplate(typeof(ItemPessoaNObrigatorioViewCell));
        }
        protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
        {
            return ((MainPage.Pessoa) item).IsObrigatorio ? ItemPessoaObrigatoria : ItemPessoaNObrigatoria;
        }
    }
}