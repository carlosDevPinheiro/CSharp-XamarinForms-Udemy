using Xamarin.Forms;

namespace App01.lib
{
    public class EmailValidoTrigger: TriggerAction<Entry>
    {

        // metodo implementado 
        protected override void Invoke(Entry sender)
        {
            //  se o texto do entry tiver o @ na posicao 0 em diante é valido
            sender.TextColor = sender.Text.Contains("@") ? Color.Green : Color.Red ;
        }
    }
}