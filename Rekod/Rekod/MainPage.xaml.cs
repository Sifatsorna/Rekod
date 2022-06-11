using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Rekod
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public void OnDeckCreate(object sender, EventArgs e)
        {
            deckStack.Children.Add(new Button { Text = "Deck" });
        }
    }
}