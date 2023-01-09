using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Nullabe_Exception
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public int Salary { get; set; }


        public List<Person> GetAll()
        {

            List<Person> people = new List<Person>();
            


            Person person1 = new Person()
            {
                Name = "Konul",
                Surname = "Ibrahimov",
                Address = "Nefciler",
                Salary = 1500
            };

            Person person2 = new Person()
            {
                Name = "Farid",
                Surname = "Abdullayev",
                Address = "Seki",
                Salary = 900
            };

            Person person3 = new Person()
            {
                Name = "Shaiq",
                Surname = "Kazimov",
                Address = "Sedmoy",
                Salary = 1200
            };

            Person person4 = new Person()
            {
                Name = "Elekber",
                Surname = "Hesenov",
                Address = "Bayil",
                Salary = 2500
            };

            Person person5 = new Person()
            {
                Name = "Elcan",
                Surname = "Qurbanov",
                Address = "Hovsan",
                Salary = 100
            };

            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            people.Add(person5);

            return people;
        }


        public List<Person> GetPersonSalary(Predicate<Person> func, List<Person> people)
        {
            var person1 = GetAll();
            List<Person> persons1 = new List<Person>();
            foreach (var item in persons1)
            {
                if (func(item))
                {
                    persons1.Add(item);
                }

            }
            return persons1;
        }

        public void FiltredBySalary()
        {
            var peoples = GetAll();
            var result = GetPersonSalary(m=>m.Salary>1000,peoples);
            foreach (var item in result)
            {
                Console.WriteLine(item.Name + "-" + item.Surname + "-" + item.Address);

            }
        }


    }
}
