namespace Constructor
{
    public class Constructor
    {
        static void Main(string[] args)
        {
            //Constructor => Bir class'ı newlediğimiz zaman çalışan bloktur.Bir class ilk kez oluşturulduğu zaman bir kere çalışır birdaha çalışmaz dediğimiz yapıcı bloktur.

            Customer customer1 = new Customer {Id=1,FirstName="Lale",LastName="Tanınmış",City="Ankara" };

            Customer customer3 = new Customer();
            customer3.Id = 2;

            Customer customer2 = new Customer(2,"Derin","Demiroğ","Ankara");

           
        }
    }

    class Customer
    {
        //Class oluşturulurken Default constructor çalışır yada oluşturulan constructor çalışır
        //Kolay kullanım amaçlı kullanılabilir
        public Customer()
        {
            Console.WriteLine("Yapıcı block çalıştı");
        }


        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        //constructor'ın parametreli hali
        public Customer(int ıd, string firstName, string lastName, string city)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
    }   
}

