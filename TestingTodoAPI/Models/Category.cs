using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingTodoAPI.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public int User_Id { get; set; }
        public User User { get; set; }

        public virtual List<Task> Task { get; set; } = new List<Task>();
    }
}
