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

            int[] branchesDepths = new int[currentBranch.Branches.Count];

            for (int i = 0; i < currentBranch.Branches.Count; i++)
            {
                branchesDepths[i] = CalculateDepth(currentBranch.Branches[i]);
            }

            return branchesDepths.Max() + 1;
        }

    }
}
