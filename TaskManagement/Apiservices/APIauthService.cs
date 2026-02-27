using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Net.Http.Json;
using System.Text;
using System.Text.Json;
using TaskManagement.Model;

namespace TaskManagement.Apiservices
{
    public class APIauthService
    {
        private readonly HttpClient _httpClient;
        public APIauthService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://localhost:7016/");
        }
        public async Task<UserData> Login(string username, string password)
        {
            var request = new
            {
                Username = username,
                Password = password
            };
            var response = await _httpClient.PostAsJsonAsync("api/auth/login", request);
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            return await response.Content.ReadFromJsonAsync<UserData>();

        }
        public async Task<bool> usernameExist(string username)
        {
            var response = await _httpClient.GetAsync($"api/auth/usernameexist/{username}");
            return response.IsSuccessStatusCode;
        }

        public async Task<bool> Adduser(string username, string password, string role)
        {
            var request = new
            {
                Username = username,
                Password = password,
                Role = role
            };
            var response = await _httpClient.PostAsJsonAsync($"api/auth/adduser", request);
            return response.IsSuccessStatusCode;
        }
        public async Task<bool> changePassword(string username_added, string updated_password)
        {
            var request = new
            {
                Username = username_added,
                Password = updated_password
            };
            var response = await _httpClient.PostAsJsonAsync($"api/auth/changepassword", request);
            return response.IsSuccessStatusCode;
        }

        public async Task<string> getrole(int user_id)
        {
            var response = await _httpClient.GetAsync($"api/auth/getrole/{user_id}");
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            return await response.Content.ReadAsStringAsync();
        }

        public async Task<string> getname(int user_id)
        {
            var response = await _httpClient.GetAsync($"api/auth/getname/{user_id}");
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }
            return await response.Content.ReadAsStringAsync();
        }
        //public async Task<List<UserData>> getallUser(string role)
        //   {
        //       var response = await _httpClient.GetAsync($"api/auth/getAlluser/{role}");
        //       if (!response.IsSuccessStatusCode)
        //       {
        //           return null;
        //       }
        //       var json = await response.Content.ReadAsStringAsync();
        //       return JsonSerializer
        //         .Deserialize<List<UserData>>(json);
        //   }
        public async Task<List<UserData>> getallUser(string role)
        {
            var response = await _httpClient.GetAsync($"api/auth/getAlluser/{role}");
            if (!response.IsSuccessStatusCode)
            {
                return null;
            }

            return await response.Content.ReadFromJsonAsync<List<UserData>>();
        }
    }
}
