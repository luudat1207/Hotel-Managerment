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
using Newtonsoft.Json;

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
            List<User> listusers = System.Text.Json.JsonSerializer.Deserialize<List<User>>(strdata, options).ToList();
            return listusers;
        }

        public async Task<User> UpdateUserByUserName(User user)
        {
            var json = JsonConvert.SerializeObject(user);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PutAsync($"{UserApiUrl}?username={user.Username}", content);

            return user;
        }
        public async Task<User> CreateUser(User user)
        {
            var json = JsonConvert.SerializeObject(user);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            HttpResponseMessage response = await client.PostAsync(UserApiUrl, content);

            return user;
        }
    }
}
