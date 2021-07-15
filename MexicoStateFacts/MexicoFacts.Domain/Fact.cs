using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MexicoFacts.Domain
{
    public class Fact
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public State State { get; set; }
        public int StateId { get; set; }
    }
}
