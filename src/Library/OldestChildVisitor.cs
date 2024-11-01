namespace Library;

public class OldestChildVisitor: IVisitor<Person>
{
    private int maxAge = int.MinValue;

    public void Visit(Node<Person> node)
    {
        
        if (node.Children.Count == 0)
        {
           
            if (node.Number.Age > maxAge)
            {
                maxAge = node.Number.Age;
            }
        }
    }

    public int GetOldestAge()
    {
        return maxAge;
    }
}