using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Funcionais.Modelo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Funcionais.Pagina
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ListView : ContentPage
	{
		public ListView ()
		{
			InitializeComponent ();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Nome = "Jose", Cargo = "Eu" });
            Lista.Add(new Funcionario() { Nome = "Rafael", Cargo = "Sou" });
            Lista.Add(new Funcionario() { Nome = "Gabriel", Cargo = "Patrão" });
            Lista.Add(new Funcionario() { Nome = "Jose", Cargo = "Não" });
            Lista.Add(new Funcionario() { Nome = "Guilherme", Cargo = "Funcionario" });

            ListaFuncionario.ItemsSource = Lista;
        }

        private void ItemSelecionadoAction(object sender, SelectedItemChangedEventArgs args)
        {
            Funcionario func = (Funcionario)args.SelectedItem;
            Navigation.PushAsync(new Detalhe.Datail(func));
        }

        private void FeriasAction(object sender, EventArgs e)
        {
            MenuItem botao = (MenuItem)sender;
            Funcionario func = (Funcionario)botao.CommandParameter;
            DisplayAlert("Titulo: " + func.Nome, "Mensagem: " + func.Cargo, "Ok");
        }

        private void AbonoAction(object sender, EventArgs e)
        {

        }
    }
}