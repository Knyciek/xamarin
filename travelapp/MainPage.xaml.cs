using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace travelapp
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void LoginButton_Clicked(object sender, System.EventArgs e)
        {
            bool IsEmailEmpty = string.IsNullOrEmpty(emailEntry.Text);
            bool IsPasswordEmpty = string.IsNullOrEmpty(passwordEntry.Text);

            if(IsEmailEmpty || IsPasswordEmpty)
            {

            }
            else
            {
                Navigation.PushAsync(new HomePage());
            }
        }
    }
}
