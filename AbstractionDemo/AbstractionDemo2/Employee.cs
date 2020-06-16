namespace AbstractionDemo2
{
    public abstract class Employee
    {
        public string EmployeeName{get;set;}
        public int EmployeeId{get;set;}

        public string DisplayName(){
           
            return this.EmployeeName;

        }
        public abstract void GetTheMonthlySalary();

    }
}