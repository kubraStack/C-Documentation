namespace ReferenceTypes;

public class Program
{
    static void Main(string[] args)
    {
        //int,decimal,float,enum,boolenan (Sayısal tipler değer tiplerdir Value Types)(Stack alanında değer tipler oluşur.)
        //int sayi1 = 10;
        //int sayi2 = 20;

        //sayi1 = sayi2;

        //sayi2 = 100;

        //Console.WriteLine("Sayı 1: " + sayi1);

        //Array,Class,Interface...reference type'dır.(Heap alanına kaydedilir.)
        //int[] sayilar = new int[] { 1,2,3};
        //int[] sayilar2 = new int[] { 5, 6, 7 };

        //sayilar = sayilar2;
        //sayilar2[0] = 1000;

        //Console.WriteLine(sayilar2[0]);

        Person person1 = new Person();
        Person person2 = new Person();
        person1.FirstName = "Engin";

        person2 = person1;
        person1.FirstName = "Derin";
       // Console.WriteLine(person2.FirstName);


        Customer customer = new Customer();
        customer.FirstName = "Salih";
        customer.CreditCardNumber = "123456789";

        Employee employee = new Employee();
        employee.FirstName = "Veli";

        //Kalıtım yaptığımızda kalıtımı alan sınıfı atama yapabiliriz.
        Person person3 = customer;
        customer.FirstName = "Ahmet";
       

        //Base sınıftan kalıtım yaptığımız için kalıtım sağlanan özelliklere ulaşalabilir.
        //Ancak boxing yaparsak ulaşılabilir diğerlerine de ulaşılabilir.Neye boxing yaptığımızı belirterek kullanılır.
        //Console.WriteLine(((Customer)person3).CreditCardNumber);

        PersonManager personManager = new PersonManager();
        personManager.Add(employee);


    }
    //Inheritance(Kalıtım/Miras)
   

    //Base class => Person
    class Person
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }

    class Customer : Person
    {
        public string CreditCardNumber {  get; set; }
    }

    class Employee : Person
    {
        public int EmployeeNumber { get; set; }
    }

    class PersonManager
    {
        //Eğer metota direk base sınıfı parametre olarak verirsek base'den kalıtım alan sınıfları da kullanabiliriz
       public void Add(Person person)
        {
            Console.WriteLine(person.FirstName);
        }
    }
}
