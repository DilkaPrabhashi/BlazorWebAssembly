namespace BlazorWebAssembly.Client.Services.EmployeeServices
{
    public interface IEmployeeService
    {
        List<Employees> Employees { get; set; }
        List<Manager> Managers { get; set; }
        Task GetManagers();

        Task GetEmployees();

        Task<Employees> GetSingleEmployee(int id);
        

        
    }
}
