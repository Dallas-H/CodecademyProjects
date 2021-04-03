using System;

namespace DatingProfile
{
    class Profile
    {
        //Fields

        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;

        //Constructors
        public Profile(string name, int age, string city, string country, string pronouns = "they/them")
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;
            this.hobbies = new string[] { };
        }

        //Properties

        //Methods
        public string ViewProfile( )
        {
            string profileInfo = $"\nName: {name} \nAge: {age} \nCity: {city}, {country} \nPronouns: {pronouns}\nHobbies: " + string.Join(", ",hobbies);
            return profileInfo;
        }

        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;

        }
    }
}
