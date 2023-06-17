using System.Text;

namespace PatronesDeDiseñoModeladoDeSoftware.Composite.Example;

internal class Composite : Component
{
    protected List<Component> _children = new();

    public override void Add(Component component)
    {
        this._children.Add(component);
    }

    public override void Remove(Component component)
    {
        this._children.Remove(component);
    }

    public override string Operation()
    {
        int i = 0;
        StringBuilder result = new("Branch(");

        foreach (Component child in this._children)
        {
            result.Append(child.Operation());

            if (i != this._children.Count - 1)
            {
                result.Append(" + ");
            }
            i++;
        }

        return result.Append(')').ToString();
    }
}
