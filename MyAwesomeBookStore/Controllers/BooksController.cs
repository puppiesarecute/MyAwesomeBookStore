using MyAwesomeBookStore.Models;
using MyAwesomeBookStore.Models.DataLibrary;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web.Mvc;

namespace MyAwesomeBookStore.Controllers
{
    public class BooksController : AsyncController
    {
        ApplicationDbContext db = new ApplicationDbContext();

        // GET: Books
        public async void TestIndexAsync()
        {
            using (var client = new HttpClient())
            {
                // TODO - Send HttpRequest
                client.BaseAddress = new Uri("https://www.googleapis.com/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //// "https://www.googleapis.com/books/v1/volumes?q=isbn:1783297190"

                string link = "books/v1/volumes?q=isbn:" + "1783297190";

                var response = await client.GetAsync(link);

                Console.WriteLine(response.IsSuccessStatusCode);

                var jsonstring = await response.Content.ReadAsStringAsync();

                var model = JsonConvert.DeserializeObject<RootObject>(jsonstring);

                TestIndexCompleted(model);
            }

        }

        public ActionResult TestIndexCompleted(RootObject obj)
        {
            // do stuff with root object

            return View();
        }
    }
}