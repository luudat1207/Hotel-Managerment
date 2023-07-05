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
    public class KhachThueManagerment
    {
        private readonly HttpClient client = null;
        private string KhachThueApiUrl = "";

        public KhachThueManagerment()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            client.DefaultRequestHeaders.Accept.Clear();
            KhachThueApiUrl = "http://localhost:5059/api/KhachThues";
        }

        public async Task<List<KhachThueDTO>> GetAllKhachThue()
        {
            HttpResponseMessage response = await client.GetAsync($"{KhachThueApiUrl}/GetAllKhachThue");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            List<KhachThueDTO> listkhachthues = System.Text.Json.JsonSerializer.Deserialize<List<KhachThueDTO>>(strdata, options).ToList();
            return listkhachthues;
        }
        public async Task<List<KhachThueDTO>> GetAllKhachThueByInfor(string infor)
        {
            HttpResponseMessage response = await client.GetAsync($"{KhachThueApiUrl}/GetAllKhachThueByInfor/{infor}");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            List<KhachThueDTO> listkhachthues = System.Text.Json.JsonSerializer.Deserialize<List<KhachThueDTO>>(strdata, options).ToList();
            return listkhachthues;
        }

        public async Task<KhachThueDTO> GetKhachThueById(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"{KhachThueApiUrl}/GetKhachThueByCCCD/{id}");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            KhachThueDTO khachthue = System.Text.Json.JsonSerializer.Deserialize<KhachThueDTO>(strdata, options);
            return khachthue;
        }

        public async Task<string> DeleteKhachThueById(long id)
        {
            HttpResponseMessage response = await client.GetAsync($"{KhachThueApiUrl}/GetKhachThueByCCCD/{id}");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            response = await client.DeleteAsync($"{KhachThueApiUrl}/DeleteKhachThueById/{id}");
            return "delete suceed";
        }

        public async Task<string> AddKhachThue(Khachthue khachthue)
        {
            var json = JsonConvert.SerializeObject(khachthue);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{KhachThueApiUrl}/AddKhachThue", content);
            return "Add suceed";
        }
        public async Task<string> UpdateKhachThue(Khachthue khachthue)
        {
            var json = JsonConvert.SerializeObject(khachthue);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"{KhachThueApiUrl}/UpdateKhachThueById", content);
            return "Update suceed";
        }
    }
}
