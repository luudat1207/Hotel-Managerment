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
    public class HoaDonManagerment
    {
        private readonly HttpClient client = null;
        private string HoaDonApiUrl = "";


        public HoaDonManagerment()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            client.DefaultRequestHeaders.Accept.Clear();
            HoaDonApiUrl = "http://localhost:5059/api/HoaDons";
        }

        public async Task<List<HoaDonDTO>> GetAllHoaDonByHopDong(string sohd)
        {
            HttpResponseMessage response = await client.GetAsync($"{HoaDonApiUrl}/GetAllHoaDonByHopDong/{sohd}");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            List<HoaDonDTO> listhoadons = System.Text.Json.JsonSerializer.Deserialize<List<HoaDonDTO>>(strdata, options).ToList();
            return listhoadons;
        }

        public async Task<DichVuDTO> GetAllDichVuConlai(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"{HoaDonApiUrl}/GetAllDichVuConlai/{id}");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            DichVuDTO dichvu = System.Text.Json.JsonSerializer.Deserialize<DichVuDTO>(strdata, options);
            return dichvu;
        }

        public async Task<string> DeleteHoaDonById(int id)
        {
            HttpResponseMessage response = await client.DeleteAsync($"{HoaDonApiUrl}/DeleteHoaDonById/{id}");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            return "delete suceed";
        }

        public async Task<string> AddHoaDon(Hoadon hoadon)
        {
            var json = JsonConvert.SerializeObject(hoadon);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{HoaDonApiUrl}/AddHoaDon", content);
            return "Add suceed";
        }
        public async Task<string> UpdateHoaDon(Hoadon hoadon)
        {
            var json = JsonConvert.SerializeObject(hoadon);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"{HoaDonApiUrl}/UpdateHoaDon", content);
            return "Update suceed";
        }
    }
}
