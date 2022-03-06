using System;
using System.Collections.Generic;
using System.Text;

namespace ToDoIT.Data
{
    class TodoSequencer
    {
        private static int todoId;

        public static int NextToDoId()
        {
            return todoId++;

        }

        public static void Reset()
        {
            todoId = 0;
        }

    }
}
