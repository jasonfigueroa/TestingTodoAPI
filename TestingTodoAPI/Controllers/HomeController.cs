using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using TestingTodoAPI.Models;

namespace TestingTodoAPI.Controllers
{
    public class HomeController : Controller
    {
        private static readonly HttpClient client = new HttpClient();
        private static List<Category> _categories = new List<Category>();

        public HomeController()
        {
            //string name = "Jason";
            //string password = "Jason";
            //RunAsync(name, password).GetAwaiter().GetResult();
        }

        static async System.Threading.Tasks.Task RunAsync(UserAuth userAuth)
        {
            string url = "http://localhost:5000/auth";

            //HttpContent httpContent;
            string serializedJson = JsonConvert.SerializeObject(userAuth);
            var stringContent = new StringContent(serializedJson, Encoding.UTF8, "application/json");
            //client.DefaultRequestHeaders.
            var responseString = await client.PostAsync(url, stringContent);
            var contents = await responseString.Content.ReadAsStringAsync();
            JWT jwt = JsonConvert.DeserializeObject<JWT>(contents);

            string newUrl = "http://localhost:5000/categories";
            client.DefaultRequestHeaders.Add("Authorization", $"JWT {jwt.access_token}");
            var newResponseString = await client.GetStringAsync(newUrl);
            JObject json = JObject.Parse(newResponseString);            
            JToken categoriesToken = json.GetValue("categories");
            foreach (var item in categoriesToken)
            {
                // user is null for now
                Category category = item.ToObject<Category>();
                _categories.Add(category);
            }
           
            int x = 1;
        }

        public IActionResult Index()
        {
            string name = "jane";
            string password = "jane";
            UserAuth userAuth = new UserAuth(name, password);

            RunAsync(userAuth).GetAwaiter().GetResult();
            return View();
        }
    }
}