namespace Library;
    class Program
    {
    //    {
    //     static void Main(string[] args)
    //     {
    //         Node<int>n1 = new Node<int>(1);
    //         Node<int>n2 = new Node<int>(2);
    //         Node<int>n3 = new Node<int>(3);
    //         Node<int>n4 = new Node<int>(4);
    //         Node<int>n5 = new Node<int>(5);
    //         Node<int>n6 = new Node<int>(6);
    //         Node<int>n7 = new Node<int>(7);

    //         n1.AddChildren(n2);
    //         n1.AddChildren(n3);

    //         n2.AddChildren(n4);
    //         n2.AddChildren(n5);

    //         n3.AddChildren(n6);
    //         n3.AddChildren(n7);

    //         // visitar el árbol aquí
    //         SumVisitor visitor = new SumVisitor();
    //         n1.Accept(visitor);
    //         Console.WriteLine(visitor.Sum);
    //     }
    // }
            static void Main(string[] args)
        {
            Node<Person>p1 = new Node<Person>(new Person(48,"Walter"));
            Node<Person>p2 = new Node<Person>(new Person(50,"Paola"));
            Node<Person>p3 = new Node<Person>(new Person(19,"Agustin"));
            Node<Person>p4 = new Node<Person>(new Person(24,"Micaela"));
            Node<Person>p5 = new Node<Person>(new Person(20,"Avril"));
            Node<Person>p6 = new Node<Person>(new Person(18,"Sebastian"));
            Node<Person>p7 = new Node<Person>(new Person(19,"Juan Ignacio"));

            p1.AddChildren(p3);
            p1.AddChildren(p4);

            p2.AddChildren(p3);
            p2.AddChildren(p4);

            p5.AddChildren(p6);
            p5.AddChildren(p7);

            // visitar el árbol aquí
            SumAgeVisitor visitor = new SumAgeVisitor();
            p1.Accept(visitor);
            Console.WriteLine(visitor.Sum);

            
            IVisitor<Person> oldestVisitor = new OldestChildVisitor();
            p1.Accept(oldestVisitor);
           
            IVisitor<Person> longestNameVisitor = new LongestNameVisitor();
            p1.Accept(longestNameVisitor);
        }
    }

