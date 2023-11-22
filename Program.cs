using Wema.BIT.Models;

namespace Wema.BIT.Program
{
    class Program
    {
        public static void Main(String[] args)
         
        {
            List<Payment> payments = new List<Payment>();           
           
            List<User> users = new List<User>()
            {
                
                new User() 
                { 
                    Id = 1, 
                    FirstName = "Ismail", LastName ="Adegbite", Email ="adegbiteismail27@gmail.com" 
                },
                new User() { FirstName = "John", LastName = "Doe", Email = "johndoe@gmail.com", Id = 2},
                new User() {FirstName = "Nurudeen", LastName = "Durowade", Email = "nuru@gmail.com", Id = 3},
                new User() {FirstName = "Mobola", LastName = "Makay", Email = "mobola@gmail.com", Id = 4},
                new User() {FirstName = "Temmy", LastName = "Orekunrin", Email = "temmy@gmail.com", Id = 5},

            };
            foreach (User user in users)
            {
                Random random = new Random();
                for (int i = 0; i < 3; i++)
                {
                    var paymentId = random.Next();
                    Payment payment = user.makePayement(random.Next(5000));
                    payment.Id = paymentId;
                    payment.User = user;
                    user.Payments.Add(payment);
                    payments.Add(payment);
                }
            }
            foreach (Payment payment in payments)
            {
                Console.WriteLine(payment.formatDetails());
            }

            //Triangle Asignment
            Console.WriteLine("\nCalcualte Triangle Area\n");
            Console.WriteLine("Option 1: Using all three sides\nOption 2: Using base and height");
            Console.WriteLine("For option enter 1, for option 2 enter 2 or any key");
            var userInput = Console.ReadLine();
            double area;
            if (userInput == "1")
            {
                Console.WriteLine("Enter length of side one: ");
                var sideOne = Console.ReadLine();
                if (!double.TryParse(sideOne, out double a))
                {
                    Console.WriteLine("Invalid value entered. Enter number only");
                    Environment.Exit(1);
                }
                Console.WriteLine("Enter length of side two: ");
                var sideTwo = Console.ReadLine();
                if (!double.TryParse(sideTwo, out double b))
                {
                    Console.WriteLine("Invalid value entered. Enter number only");
                    Environment.Exit(1);
                }
                Console.WriteLine("Enter length of side three: ");
                var sideThree = Console.ReadLine();
                if (!double.TryParse(sideThree, out double c))
                {
                    Console.WriteLine("Invalid value entered. Enter number only");
                    Environment.Exit(1);
                }
                area = Triangle.AreaFromThreeSides(a, b, c);
            }

            else
            {
                Console.WriteLine("Enter length of the base: ");
                var sideOne = Console.ReadLine();
                if (!double.TryParse(sideOne, out double Base))
                {
                    Console.WriteLine("Invalid value entered. Enter number only");
                    Environment.Exit(1);
                }
                Console.WriteLine("Enter the height: ");
                var sideTwo = Console.ReadLine();
                if (!double.TryParse(sideTwo, out double Height))
                {
                    Console.WriteLine("Invalid value entered. Enter number only");
                    Environment.Exit(1);
                }
                area = Triangle.AreaFromBaseHeight(Base, Height);
            }
            Console.WriteLine($"The triangle area is {area}");
        }
    }
}

