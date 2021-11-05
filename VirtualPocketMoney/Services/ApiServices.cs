using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using VirtualPocketMoney.Models;
using Xamarin.Forms;

namespace VirtualPocketMoney.Services
{
    public class ApiServices
    {
        public async Task<bool> RegisterAsync(string Name,
             string Email,
         string PhoneNumber,
         string Address,
         string Salutation,
         string Gender,
         string MaritalStatus,
         string APPID,
         string BVN,
         string Password,
         string ConfirmPassword)
        {
          
           var _model = new RegModel
            {
                Address = Address,
                APPID = APPID,
                BVN = BVN,
                //ConfirmPassword = ConfirmPassword,
                Gender = Gender,
                Email = Email,
                MaritalStatus = MaritalStatus,
                Name = Name,
                Password = Password,
                PhoneNumber = PhoneNumber,
                Salutation = Salutation
            };



            var client = new RestClient("https://fsi.ng/api/heritagebank/accounts/AccountOpening/WithBVN");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Sandbox-Key", "1akPwqvMdRJulP8eK7ovgvAdFNX4Ja0H1634042332");
            request.AddHeader("Content-Type", "application/json");
           request.AddHeader("Authorization", "{{secret_key}}");

            var json = JsonConvert.SerializeObject(_model);
            HttpContent content = new StringContent(json);

            var body = @"{
" + "\n" +
            @"	""Email"": ""usert@dummydata.com"",
" + "\n" +
            @"	""Salutation"": ""MRS."",
" + "\n" +
            @"	""Gender"": ""F"",
" + "\n" +
            @"	""Address"" : ""Afagha Nsit"",
" + "\n" +
            @"	""MaritalStatus"": ""MRIED"",
" + "\n" +
            @"	""APPID"" : ""Dukia Gold"",
" + "\n" +
            @"    ""BVN"" : ""22223345665""
" + "\n" +
            @"}";
           //va//r __json = JsonConvert.SerializeObject(body);
           JObject __json = JObject.Parse(body);

            request.AddParameter("application/json", __json, ParameterType.RequestBody);
            IRestResponse response =  client.Execute(request);
            //Console.WriteLine(response.Content);


            if (response.StatusCode == HttpStatusCode.OK)
            {
                
                AddToDataBase(_model);
                return response.IsSuccessful;
            }
          
            return (!response.IsSuccessful);
        }
         



       private void AddToDataBase(RegModel model)
        {

            var dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "VPMDataBase.db");
            var db = new SQLiteConnection(dbPath);
            db.CreateTable<RegModel>();


           db.Insert(model);
            Device.BeginInvokeOnMainThread(async () =>
            {
                var result = await App.Current.MainPage.DisplayAlert("Congratulation", "Registration Successful", "Ok", "Cancel");


            });
        }

    }
}
