using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingTodoAPI.Models
{
    public class User
    {
        public int Id { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }
        public virtual ICollection<Category> Categories { get; set; }
    }
}
