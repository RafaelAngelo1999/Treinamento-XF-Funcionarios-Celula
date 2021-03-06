﻿using System;
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
	public partial class TextCellPage : ContentPage
	{
		public TextCellPage ()
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
	}
}