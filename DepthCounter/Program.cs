// See https://aka.ms/new-console-template for more information
using DepthCounter.Models;
using DepthCounter.Tools;

Console.WriteLine("Hello, World!");

Branch manuallyCreatedTree = BranchGenerator.GenerateNewTree();
int depth = DepthCalculator.CalculateDepth(manuallyCreatedTree);

Branch rootNode = new Branch();
// populates the branch with selected depth, large numbers can cause stack overflow
BranchGenerator.PopulateBranch(rootNode, 17, 7);
int secondDepth = DepthCalculator.CalculateDepth(rootNode);

Console.WriteLine($"Depth of the tree: {depth}");
Console.WriteLine($"Depth of the tree: {secondDepth}");

