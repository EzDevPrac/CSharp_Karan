namespace EShoppingWebApi.Service.EmployeeService
{
    public interface IEmployeeService
    {
       int Authenticate(string name,string password);  
    }
}