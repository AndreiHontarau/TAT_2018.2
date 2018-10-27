namespace Lab_2
{
    /// <summary>
    /// Container for MyList. Contains Car, references
    /// to next and previous nodes.
    /// </summary>
    class Node
    {
        public Car car { get; private set; }
        public Node PrevCar { get; set; }
        public Node NextCar { get; set; }

        public Node()
        {

        }

        public Node(Node prev, Node next)
        {
            PrevCar = prev;
            NextCar = next;
        }

        public Node(Car newCar)
        {
            car = newCar;       
        }
    }
}