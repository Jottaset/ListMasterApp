using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ListMasterApp
{
    public partial class PageMinhaLista : ContentPage
    {
        List<String> lista_conteudo = new List<string>(new string[] {

            "Item 01",
            "Item 02",
            "Item 03"
        });

        public PageMinhaLista()
        {
            InitializeComponent();
            minhaLista.ItemsSource = lista_conteudo;
        }
    }
}
