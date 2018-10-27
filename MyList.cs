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

        public bool IsEmpty()
        {
            bool listIsEmpty = false;
            if (Head.car == null)
            {
                listIsEmpty = true;
            }

            return listIsEmpty;
        }

        public MyList Search()
        {
            MyList SearchResult = new MyList();
            return SearchResult;
        }

        public void AddHead(Car newCar)
        {
            Node newNode = new Node(newCar);
            if (this.IsEmpty())
            {
                Head = newNode;
            }
            else
            {
                Head.PrevCar = newNode;
                newNode.NextCar = Head;
                Head = newNode;
            }
        }
    }
}