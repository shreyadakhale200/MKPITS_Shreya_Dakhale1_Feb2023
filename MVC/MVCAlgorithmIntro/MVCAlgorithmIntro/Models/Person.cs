using System.Runtime.CompilerServices;

namespace MVCAlgorithmIntro.Models
{
    public class Person
    {
        public string name;
        public int age; 

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

       public string Name { get;set; }
       public int Age { get;set; } 
    }
}
