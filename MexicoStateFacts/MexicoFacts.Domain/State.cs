using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MexicoFacts.Domain
{
    public class State
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Fact> Facts { get; set; } = new List<Fact>();
    }
}
