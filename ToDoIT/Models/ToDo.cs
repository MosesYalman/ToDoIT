using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIT.Models
{
    class ToDo
    {

        private int id;
        private string description;
        private bool done;
        public Person assignee;

        public string Description
        {
            get { return description; }
            set
            {
                if ((!String.IsNullOrWhiteSpace(description) || description.Length < 2))
                {
                    throw new ArgumentException("Invalid Data found!!!");
                }
                description = value;
            }
        }
        public bool Done
        {
            get { return done; }
        }

        public int Id
        {
            get => id;
        }


        public ToDo()
        { }
        public ToDo(Person assignee)
        {
            this.assignee = assignee;
        }

        public ToDo(int id, string description)
        {
            this.id = id;
            this.description = description;
        }

        public ToDo(int id, string description, bool done)
        {
            this.done = done;
            this.id = id;
            this.description = description;
        }

        public ToDo(int id, string description, bool done, Person person)
        {
            this.done = done;
            this.id = id;
            this.description = description;
            this.assignee = person;
        }

    }
}
