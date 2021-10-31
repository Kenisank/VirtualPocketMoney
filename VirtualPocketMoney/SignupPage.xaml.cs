using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using VirtualPocketMoney.Services;
using VirtualPocketMoney.Tables;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VirtualPocketMoney
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SignUp : ContentPage
    {
        ApiServices apiServices = new ApiServices();
        RegModel model = new RegModel();
        public string Message { get; set; }

        public SignUp()
        {
            InitializeComponent();
        }


        private void Button_Clicked(object sender, EventArgs e)
        {
            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "VPM DataBase.db");
            var db = new SQLiteConnection(dbPath);
            db.CreateTable<RegUserTable>();



            var item = new RegUserTable()
            {
                Name = EntryUserFullName.Text,
                Email = EntryUserEmail.Text,
                PhoneNumber = EntryUserPhoneNumber.Text,

                BVN = EntryUserBVN.Text,
                Gender = EntryUserGender.Text,
                Password = EntryUserPassword.Text,
                ConfirmPassword = EntryUserConfirmPassword.Text,
                Salutation = EntryUserSalutation.Text,
                APPID = EntryUserAPPID.Text,
                Address = EntryUserAddress.Text,
                MaritalStatus = EntryUserAddress.Text
            };
            model = new RegModel
            {
                Address = item.Address,
                APPID = item.APPID,
                BVN = item.BVN,
                ConfirmPassword = item.ConfirmPassword,
                Gender = item.Gender,
                Email = item.Email,
                MaritalStatus = item.MaritalStatus,
                Name = item.Name,
                Password = item.Password,
                PhoneNumber = item.PhoneNumber,
                Salutation = item.Salutation,
                UserId = item.UserId
            };


            

            db.Insert(item);
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await App.Current.MainPage.DisplayAlert("Congratulation", "Registration Successful", "Ok", "Cancel");

            });

        }

        

        public ICommand RegisterCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var isSuccess = await apiServices.RegisterAsync(model);


                    if (isSuccess)
                        Message = "Registered Successfully";
                    else
                    {
                        Message = "Retry Later";
                    }
                
                });

            }
        }

    }
}