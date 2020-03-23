using CarvedRock.Api.GraphQL.Userservice.Model;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace CarvedRock.Api.Repositories
{
    public class UserserviceRepository
    {
        public static  string url = "https://localhost:44340/api/User";
        public static HttpClient client = new HttpClient();
        public UserserviceRepository()
        {
            client.BaseAddress = new Uri(url);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));
        }

        //public static List<User> GetUsers()
        //{
        //    var userList = new List<User>();
        //    try
        //    {
        //        var data = GetUserAsync(public_url).Result;

        //        foreach (User e in data)
        //        {
        //            userList.Add(e);
        //        }                
        //    }
        //    catch(Exception e)
        //    {
        //    }
        //    return userList;            
        //}

        //static async Task<List<User>> GetUserAsync(string path)
        //{
        //    List<User> users = null;
        //    HttpResponseMessage response = await client.GetAsync(path);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        users = await response.Content.ReadAsAsync<List<User>>();

        //    }
        //    return users; 
        //}

        public static async Task<List<User>> GetUserAsync()
        {
            List<User> users = null;
            HttpResponseMessage response = await client.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                users = await response.Content.ReadAsAsync<List<User>>();

            }
            return users;
        }
    }
}
