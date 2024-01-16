using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Trigger
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        public class ChangeColor : TriggerAction<Button>
        {
            protected override void Invoke(Button btn)
            {
                btn.BackgroundColor = Color.DarkOrange;
                btn.Text = "Here we go!!!";
            }
        }
    }
}

