using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class CurrentAccount : Account
    {
        public override string AccType { get; set; }
        public override decimal MinimumBalance { get; set; }
    }
}
