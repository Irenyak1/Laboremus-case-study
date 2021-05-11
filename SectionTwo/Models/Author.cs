using SectionTwo.Models;
using System.Collections.Generic;

namespace SectionTwo.Data
{
    public class Author
    {
        public int Id { get; set; }

        public string name { get; set; }

        public List<Book> books { get; set; }
    }
}