//using Newtonsoft.Json;
//using RestSharp;
//using SQLite;
//using System;
//using System.Collections.Generic;
//using System.IO;
//using System.Net;
//using System.Net.Http;
//using System.Net.Http.Headers;
//using System.Text;
//using System.Threading.Tasks;
//using VirtualPocketMoney.Models;
//using Xamarin.Forms;

//namespace VirtualPocketMoney.Services
//{
//    public class ApiServices
//    {
//        public bool RegisterAsync(string Name,
//             string Email,
//         string PhoneNumber,
//         string Address,
//         string Salutation,
//         string Gender,
//         string MaritalStatus,
//         string APPID,
//         string BVN,
//         string Password,
//         string ConfirmPassword)
//        {

//            var model = new RegModel
//            {
//                Address = Address,
//                APPID = APPID,
//                BVN = BVN,
//                ConfirmPassword = ConfirmPassword,
//                Gender = Gender,
//                Email = Email,
//                MaritalStatus = MaritalStatus,
//                Name = Name,
//                Password = Password,
//                PhoneNumber = PhoneNumber,
//                Salutation = Salutation
//            };

            
//            var body = @"{
//" + "\n" +
//            @"	""Email"": ""usert@dummydata.com"",
//" + "\n" +
//            @"	""Salutation"": ""MRS."",
//" + "\n" +
//            @"	""Gender"": ""F"",
//" + "\n" +
//            @"	""Address"" : ""Afagha Nsit"",
//" + "\n" +
//            @"	""MaritalStatus"": ""MRIED"",
//" + "\n" +
//            @"	""APPID"" : ""Dukia Gold"",
//" + "\n" +
//            @"    ""BVN"" : ""22223345665""
//" + "\n" +
//            @"}";
//            request.AddParameter("text/plain", body, ParameterType.RequestBody);
//            IRestResponse response = client.Execute(request);
//            Console.WriteLine(response.Content);



//            //var response = await client.PostAsync("https://www.fsi.ng/api/heritagebank/accounts/AccountOpening/WithBVN", content);
//            // var response = await client.SendAsync(request);


//            if (response.StatusCode == HttpStatusCode.OK)
//            {
//                AddToDataBase(model);
//                return response.IsSuccessful;
//            }
//            // return response.IsSuccessStatusCode;
//            return false;

//        }




        

//    }
//}
