using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPocketMoney.Services
{
    public class ApiServices
    {
        public async Task<bool> RegisterAsync(RegModel model)
        {
            var client = new HttpClient();


            var json = JsonConvert.SerializeObject(model);
            HttpContent content = new StringContent(json);

            var response = await client.PostAsync("https://www.fsi.ng/api/heritagebank/accounts/AccountOpening/WithBVN", content);

            return response.IsSuccessStatusCode;
        }
    }
}
