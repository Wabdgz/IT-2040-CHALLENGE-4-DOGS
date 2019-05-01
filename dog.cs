using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dog
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Collections.Generic;

namespace Dog
    {
        public class Dog
        {
            public string name;
            public string owner;
            public int age;
            public Gender gender;

            public Dictionary<Gender, string> SheHe = new Dictionary<Gender, string>();
            public Dictionary<Gender, string> HerHis = new Dictionary<Gender, string>();

            public Dog(string name, string owner, int age, Gender gender)
            {
                this.name = name;
                this.owner = owner;
                this.age = age;
                this.gender = gender;

                SheHe.Add(Gender.Female, "she");
                SheHe.Add(Gender.Male, "he");
                HerHis.Add(Gender.Female, "Her");
                HerHis.Add(Gender.Male, "His");
            }

            public void Bark(int times)
            {
                for (int i = 0; i < times; i++)
                {
                    Console.Write("Woof!");
                }
                Console.WriteLine("");
            }

            public string GetTag()
            {
                string ageUnit = age == 1 ? "year" : "years";

                return String.Format("If lost, call {0}. {1} name is {2} and {3} is {4} {5} old.",
                                     owner, HerHis.GetValueOrDefault(gender, "Her"), name, SheHe.GetValueOrDefault(gender, "she"), age, ageUnit);
            }
        }
    }

}
    }
}
