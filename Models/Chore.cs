using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace choreScore.Models;

    public class Chore
    {
        public string Name { get; set; }
        public bool Completed { get; set; }
        public string Type { get; set; }

    public Chore(string name, bool completed, string type)
    {
        Name = name;
        Completed = completed;
        Type = type;
    }
}
    