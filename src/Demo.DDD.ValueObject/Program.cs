using Humanizer;

namespace Demo.DDD.ValueObject
{

    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("\nFIRST EXAMPLE:\n");

            Name myFirstName = new("Mohammed");
            Name myLastName = (Name)"Hoque";
            Name myFamilyName = new("Hoque");

            Console.WriteLine(myFirstName + " " + myLastName);

            if (myLastName == myFamilyName)
            {
                Console.WriteLine($"{nameof(myLastName).Humanize(LetterCasing.Sentence)} is {nameof(myFamilyName).Humanize(LetterCasing.LowerCase)}");
            }

            if (!myFirstName.Equals(myLastName))
            {
                Console.WriteLine($"{nameof(myFirstName).Humanize(LetterCasing.Sentence)} is not equal to {nameof(myLastName).Humanize(LetterCasing.LowerCase)}");
            }

            string myFamilyNameString = myFamilyName;
            Console.WriteLine($"My family name is {myFamilyNameString}");

            Console.WriteLine("\nSECOND EXAMPLE:\n");

            Address one = new("123 Preston", "Dallas", "TX", "US", "75000");
            Address two = new("123 Preston", "Dallas", "TX", "US", "75000");

            Console.WriteLine("EqualityComparer<Address>.Default.Equals(one, two): " + EqualityComparer<Address>.Default.Equals(one, two)); // True
            Console.WriteLine("object.Equals(one, two): " + object.Equals(one, two)); // True
            Console.WriteLine("one.Equals(two): " + one.Equals(two)); // True
            Console.WriteLine($"one == two: {one == two}"); // True

            Console.WriteLine("\nTHIRD EXAMPLE:\n");
            Phone myPhone1 = new("214-000-0000", "Personal");
            Phone myPhone2 = new("214-000-0000", "Personal");
            Console.WriteLine(myPhone1.ToString());

            if (myPhone1 == myPhone2)
            {
                Console.WriteLine($"{nameof(myPhone1)} is equal to {nameof(myPhone2)}");
            }
            else
            {
                Console.WriteLine($"{nameof(myPhone1)} is NOT equal to {nameof(myPhone2)}");
            }
        }

        public record Phone(string Number, string Type);

    }
}