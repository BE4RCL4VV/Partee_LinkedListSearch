using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partee_LinkedListSearch
{
    public class LinkedList
    {
        private char[] _index = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n','o','p','q','r','s','t','u','v','w','x','y','z'};
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Overall { get; private set; }
        public int Males { get; private set; }
        public int Females { get; private set; }
        public MetaData TopMale { get; private set; }
        public MetaData TopFemale { get; private set; }
        public bool Contains(string person)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Person.Name.ToLower() == person.ToLower())
                {
                    return true;
                }

                current = current.Next;
            }
            return false;
        }
        public bool Contains(string person, char gender)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Person.Name.ToLower() == person.ToLower() && current.Person.Gender == gender)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public Node Find(string person)
        {
            Node current = Head;
            while (current != null)
            {
                if (current.Person.Name.ToLower() == person)
                {
                    return current;
                }

                current = current.Next;
            }
            return null;
        }
        public Node FindLast(MetaData person)
        {
            Node current = Tail;
            while (current != null)
            {
                if (current.Person == person)
                {
                    return current;
                }

                current = current.Previous;
            }
            return null;
        }
        public bool RemoveNode(MetaData person)
        {
            Node Current = Head;
            while (Current != null)
            {
                if (Current.Person == person)
                {
                    if (Current.Next == null)
                    {
                        Tail = Current.Previous;
                    }
                    else
                    {
                        Current.Next.Previous = Current.Previous;
                    }
                    if (Current.Previous == null) { Head = Current.Next; }
                    else { Current.Previous.Next = Current.Next;  }
                    Current = null;
                    Overall--;
                    if (person.Gender == 'M')
                    {
                        Males--;
                    }
                    if (person.Gender == 'F')
                    {
                        Females--;
                    }
                    return true;
                }
                Current = Current.Next;
            }
            return false;
        }        
        public void AddNode(Node newNode)
        {
            Node Current = Head;
            if (Tail == null)
            {
                Head.Next = newNode;
                Tail = newNode;
                Tail.Previous = Head;
            }
            else
            {
                Node temp = Tail;
                Tail.Next = newNode;
                newNode.Previous = temp;
                Tail = newNode;
            }
            // Track top Rank name
            if (newNode.Person.Rank < newNode.Previous.Person.Rank)
            {
                if (newNode.Person.Gender == 'M')
                {
                    TopMale = newNode.Person;
                }
                if (newNode.Person.Gender == 'F')
                {
                    TopFemale = newNode.Person;
                }
            }
            // Increment Amounts of List
            Overall++;
            if (newNode.Person.Gender == 'M')
            {
                Males++;
            }
            if (newNode.Person.Gender == 'F')
            {
                Females++;
            }
        }
    }
}
