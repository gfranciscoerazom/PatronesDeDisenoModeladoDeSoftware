namespace PatronesDeDiseñoModeladoDeSoftware.Composite.Example;

internal class CompositeExample
{
    internal static void Main(string[] args)
    {
        Leaf leaf = new();
        Console.WriteLine("Client: I get a simple component:");
        Client.ClientCode(leaf);


        Composite tree = new();

        Composite branch1 = new();
        branch1.Add(new Leaf());
        branch1.Add(new Leaf());

        Composite branch2 = new();
        branch2.Add(new Leaf());

        tree.Add(branch1);
        tree.Add(branch2);

        Console.WriteLine("Client: Now I've got a composite tree:");
        Client.ClientCode(tree);

        Console.Write("Client: I don't need to check the components classes even when managing the tree:\n");
        Client.ClientCode2(tree, leaf);
    }
}
