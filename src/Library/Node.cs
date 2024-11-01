namespace Library;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Dynamic;

public class Node<T>
{
    private T number;

    private List<Node<T>> children = new List<Node<T>>();

    public T Number {
        get
        {
            return this.number;
        }
    }

    public ReadOnlyCollection<Node<T>> Children {
        get
        {
            return this.children.AsReadOnly();
        }
    }

    public Node(T number)
    {
        this.number = number;
    }

    public void AddChildren(Node<T> n)
    {
        this.children.Add(n);
    }
    public void Accept(IVisitor<T> visitor)
    {
        visitor.Visit(this);
        foreach (var item in this.children)
        {
            item.Accept(visitor);
        }
    }
}

