using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VirtualPocketMoney.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Signup : ContentView
    {
        public Signup()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var dBassPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "UserDataBase.db");
            var dB = new SQLiteConnection(dBassPath);
            dB.CreateTable

        } 
    }
}