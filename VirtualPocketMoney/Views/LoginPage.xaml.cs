using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VirtualPocketMoney.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VirtualPocketMoney.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void Handle_Clicked(object sender, System.EventArgs e)
        {
            await Navigation.PushAsync(new RegPage());
        }

        async void Handle_Clicked1(object sender, System.EventArgs e)
        {
            var dbpath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "VPMDataBase.db");
            var db = new SQLiteConnection(dbpath);
            var _query = db.Table<RegModel>().Where(u => u.Email.Equals(EntryUser.Text) && u.Password.Equals(EntryPassword.Text));


            if (_query != null)
            {
                App.Current.MainPage = new NavigationPage(new IndexPage());
            }
            else 
            {
                Device.BeginInvokeOnMainThread(async () =>
                {
                    var result = await DisplayAlert("Error", "Failed User Name and Password", "Yes", "Cancel");
                   
                 
                });
                await Navigation.PushAsync(new LoginPage());
            }

        }
    }
}