using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace RestConsumerTemplate
{
    class Program
    {
        private static string uri = "/*uri*/";

        static void Main(string[] args)
        {
            HttpRequests();
            Console.ReadKey();
        }

        public static async void HttpRequests()
        {
            Console.WriteLine("GET ALL TEMPLATES REQUEST");
            List<ClassTemplate> tList = GetTemplatesRequest().Result;

            foreach (ClassTemplate t in tList)
            {
                Console.WriteLine(t);
            }

            Console.WriteLine("\nGET ONE TEMPLATE REQUEST");
            ClassTemplate oneTemplate = GetOneTemplateRequest(2).Result;
            Console.WriteLine(oneTemplate);
        }

        public static async Task<List<ClassTemplate>> GetTemplatesRequest()
        {
            using (HttpClient client = new HttpClient())
            {
                string content = await client.GetStringAsync(uri);
                List<ClassTemplate> tList = JsonConvert.DeserializeObject<List<ClassTemplate>>(content);
                return tList;
            }
        }

        public static async Task<ClassTemplate> GetOneTemplateRequest(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                string content = await client.GetStringAsync(uri + id);
                ClassTemplate classTemplate = JsonConvert.DeserializeObject<ClassTemplate>(content);
                return classTemplate;
            }
        }
    }
}
