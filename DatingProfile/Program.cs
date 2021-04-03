using System;

namespace DatingProfile
{
    class Program
    {
        static void Main(string[] args)
        {
            Profile sam = new Profile("Sam Drakkila",30,"New York","USA","he/him");
            string[] hobbies = { "listening to audiobooks", "playing rec sports like bowling and kickball", "writing a speculative fiction novel", "reading advice colomns" };
            sam.SetHobbies(hobbies);
            Console.WriteLine(sam.ViewProfile());

        }
        
    }
}
