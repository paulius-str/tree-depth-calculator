using DepthCounter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepthCounter.Tools
{
    public static class BranchGenerator
    {
        public static Branch GenerateNewTree()
        {
            Branch branch = new Branch();
            branch.Branches.Add(new Branch());
            branch.Branches[0].Branches.Add(new Branch());
            branch.Branches[0].Branches.Add(new Branch());
            branch.Branches[0].Branches.Add(new Branch());
            branch.Branches[0].Branches[1].Branches.Add(new Branch());
            branch.Branches[0].Branches[1].Branches[0].Branches.Add(new Branch());
            return branch;
        }

        public static void PopulateBranch(Branch root, int depth, int maxChildren)
        {
            if(depth <= 1) return; 

            int childCount = Random.Shared.Next(maxChildren) + 1;

            for (int i = 0; i < childCount; i++)
            {
                root.Branches.Add(new Branch());
            }

            int populatedChildIndex = Random.Shared.Next(childCount);

            PopulateBranch(root.Branches[populatedChildIndex], depth - 1, maxChildren);
        }
    }
}
