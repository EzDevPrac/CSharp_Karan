namespace After
{
    public class Implementation
    {
        public bool AddEmployee(string Name,int Id)
        {   
            
            if(VerifyEmployeeId(10) && VerifyEmployeeName("Karan"))
            {
             //Logic to Add employees
             return true;  
            }
            else
            return false;
        }

        private bool VerifyEmployeeName(string Name)
        {
            //Logic to Verify Name
            return true;
        }

        private bool VerifyEmployeeId(int Id)
        {
            //Logic to Id
            return true;
        }
    }
}