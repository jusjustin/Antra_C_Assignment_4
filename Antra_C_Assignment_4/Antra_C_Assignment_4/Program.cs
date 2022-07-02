/*1.Describe the problem generics address.
It makes it possible to design classes and methods that defer the specification of one or
more types until the class or method is declared and instantiated by client code

2. How would you create a list of strings, using the generic List class?
List<Int16> list = new List<Int16>();
List<string> authors = new List<string>(5);
string[] animals = { "Cow", "Camel", "Elephant" };
List<string> animalsList = new List<string>(animals);

3.How many generic type parameters does the Dictionary class have?
Generic. Dictionary<TKey,TValue> generic type has two type parameters, TKey and TValue , 
that represent the types of its keys and values

4.True / False.When a generic class has multiple type parameters, they must all match.
FALSE

5. What method is used to add items to a List object?
The Insert method of List<T> class inserts an object at a given position

6. Name two methods that cause items to be removed from a List.
Clear(), Remove(T)

7. How do you indicate that a class has a generic type parameter?
A generic type is declared by specifying a type parameter in an angle brackets after a type name,
e.g. TypeName<T> where T is a type parameter

8. True/False. Generic classes can only have one generic type parameter.
FALSE

9. True/False. Generic type constraints limit what can be used for the generic type.
TRUE

10. True/False. Constraints let you use the methods of the thing you are constraining to.
FALSE*/

/*1. Create a custom Stack class MyStack<T> that can be used with any data type which
has following methods
1. int Count()
2.T Pop()
3.Void Push()
*/
/*
class MyStack<T>
{
    static readonly int MAX = 1000;
    private int count = 0;
    private T[] stack = new T[MAX];
    public int Count() { return count++; }
    public T Pop() 
    {
        if (count < 0)
        {
            Console.WriteLine("Stack Underflow");
            return default;
        }
        else
        {
            T value = stack[count--];
            return value;
        }
    }
    public void Push(T item) 
    {
        if (count >= MAX)
        {
            Console.WriteLine("Stack Overflow");
        }
        else
        {
            stack[++count] = item;
        }
    }
}
*/

/*
2.Create a Generic List data structure MyList<T> that can store any data type.
Implement the following methods.
1. void Add (T element)
2. T Remove(int index)
3. bool Contains(T element)
4. void Clear()
5. void InsertAt(T element, int index)
6. void DeleteAt(int index)
7.T Find(int index)
*/
/*public class MyList<T>
{
    private int count;
    private Node head;

    public MyList()
    {
        head = null;
        count = 0;
    }

    public class Node
    {
        public Node next;
        public Object data;
    }

    public bool Empty() { return count == 0; }
    public int Count() { return count; }

    public void Add(T element)
    {
        Node toAdd = new Node();
        toAdd.data = element;
        Node current = head;
        current.next = toAdd;
    }
    public T Remove (int index)
    {
        if (index < 0)
            Console.WriteLine("Outside Range!");

        if (Empty())
            return default;

        if (index > Count())
            index = count - 1;

        Node node = head;
        T result = default;

        if(index == 0)
        {
            result = (T?)node.data;
            head = head.next;
        }
        else 
        {
            for(int i = 0; i < index -1; i++)
            {
                head = head.next;
            }
            result = (T?)head.next.data;
            head.next = head.next.next;
        }

        count--;

        return result;
    }
    public bool Contains(T t1)
    {
        return this.Find(t1) >= 0;
    }
    public void Clear()
    {
        head = null;
    }
    public void InsertAt(T element, int index)
    {
        if (index < 0)
            Console.WriteLine("Outside Range!");

        if (Empty())
            return;

        if (index > Count())
            index = count - 1;

        Node node = head;
        T result = default;

        if (index == 0)
        {
            result = (T?)node.data;
            head = head.next;
        }
        else
        {
            for (int i = 0; i < index - 1; i++)
            {
                head = head.next;
            }
            Node toAdd = new Node();
            toAdd.data = element;
            Node current = head;
            current.next = toAdd;
            head.next = head.next.next;
        }

        count++;

    }
    public int Find(T t1) //AKA find
    {
        for (int i = 0; i < count - 1; i++)
        {
            if (head.data.Equals(t1))
                return i;

            head = head.next;
        }
        return -1;
    }
    public void DeleteAt(int index)
    {
        if (index < 0)
            Console.WriteLine("Outside Range!");

        if (Empty())
            return;

        if (index > Count())
            index = count - 1;

        Node node = head;
        T result = default;

        if (index == 0)
        {
            result = (T?)node.data;
            head = head.next;
        }
        else
        {
            for (int i = 0; i < index - 1; i++)
            {
                head = head.next;
            }
            
            head.next = head.next.next;
        }

        count--;
    }
}*/

/*3.Implement a GenericRepository<T> class that implements IRepository<T> interface
that will have common /CRUD/ operations so that it can work with any data source
such as SQL Server, Oracle, In-Memory Data etc. Make sure you have a type constraint
on T were it should be of reference type and can be of type Entity which has one
property called Id. IRepository<T> should have following methods
1. void Add(T item)
2. void Remove(T item)
3.Void Save()
4.IEnumerable < T > GetAll()
5.T GetById(int id)*/

/*
public interface IRepository<T> where T : class
{
    void Add(T item);
    void Remove(T item);
    void Save();
    IEnumerable<T> GetAll();
    T GetById(int id);
}*/