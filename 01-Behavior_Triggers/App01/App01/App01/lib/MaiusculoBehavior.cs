using Xamarin.Forms;

namespace App01.lib
{
    public class MaiusculoBehavior: Behavior<Entry>  // Behavior => Comportamento
    {
        // adiciona uma informção ao campo entry
        protected override void OnAttachedTo(Entry bindable)
        {
            base.OnAttachedTo(bindable);

            bindable.TextChanged += MaiusculoAction;
        }


        // remove a informação
        protected override void OnDetachingFrom(Entry bindable)
        {
            base.OnDetachingFrom(bindable);

            bindable.TextChanged += MaiusculoAction;
        }

        
        private static void MaiusculoAction(object sender, TextChangedEventArgs args)
        {
            /* 
             *  
             *  prop NewTextValue - novo valor do campo
             *  prop  OldTextValue - valor anterior 
             */

            // verifica se o entry contem algum valor
            if (!string.IsNullOrEmpty(args.OldTextValue))
            {
                ((Entry) sender).Text = args.NewTextValue.ToUpper();
            }
        }

       
    }
}



