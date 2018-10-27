namespace Lab_2
{
    class MyList
    {
        private Node Head;

        public MyList()
        {
            Node headNode = new Node();
            Head = headNode;
        }

        public MyList(Car headCar)
        {
            Node headNode = new Node(headCar);
            Head = headNode;
        }

        public MyList Search()
        {
            MyList SearchResult = new MyList();
            return SearchResult;
        }

        public void AddHead()
        {

        }
    }
}