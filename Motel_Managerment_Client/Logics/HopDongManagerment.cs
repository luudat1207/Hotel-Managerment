using Motel_Managerment_API.DTO;
using Motel_Managerment_API.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Motel_Managerment_Client.Logics
{
    public class HopDongManagerment
    {
        private readonly HttpClient client = null;
        private string HopDongApiUrl = "";


        public HopDongManagerment()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            client.DefaultRequestHeaders.Accept.Clear();
            HopDongApiUrl = "http://localhost:5059/api/HopDongs";
        }

        public async Task<List<HopDongDTO>> GetAllHopDongByHopDongKetThuc(bool checkBoxHopDongKetThuc)
        {
            HttpResponseMessage response = await client.GetAsync($"{HopDongApiUrl}/GetAllHopDongByHopDongKetThuc/{checkBoxHopDongKetThuc}");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            List<HopDongDTO> listhopdongs = System.Text.Json.JsonSerializer.Deserialize<List<HopDongDTO>>(strdata, options).ToList();
            return listhopdongs;
        }
      

        public async Task<List<HopDongDTO>> GetAllHopDongByInfor(bool checkBoxHopDongKetThuc, string infor)
        {
            HttpResponseMessage response = await client.GetAsync($"{HopDongApiUrl}/GetAllHopDongByInfor/{checkBoxHopDongKetThuc}/{infor}");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            List<HopDongDTO> listhopdongs = System.Text.Json.JsonSerializer.Deserialize<List<HopDongDTO>>(strdata, options).ToList();
            return listhopdongs;
        }
        public async Task<List<ChuNhaxHopDongDTO>> GetChuNhaByHoTen( string hoten)
        {
            HttpResponseMessage response = await client.GetAsync($"{HopDongApiUrl}/GetChuNhaByHoTen/{hoten}");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            List<ChuNhaxHopDongDTO> listchunhas = System.Text.Json.JsonSerializer.Deserialize<List<ChuNhaxHopDongDTO>>(strdata, options).ToList();
            return listchunhas;
        } 
        public async Task<List<KhachThuexHopDongDTO>> GetKhachThueByHoTen( string hoten)
        {
            HttpResponseMessage response = await client.GetAsync($"{HopDongApiUrl}/GetKhachThueByHoTen/{hoten}");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            List<KhachThuexHopDongDTO> listkhachthues = System.Text.Json.JsonSerializer.Deserialize<List<KhachThuexHopDongDTO>>(strdata, options).ToList();
            return listkhachthues;
        }
        public async Task<List<PhongTroxHopDongDTO>> GetPhongTroByMaPhong( string maphong)
        {
            HttpResponseMessage response = await client.GetAsync($"{HopDongApiUrl}/GetPhongTroByMaPhong/{maphong}");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            List<PhongTroxHopDongDTO> listphongtros = System.Text.Json.JsonSerializer.Deserialize<List<PhongTroxHopDongDTO>>(strdata, options).ToList();
            return listphongtros;
        }

        public async Task<List<ChuNhaxHopDongDTO>> GetChuNha()
        {
            HttpResponseMessage response = await client.GetAsync($"{HopDongApiUrl}/GetChuNha");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            List<ChuNhaxHopDongDTO> listchunhas = System.Text.Json.JsonSerializer.Deserialize<List<ChuNhaxHopDongDTO>>(strdata, options).ToList();
            return listchunhas;
        }
        public async Task<List<KhachThuexHopDongDTO>> GetKhachThue()
        {
            HttpResponseMessage response = await client.GetAsync($"{HopDongApiUrl}/GetKhachThue");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            List<KhachThuexHopDongDTO> listkhachthues = System.Text.Json.JsonSerializer.Deserialize<List<KhachThuexHopDongDTO>>(strdata, options).ToList();
            return listkhachthues;
        }
        public async Task<List<PhongTroxHopDongDTO>> GetPhongTro()
        {
            HttpResponseMessage response = await client.GetAsync($"{HopDongApiUrl}/GetPhongTro");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            List<PhongTroxHopDongDTO> listphongtros = System.Text.Json.JsonSerializer.Deserialize<List<PhongTroxHopDongDTO>>(strdata, options).ToList();
            return listphongtros;
        }

        public async Task<string> DeleteHopDongById(string id)
        {
            HttpResponseMessage response =  await client.DeleteAsync($"{HopDongApiUrl}/DeleteHopDongById/{id}");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            return "delete suceed";
        }

        public async Task<string> AddHopDong(Hopdong hopdong)
        {
            var json = JsonConvert.SerializeObject(hopdong);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{HopDongApiUrl}/AddHopDong", content);
            return "Add suceed";
        }
        public async Task<string> UpdateHopDongById(Hopdong hopdong)
        {
            var json = JsonConvert.SerializeObject(hopdong);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"{HopDongApiUrl}/UpdateHopDongById", content);
            return "Update suceed";
        }
        public async Task<string> KetThucHopDongById( string id)
        {
            HttpResponseMessage response = await client.GetAsync($"{HopDongApiUrl}/KetThucHopDongById/{id}");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            return "ketthuc suceed";
        }

    }
}
