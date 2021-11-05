using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using VirtualPocketMoney.Services;
using VirtualPocketMoney.Views;
using Xamarin.Forms;

namespace VirtualPocketMoney.ViewModels
{
    public class RegViewModel:ContentPage
    {
        private ApiServices _apiservices = new ApiServices();
        //public RegViewModel(ApiServices apiServices)
        //{
        //    _apiservices = apiServices;
        //}



        
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Salutation { get; set; }
        public string Gender { get; set; }
        public string MaritalStatus { get; set; }
        public string APPID { get; set; }
        public string BVN { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }

        public string Message { get; set; }

        public ICommand BackToPage { get; private set; }

        public ICommand RegisterCommand
        {

            get
            {
                return new Command(async () =>
                {
                    var isSuccess = await _apiservices.RegisterAsync(Name,
              Email,
          PhoneNumber,
          Address,
          Salutation,
          Gender,
          MaritalStatus,
          APPID,
          BVN,
          Password,
          ConfirmPassword);


                    if (isSuccess)
                    {
                        Message = "Registered Successfully";
                        await Navigation.PushAsync(new LoginPage());
                    } 
                    else
                    {
                        Message = "Retry Later";
                    }

                });

            }
        }


        
    }
}
