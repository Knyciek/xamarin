using System;
using System.Collections.Generic;
using SQLite;
using travelapp.Model;
using Xamarin.Forms;

namespace travelapp
{
    public partial class PostDetailPage : ContentPage
    {
        Post selectedPost;

        public PostDetailPage(Post selectedPost)
        {
            InitializeComponent();
            this.selectedPost = selectedPost;
            experienceEntry.Text = selectedPost.Experience;
        }

        void updateButton_Clicked(object sender, System.EventArgs e)
        {
            selectedPost.Experience = experienceEntry.Text;
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Post>();
                int rows = conn.Update(selectedPost);

                if (rows > 0)
                    DisplayAlert("Success", "Brawo, zaktualizowales stringa ziomek!", "Nareczka");
                else
                    DisplayAlert("Poracha", "NIe udalo sie zaktualizowac stringa", "nara");
            }
        }

        void deleteButton_Clicked(object sender, System.EventArgs e)
        {
            using (SQLiteConnection conn = new SQLiteConnection(App.DatabaseLocation))
            {
                conn.CreateTable<Post>();
                int rows = conn.Delete(selectedPost);

                if (rows > 0)
                    DisplayAlert("Success", "Brawo, skasowales stringa ziomek!", "Nareczka");
                else
                    DisplayAlert("Poracha", "NIe udalo sie skasowac stringa", "nara");
            }
        }
    }
}
