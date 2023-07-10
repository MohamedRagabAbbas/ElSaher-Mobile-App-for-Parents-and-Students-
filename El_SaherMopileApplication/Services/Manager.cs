using El_SaherMopileApplication.Models;
using Newtonsoft.Json;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace El_SaherMopileApplication.Services
{
	public class Manager:IManager

	{
        public  Student student { get; set; } 

        private readonly HttpClient httpClient;
		public Manager(HttpClient _httpClient)
		{
			httpClient = _httpClient;
		}
		public async Task<List<Student>> GetStudents()
		{
            HttpClient client = new HttpClient();
            string URL = "http://elsaher-001-site1.itempurl.com/api/Student/GetAllStudents";
            client.BaseAddress = new Uri(URL);
            HttpResponseMessage httpResponseMessage = await client.GetAsync("");
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                string respons = httpResponseMessage.Content.ReadAsStringAsync().Result;
                List<Student> AllData = JsonConvert.DeserializeObject<List<Student>>(respons);
                return AllData;
            }
            return new List<Student>();
        }
        public async Task<Student> GetStudentById(int id)
		{
            HttpClient client = new HttpClient();
            string URL = ("http://elsaher-001-site1.itempurl.com/api/Student/GetStudent/"+id);
            client.BaseAddress = new Uri(URL);
            HttpResponseMessage httpResponseMessage = await client.GetAsync("");
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                string respons = httpResponseMessage.Content.ReadAsStringAsync().Result;
                Student student = JsonConvert.DeserializeObject<Student>(respons);
                return student;
            }
            return new Student();
        }

        public async Task<List<Student>> GetExcellentStudents(int CourseId)
        {
            HttpClient client = new HttpClient();
            string URL = ("http://elsaher-001-site1.itempurl.com/api/Student/GetExcellentStudents/" + CourseId);
            client.BaseAddress = new Uri(URL);
            HttpResponseMessage httpResponseMessage = await client.GetAsync("");
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                string respons = httpResponseMessage.Content.ReadAsStringAsync().Result;
                List<Student> students = JsonConvert.DeserializeObject<List<Student>>(respons);
                return students;
            }
            return new List<Student>();
        }
        public async Task<ServiceResponse<Student>> GetStudentByNameAndPhoneNumber(string Name, string PhoneNumber)
        {
            HttpClient client = new HttpClient();
            string URL = ("http://elsaher-001-site1.itempurl.com/api/Student/LoginMobileApp/" + Name+"/"+ PhoneNumber);
            client.BaseAddress = new Uri(URL);
            HttpResponseMessage httpResponseMessage = await client.GetAsync("");
            if (httpResponseMessage.IsSuccessStatusCode)
            {
                string respons = httpResponseMessage.Content.ReadAsStringAsync().Result;
                ServiceResponse<Student> studentResponse = JsonConvert.DeserializeObject<ServiceResponse<Student>>(respons);
                student = studentResponse.Data;
                return studentResponse;
            }
            return new ServiceResponse<Student>();
        }

		public async Task<bool> ISValid(string UserName, string PhoneNumber)
        {
			HttpClient client = new HttpClient();
			string URL = ("http://elsaher-001-site1.itempurl.com/api/Student/ISValid/" + UserName + "/" + PhoneNumber);
			client.BaseAddress = new Uri(URL);
			HttpResponseMessage httpResponseMessage = await client.GetAsync("");
			if (httpResponseMessage.IsSuccessStatusCode)
			{
				string respons = httpResponseMessage.Content.ReadAsStringAsync().Result;
				bool valid = JsonConvert.DeserializeObject<bool>(respons);
				return valid;
			}
			return new bool();
		}



	}
}
