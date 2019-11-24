using System;
using System.Collections.Generic;
using travelapp.Model;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;


namespace travelapp
{
    public partial class NewTravelPage : ContentPage
    {
        public NewTravelPage()
        {
            InitializeComponent();
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
            Post post = new Post()
            {
                Experience = experienceEntry.Text
            };

            SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation);
            conn.CreateTable<Post>();
            int rows = conn.Insert(post);
            conn.Close();
            if (rows > 0)
                DisplayAlert("Success", "Brawo, dodales stringa ziomek!", "Nareczka");
            else
                DisplayAlert("Poracha", "NIe udalo sie dodac stringa", "nara");

        }
    }
}
