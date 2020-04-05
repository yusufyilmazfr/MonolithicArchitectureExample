using System;
using System.Collections.Generic;
using System.Text;

namespace MonolithicArchitecture.Entities
{
    public class Category
    {
        public Category()
        {
            CreatedDate = DateTime.Now;
            ModifiedDate = CreatedDate;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
