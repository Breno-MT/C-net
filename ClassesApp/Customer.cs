namespace ClassesApp
{
    internal class Customer
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactNumber { get; set; }

        // Default Constructor
        public Customer()
        {
            Name = "Guest";
            Address = "Unknown";
            ContactNumber = "None";
        }

        // Custom Constructor
        public Customer(string name, string address = "N/A", string contactNumber = "N/A")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }

        // Methods
        public void SetDetails(string name, string address, string contactNumber = "N/A")
        {
            Name = name;
            Address = address;
            ContactNumber = contactNumber;
        }
    }
}