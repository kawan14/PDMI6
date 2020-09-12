using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TP01
{
    public partial class MainPage : ContentPage
    {
        public string id;
        public string pass;

        public MainPage()
        {
            InitializeComponent();

        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            if (id == "admin" && pass == "@dmin")
            {
                await DisplayAlert("Alert", "Logado com sucesso!", "OK");
            }
            else
            {
                await DisplayAlert("Alert", "Login não autorizado!", "OK");
            }
        }

        private void Button_Clean(object sender, EventArgs e)
        {
            idEntry.Text = string.Empty;
            passEntry.Text = string.Empty;
        }

        private async void Button_Credits(object sender, EventArgs e)
        {
            await DisplayAlert("Créditos", "Kawan Carvalho & Giovanna Bomfim.", "OK");
        }

        void changeId(object sender, TextChangedEventArgs e)
        {
            id = e.NewTextValue;
        }

        void changePass(object sender, TextChangedEventArgs e)
        {
            pass = e.NewTextValue;
        }



    }
}
