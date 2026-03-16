namespace BinaryTree.tests;
using BinaryTree; 

[TestClass]
public sealed class Test1
{
    [TestMethod]
    public void TestDuplicates()
    {
        Tree tree = new Tree();
        tree.Add(5);
        tree.Add(3);
        tree.Add(7);
        tree.Add(7);
        Assert.IsTrue(tree.IsDuplicates());
    }
}
