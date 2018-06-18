using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XF.ControlesBasicos.Model;

namespace XF.ControlesBasicos
{
	public partial class MainPage : ContentPage
	{
        private Email email;

		public MainPage()
		{
			InitializeComponent();

            if (email == null)
            {
                email = new Email();
            }
		}

        private void btnEnviar_Clicked(object sender, EventArgs e)
        {
            if (email.AceitaReceber && !String.IsNullOrEmpty(email.Conta))
            {
                DisplayAlert("Sucesso", $"E-mail enviado para {email.Conta}", "OK");
            }
            else
            {
                DisplayAlert("Ops", "O proprietário desta conta de e-mail não deseja receber informativos.", "OK");
            }
        }

        private async void btnConfiguracao_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new ConfigPage() { BindingContext = email });
        }
    }
}
