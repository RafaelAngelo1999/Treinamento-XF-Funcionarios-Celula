using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Funcionais.Modelo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Funcionais.Detalhe
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Datail : ContentPage
	{
		public Datail (Funcionario funcionario)
		{
			InitializeComponent ();
            TxtNome.Text = funcionario.Nome;
		}
	}
}