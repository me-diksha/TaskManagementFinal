using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json;
using TaskManagement.Model;
using System.Net.Http.Json;
namespace TaskManagement.Apiservices
{
    public class APITaskService
    {
       
       private readonly HttpClient _httpClient;
       public APITaskService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://localhost:7016/");
        }

        public async Task<List<TaskList>>GetTask(int userid)
        {
            var response = await _httpClient.GetAsync($"api/task/user/{userid}");
            if (!response.IsSuccessStatusCode)
            {
                return new List<TaskList>();
            }

            var json= await response.Content.ReadAsStringAsync();
            return await response.Content.ReadFromJsonAsync<List<TaskList>>();
        }
        public async Task<TaskList>Addtask(TaskList task)
        {
            var response = await _httpClient.PostAsJsonAsync($"api/task", task);
            //return response.IsSuccessStatusCode;
            if (!response.IsSuccessStatusCode)
                return null;

            return await response.Content.ReadFromJsonAsync<TaskList>();
        }
        public async Task<bool> Updatetask(TaskList task)
        {
            var response = await _httpClient.PutAsJsonAsync($"api/task/{task.taskId}", task);
            return response.IsSuccessStatusCode;

        }
        public async Task<bool> Deletetask(TaskList task)
        {
            var response = await _httpClient.DeleteAsync($"api/task/{task.taskId}/{task.UserId}");
            return response.IsSuccessStatusCode;

        }
        public async Task<List<TaskList>>GetTaskByStatus(int userId, bool status)
        {
            var response = await _httpClient.GetAsync($"api/task/{userId}/{status}");
            if (!response.IsSuccessStatusCode)
            {
                return new List<TaskList>();
            }

            var json = await response.Content.ReadAsStringAsync();
            return await response.Content.ReadFromJsonAsync<List<TaskList>>();
        }
    }
}
