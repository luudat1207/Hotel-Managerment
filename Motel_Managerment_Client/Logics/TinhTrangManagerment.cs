using Motel_Managerment_API.DTO;
using Motel_Managerment_API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Motel_Managerment_Client.Logics
{
    public class TinhTrangManagerment
    {
        private readonly HttpClient client = null;
        private string TinhTrangApiUrl = "";


        public TinhTrangManagerment()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            client.DefaultRequestHeaders.Accept.Clear();
            TinhTrangApiUrl = "http://localhost:5059/api/TinhTrangs";
        }

        public async Task<List<Tinhtrang>> GetAllTinhtrang()
        {
            HttpResponseMessage response = await client.GetAsync($"{TinhTrangApiUrl}/GetAllTinhTrang");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            List<Tinhtrang> tinhtrangs = System.Text.Json.JsonSerializer.Deserialize<List<Tinhtrang>>(strdata, options).ToList();
            return tinhtrangs;
        }
    }
}
