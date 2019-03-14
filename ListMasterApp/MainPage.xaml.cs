using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ListMasterApp
{
    public partial class MainPage : ContentPage
    {
        List<string> lista_de_valor = new List<string>();

        int cont = 0;
        void AddItem(object sender, System.EventArgs e)
        {
            lista_de_valor.Add("Meu Item Add" + cont);
            cont ++;

        }

        void Checando(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new PageMinhaLista(lista_de_valor));
        }


        public MainPage()
        {
            InitializeComponent();
        }
    }
}
