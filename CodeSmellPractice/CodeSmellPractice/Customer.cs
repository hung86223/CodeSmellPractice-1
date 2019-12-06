namespace CodeSmellPractice
{
    public class Customer
    {
        private readonly Address _Address;

        public Customer(Address address)
        {
            _Address = address;
        }


        public string GetMailAddress()
        {
            return $"{_Address.PostalCode}" +
                   $"{_Address.City}" +
                   $"{_Address.Street}" +
                   $"{_Address.Number}號";
        }
    }
}