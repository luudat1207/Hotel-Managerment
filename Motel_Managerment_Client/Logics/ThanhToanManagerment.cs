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
    public class ThanhToanManagerment
    {
        private readonly HttpClient client = null;
        private string ThanhToanApiUrl = "";


        public ThanhToanManagerment()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            client.DefaultRequestHeaders.Accept.Clear();
            ThanhToanApiUrl = "http://localhost:5059/api/ThanhToans";
        }

        public async Task<List<ThanhToanDTO>> GetAllThanhToans()
        {
            HttpResponseMessage response = await client.GetAsync($"{ThanhToanApiUrl}/GetAllThanhToans");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            List<ThanhToanDTO> listthanhtoans = System.Text.Json.JsonSerializer.Deserialize<List<ThanhToanDTO>>(strdata, options).ToList();
            return listthanhtoans;
        }

        public async Task<ThanhToanDTO> GetThanhToanById(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"{ThanhToanApiUrl}/GetThanhToanById/{id}");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            ThanhToanDTO thanhtoan = System.Text.Json.JsonSerializer.Deserialize<ThanhToanDTO>(strdata, options);
            return thanhtoan;
        }
        public async Task<string> DeleteThanhToanById(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"{ThanhToanApiUrl}/GetThanhToanById/{id}");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            response = await client.DeleteAsync($"{ThanhToanApiUrl}/DeleteThanhToanById/{id}");
            return "delete suceed";
        }

        public async Task<string> AddThanhToanById(Thanhtoan thanhtoan)
        {
            var json = JsonConvert.SerializeObject(thanhtoan);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{ThanhToanApiUrl}/AddThanhToanById", content);
            return "Add suceed";
        }
        public async Task<string> UpdateThanhToanById(Thanhtoan thanhtoan)
        {
            var json = JsonConvert.SerializeObject(thanhtoan);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"{ThanhToanApiUrl}/UpdateThanhToanById", content);
            return "Update suceed";
        }
    }
}
