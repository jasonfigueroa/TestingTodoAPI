using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestingTodoAPI.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public bool Complete { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
