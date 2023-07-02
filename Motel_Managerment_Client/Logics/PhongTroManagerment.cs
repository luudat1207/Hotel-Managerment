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
    public class PhongTroManagerment
    {
        private readonly HttpClient client = null;
        private string PhongTroApiUrl = "";

        public PhongTroManagerment()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            client.DefaultRequestHeaders.Accept.Clear();
            PhongTroApiUrl = "http://localhost:5059/api/PhongTros";
        }

        public async Task<List<PhongTroDTO>> GetAllPhongTro()
        {
            HttpResponseMessage response = await client.GetAsync($"{PhongTroApiUrl}/GetAllPhongTro");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            List<PhongTroDTO> listphongtros = System.Text.Json.JsonSerializer.Deserialize<List<PhongTroDTO>>(strdata, options).ToList();
            return listphongtros;
        }
        public async Task<List<PhongTroDTO>> GetAllPhongTroByInfor(string infor)
        {
            HttpResponseMessage response = await client.GetAsync($"{PhongTroApiUrl}/GetAllPhongTroByInfor/{infor}");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            List<PhongTroDTO> listphongtros = System.Text.Json.JsonSerializer.Deserialize<List<PhongTroDTO>>(strdata, options).ToList();
            return listphongtros;
        }

        public async Task<PhongTroDTO> GetPhongTroById(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"{PhongTroApiUrl}/GetAllPhongTroByInfor/{id}");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            PhongTroDTO phongtro = System.Text.Json.JsonSerializer.Deserialize<PhongTroDTO>(strdata, options);
            return phongtro;
        }

        public async Task<string> DeletePhongTroById(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"{PhongTroApiUrl}/GetPhongTroById/{id}");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            response = await client.DeleteAsync($"{PhongTroApiUrl}/DeletePhongTroById/{id}");
            return "delete suceed";
        }

        public async Task<string> AddPhongTro(Phongtro phongtro)
        {
            var json = JsonConvert.SerializeObject(phongtro);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{PhongTroApiUrl}/AddPhongTro", content);
            return "Add suceed";
        }
        public async Task<string> UpdatePhongTro(Phongtro phongtro)
        {
            var json = JsonConvert.SerializeObject(phongtro);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"{PhongTroApiUrl}/UpdatePhongTroById", content);
            return "Update suceed";
        }
    }
}
