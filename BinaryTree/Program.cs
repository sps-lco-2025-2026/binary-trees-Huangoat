using BinaryTree;

Tree tree = new Tree();
tree.Add(5);
tree.Add(3);
tree.Add(7);
tree.Add(7);
Console.WriteLine(tree.Sum());
Console.WriteLine(tree.IsDuplicates());
Console.WriteLine(tree);