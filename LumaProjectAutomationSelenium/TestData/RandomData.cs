using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LumaProjectAutomationSelenium.TestData
{
    public static class RandomData
    {
        public static string GenerateRandomFirstName()
        {
            string[] firstNames = { "Adam", "Barbara", "Cezary", "Daria", "Edward", "Filip", "Gosia", "Halina", "Ireneusz", "Justyna", "Kamil", "Magda", "Natalia", "Olaf", "Piotr", "Robert", "Sabina", "Tomasz", "Ula", "Wojciech", "Zofia" };
            Random random = new Random();
            int firstNameIndex = random.Next(firstNames.Length);
            return firstNames[firstNameIndex];
        }

        public static string GenerateRandomLastName()
        {
            string[] lastNames = { "Iksiński", "Kowalski", "Kowal", "Random", "Anon" };
            Random random = new Random();
            int lastNameIndex = random.Next(lastNames.Length);
            return lastNames[lastNameIndex];
        }

        public static string GenerateRandomEmailAddress()
        {
            var random = new Random();
            int randomNumber = random.Next(10001);
            return "email" + randomNumber + "@gmail.com";
        }

        public static string GenerateRandomPassword(int length)
        {
            const string validChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ1234567890!@#$%^&*()_+";
            char[] chars = new char[length];
            RandomNumberGenerator rng = new RNGCryptoServiceProvider();
            for (int i = 0; i < length; i++)
            {
                byte[] byteBuffer = new byte[1];
                rng.GetBytes(byteBuffer);
                chars[i] = validChars[byteBuffer[0] % validChars.Length];
            }
            return new string(chars);
        }

        public static string GenerateRandomReview()
        {
            string[] reviews = { "The fabric is so soft and comfortable!", "I love the unique design and pattern.", "The material feels cheap and scratchy." };
            Random random = new Random();
            int reviewsIndex = random.Next(reviews.Length);
            return reviews[reviewsIndex];
        }
    }
}
