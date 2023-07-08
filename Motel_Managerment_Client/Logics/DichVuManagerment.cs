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
    public class DichVuManagerment
    {
        private readonly HttpClient client = null;
        private string DichVuApiUrl = "";


        public DichVuManagerment()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            client.DefaultRequestHeaders.Accept.Clear();
            DichVuApiUrl = "http://localhost:5059/api/DichVus";
        }

        public async Task<List<DichVuDTO>> GetAllDichVus()
        {
            HttpResponseMessage response = await client.GetAsync($"{DichVuApiUrl}/GetAllDichVus");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            List<DichVuDTO> listdichvus = System.Text.Json.JsonSerializer.Deserialize<List<DichVuDTO>>(strdata, options).ToList();
            return listdichvus;
        }
     
        public async Task<DichVuDTO> GetDichVuById(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"{DichVuApiUrl}/GetDichVuById/{id}");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            DichVuDTO dichvu = System.Text.Json.JsonSerializer.Deserialize<DichVuDTO>(strdata, options);
            return dichvu;
        }
        public async Task<string> DeleteDichVuById(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"{DichVuApiUrl}/GetDichVuById/{id}");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            response = await client.DeleteAsync($"{DichVuApiUrl}/DeleteChuNhaById/{id}");
            return "delete suceed";
        }

        public async Task<string> AddDichVuById(Dichvu dichVu)
        {
            var json = JsonConvert.SerializeObject(dichVu);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{DichVuApiUrl}/AddDichVuById", content);
            return "Add suceed";
        }
        public async Task<string> UpdateDichVuById(Dichvu dichVu)
        {
            var json = JsonConvert.SerializeObject(dichVu);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"{DichVuApiUrl}/UpdateDichVuById", content);
            return "Update suceed";
        }
    }
}
