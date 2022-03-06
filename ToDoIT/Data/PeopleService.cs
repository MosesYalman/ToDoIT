using System;
using System.Collections.Generic;
using System.Text;
using ToDoIT.Models;

namespace ToDoIT.Data
{
    class PeopleService
    {
        private static Person[] personArray;

        public int Size()
        {
            return personArray.Length;
        }

        public Person[] FindAll()
        {
            return personArray;
        }

        public Person FindById(int personId)
        {
            Person tempPerson = new Person();
            foreach (var person in personArray)
            {
                if(person.Id == personId)
                {
                    tempPerson = person;
                    break;
                }
            }
            return tempPerson;
        }
    }

    
}
