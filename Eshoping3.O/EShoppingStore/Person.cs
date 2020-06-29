namespace EShoppingStore
{
    public  class Person
    { 
        private string Name;
        private string PhoneNumber;
        private string Address;
        private string Email;

        public string _Name { get => Name; set => Name = value; }
        public string _PhoneNumber { get => PhoneNumber; set => PhoneNumber = value; }
        public string _Address { get => Address; set => Address = value; }
        public string _Email { get => Email; set => Email = value; }
    }
}