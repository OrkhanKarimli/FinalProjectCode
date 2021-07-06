using System;
using System.Collections.Generic;
using System.Text;

namespace FinalProjectCode.Model
{
    class Book
    {
        static int saygac = 0;
        public Book()
        {
            saygac++;
            this.id = saygac;
        }
        public Book(string name,int page)
            : this()
        {
            this.Name = name;
            this.page = page;
        }
        public int id { get; private set; }
        public string Name { get; set; }
        public int page { get; set; }
        public override string ToString()
        {
            return $"{id}.{Name} adli kitabin-{page}sehifesi movcuddur";
        }
    }
}
