using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjectCode.Model
{
    class Author
    {
        static int counter = 0;
        public Author()
        {
            counter++;
            this.id = counter;
        }
        public Author(string name)
            :this()
        {
            this.Name = name;
        }
        public int id { get; private set; }
        public string Name { get; set; }
        public override string ToString()
        {
            return $"{id}.{Name}";
        }
    }
}
