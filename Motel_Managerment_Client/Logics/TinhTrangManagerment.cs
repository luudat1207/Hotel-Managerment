using Motel_Managerment_API.DTO;
using Motel_Managerment_API.Models;
using Newtonsoft.Json;
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

        public async Task<TinhTrangDTO> GetTinhTrangById(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"{TinhTrangApiUrl}/GetTinhTrangById/{id}");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            TinhTrangDTO tinhtrang = System.Text.Json.JsonSerializer.Deserialize<TinhTrangDTO>(strdata, options);
            return tinhtrang;
        } 

        public async Task<string> DeletePhongTroById(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"{TinhTrangApiUrl}/GetTinhTrangById/{id}");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            response = await client.DeleteAsync($"{TinhTrangApiUrl}/DeleteTinhTrangById/{id}");
            return "delete suceed";
        }

        public async Task<string> AddPhongTro(Tinhtrang tinhtrang)
        {
            var json = JsonConvert.SerializeObject(tinhtrang);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{TinhTrangApiUrl}/AddTinhTrangById", content);
            return "Add suceed";
        }
        public async Task<string> UpdatePhongTro(Tinhtrang tinhtrang)
        {
            var json = JsonConvert.SerializeObject(tinhtrang);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"{TinhTrangApiUrl}/UpdateTinhTrangById", content);
            return "Update suceed";
        }
    }
}
