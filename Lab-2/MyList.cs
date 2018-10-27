namespace Lab_2
{
    /// <summary>
    /// Represents a list of objects. Provides method
    /// to search.
    /// </summary>
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

        /// <summary>
        /// Checks if the list is empty
        /// </summary>
        /// <returns>True if the list is empty and false otherwise</returns>
        public bool IsEmpty()
        {
            bool listIsEmpty = false;
            if (Head.car == null)
            {
                listIsEmpty = true;
            }

            return listIsEmpty;
        }

        /// <summary>
        /// Searches for objects similar to passed object
        /// </summary>
        /// <param name="car">Object to serch similar objects to</param>
        /// <returns>List of found objects</returns>
        public MyList Search(Car car)
        {
            Node currentNode = new Node();
            currentNode = Head;
            MyList SearchResult = new MyList();

            while (currentNode.NextCar != null)
            {
                if ( (currentNode.car.Brand == car.Brand) || (currentNode.car.Model == car.Model) || (currentNode.car.Color == car.Color))
                {
                    SearchResult.AddHead(currentNode.car);
                    currentNode = currentNode.NextCar;
                }
            }
            return SearchResult;
        }

        /// <summary>
        /// Adds new node to the head of the list
        /// </summary>
        /// <param name="newCar">Car to put into the node</param>
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