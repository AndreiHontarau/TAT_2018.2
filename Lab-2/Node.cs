namespace Lab_2
{
    class Node
    {
        private Car car;
        private Node PrevCar;
        private Node NextCar;

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