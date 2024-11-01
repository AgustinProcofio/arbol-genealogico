using Library;

public class LongestNameVisitor : IVisitor<Person>
{
    private string longestName = string.Empty;

    public void Visit(Node<Person> node)
    {
        if (node.Number.Name.Length > longestName.Length)
        {
            longestName = node.Number.Name;
        }
    }

    public string GetLongestName()
    {
        return longestName;
    }
}