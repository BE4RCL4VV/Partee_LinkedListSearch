using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partee_LinkedListSearch
{
    public class Node
    {
        private MetaData _person;
        private Node _next;
        private Node _prev;


        public MetaData Person
        {
            get { return _person; }
            set { _person = value; }
        }
        public Node Next
        {
            get { return _next; }
            set { _next = value; }
        }
        public Node Previous
        {
            get { return _prev; }
            set { _prev = value; }
        }

        public Node(MetaData person)
        {
            _person = person;
        }

    }
}
