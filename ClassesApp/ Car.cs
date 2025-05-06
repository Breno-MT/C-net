namespace ClassesApp
{
    // It's internal, which means that
    //it can only be accessed from
    //within the same assembly(others programs can't acess this class)
    internal class Car
    {
        // member variable
        // private hides the variable from other classes
        // private string _model = "";
        private string _brand = "";
        // private bool _isLuxury;

        // Property to access private variables
        public string Model { get; set; }
        public string Brand {
            get {
                if (IsLuxury) {
                    return _brand + " - Luxury Edition";
                }
                else {
                    return _brand;
                }
            }

            set {
                if (string.IsNullOrEmpty(value)) {
                    Console.WriteLine("Write something to it!");
                    _brand = "Default Value";
                }
                else {
                    _brand = value;
                }
            }
        }

        public bool IsLuxury { get; set; }

        // Constructor
        public Car(string model, string brand, bool isLuxury) {
            Model = model;
            Brand = brand;
            Console.WriteLine("A {0} of the model {1} has been created.", Brand, Model);
            IsLuxury = isLuxury;
        }
    }
}