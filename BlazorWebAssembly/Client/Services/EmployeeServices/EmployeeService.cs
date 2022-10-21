using System.Net.Http.Json;

namespace BlazorWebAssembly.Client.Services.EmployeeServices
{
    public class EmployeeService : IEmployeeService
    {
        private readonly HttpClient _http;

        public EmployeeService(HttpClient http)
        {
            _http = http;
        }
        public List<Employees> Employees { get ; set ; }=new List<Employees>();
        public List<Manager> Managers { get; set; } = new List<Manager>();

        

        public Task GetManagers()
        {
            throw new NotImplementedException();
        }

        public Task<Employees> GetSingleEmployee(int id)
        {
            throw new NotImplementedException();
        }
        public async Task GetEmployees()
        {
            var result = await _http.GetFromJsonAsync<List<Employees>>("api/employees");
            if(result != null)
                Employees = result;
        }
    }


}
