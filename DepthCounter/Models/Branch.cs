using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthCounter.Models
{
    public class Branch
    {
        private List<Branch> _branches = new List<Branch>();

        public List<Branch> Branches => _branches;
    }
}
