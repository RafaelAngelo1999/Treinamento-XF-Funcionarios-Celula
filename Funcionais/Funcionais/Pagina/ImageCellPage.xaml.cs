using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Funcionais.Modelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Funcionais.Pagina;

namespace Funcionais.Pagina
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ImageCellPage : ContentPage
	{
		public ImageCellPage ()
		{

			InitializeComponent ();

            List<Funcionario> Lista = new List<Funcionario>();
            Lista.Add(new Funcionario() { Foto = "https://www.microlins.com.br/galeria/repositorio/images/noticias/como-posicionar-melhor-seu-perfil-no-linkedin/02-Como-posicionar-melhor-seu-perfil-do-Linkedin.png", Nome = "Jose", Cargo = "Eu" });
            Lista.Add(new Funcionario() { Foto = "https://www.microlins.com.br/galeria/repositorio/images/noticias/como-posicionar-melhor-seu-perfil-no-linkedin/03-Como-posicionar-melhor-seu-perfil-do-Linkedin.png", Nome = "Rafael", Cargo = "Sou" });
            Lista.Add(new Funcionario() { Foto = "https://www.microlins.com.br/galeria/repositorio/images/noticias/como-posicionar-melhor-seu-perfil-no-linkedin/07-Como-posicionar-melhor-seu-perfil-do-Linkedin.png", Nome = "Gabriel", Cargo = "Patrão" });
            Lista.Add(new Funcionario() { Foto = "https://www.microlins.com.br/galeria/repositorio/images/noticias/como-posicionar-melhor-seu-perfil-no-linkedin/01-Como-posicionar-melhor-seu-perfil-do-Linkedin.png", Nome = "Jose", Cargo = "Não" });
            Lista.Add(new Funcionario() { Foto = "https://www.microlins.com.br/galeria/repositorio/images/noticias/como-posicionar-melhor-seu-perfil-no-linkedin/04-Como-posicionar-melhor-seu-perfil-do-Linkedin.png", Nome = "Guilherme", Cargo = "Funcionario" });

            ListaFuncionario.ItemsSource = Lista;
        }
	}
}