using Motel_Managerment_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net;

namespace Motel_Managerment_Client.Logics
{

    public class UserManagerment
    {
        private readonly HttpClient client = null;
        private string UserApiUrl = "";


        public UserManagerment()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            client.DefaultRequestHeaders.Accept.Clear();
            UserApiUrl = "http://localhost:5059/api/Users";
        }

        public async Task<List<User>> GetAllUser()
        {
            //httpresponsemessage response = await client.getasync($"{userapiurl}/getallusers");
            HttpResponseMessage response = await client.GetAsync("http://localhost:5059/api/Users/GetAllUsers");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            List<User> listusers = JsonSerializer.Deserialize<List<User>>(strdata, options).ToList();
            return listusers;
        }

    }
}
