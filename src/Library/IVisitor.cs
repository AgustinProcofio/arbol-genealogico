namespace Library;

public interface IVisitor<Person>
{
    void Visit(Node<Person> node);
}