using Motel_Managerment_API.DTO;
using Motel_Managerment_API.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Motel_Managerment_Client.Logics
{
    public class ChuNhaManagerment
    {
        private readonly HttpClient client = null;
        private string ChuNhaApiUrl = "";


        public ChuNhaManagerment()
        {
            client = new HttpClient();
            var contentType = new MediaTypeWithQualityHeaderValue("application/json");
            client.DefaultRequestHeaders.Accept.Add(contentType);
            client.DefaultRequestHeaders.Accept.Clear();
            ChuNhaApiUrl = "http://localhost:5059/api/ChuNhas";
        }

        public async Task<List<ChuNhaDTO>> GetAllChuNha()
        {
            HttpResponseMessage response = await client.GetAsync($"{ChuNhaApiUrl}/GetAllChuNhas");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            List<ChuNhaDTO> listchunhas = System.Text.Json.JsonSerializer.Deserialize<List<ChuNhaDTO>>(strdata, options).ToList();
            return listchunhas;
        }
        //public List<Chunha> GetAllChuNha2()
        //{
        //    string link = $"{ChuNhaApiUrl}/GetAllChuNhas";
        //    HttpWebRequest req = HttpWebRequest.CreateHttp(link);
        //    WebResponse res = req.GetResponse();
        //    DataContractJsonSerializer js = new DataContractJsonSerializer(typeof(Chunha));
        //    object data = js.ReadObject(res.GetResponseStream());
        //    //Chunha[] chunhas = (Chunha[])data;
        //    List<Chunha> chunhas = (List<Chunha>)data;
        //    return chunhas;
        //}

        public async Task<ChuNhaDTO> GetChuNhaById(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"{ChuNhaApiUrl}/GetChuNhaById/{id}");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            ChuNhaDTO chunha = System.Text.Json.JsonSerializer.Deserialize<ChuNhaDTO>(strdata, options);
            return chunha;
        }
        public async Task<string> DeleteChuNhaById(int id)
        {
            HttpResponseMessage response = await client.GetAsync($"{ChuNhaApiUrl}/GetChuNhaById/{id}");
            string strdata = await response.Content.ReadAsStringAsync();
            var options = new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };
            response = await client.DeleteAsync($"{ChuNhaApiUrl}/DeleteChuNhaById/{id}");
            return "delete suceed";
        }

        public async Task<string> AddChuNha(Chunha chuNha)
        {
            var json = JsonConvert.SerializeObject(chuNha);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync($"{ChuNhaApiUrl}/AddChuNhaById", content);
            return "Add suceed";
        }  
        public async Task<string> UpdateChuNha(Chunha chuNha)
        {
            var json = JsonConvert.SerializeObject(chuNha);
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PutAsync($"{ChuNhaApiUrl}/UpdateChuNhaById", content);
            return "Update suceed";
        }
    }
}
