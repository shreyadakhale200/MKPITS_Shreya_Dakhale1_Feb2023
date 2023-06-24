using Microsoft.AspNetCore.Authentication.OAuth;

namespace MVCIntroduction.Models
{
    public class Person
    {
        public string name;
        public int age;
        public Person(string Name,int age)
        {
           this.name = Name;
           this.age = age;
        }
        //Creating property named name and age
        public string Name { get { return name; } }
        public int Age { get { return age; } }
        
    }
}
