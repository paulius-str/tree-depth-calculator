using DepthCounter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthCounter.Tools

{
    public static class DepthCalculator
    {
        public static int CalculateDepth(Branch currentBranch)
        {
            if (currentBranch.Branches.Count == 0)
            {
                return 1;
            }

            Dictionary<int, int> childrenDepths = new Dictionary<int, int>();

            for (int i = 0; i < currentBranch.Branches.Count; i++)
            {
                childrenDepths.Add(i, CalculateDepth(currentBranch.Branches[i]));
            }

            var childWithMaxDepth = childrenDepths.FirstOrDefault(x => x.Value == childrenDepths.Values.Max());

            return childWithMaxDepth.Value + 1;
        }


    }
}
