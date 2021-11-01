using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partee_LinkedListSearch
{
    public class MetaData : IEquatable<MetaData>
    {
        private char _gender;
        private string _name;
        private int _rank;

        public char Gender
        {
            get { return _gender; }
            set { _gender = value; }
        }
        public int Rank
        {
            get { return _rank; }
            set { _rank = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public MetaData(string name, char gender, int rank)
        {
            _gender = gender;
            _name = name;
            _rank = rank;
        }

        public static bool operator >=(MetaData One, MetaData Two)
        {
            int result = string.Compare(One.Name, Two.Name);
            return result >= 0;
        }
        public static bool operator <=(MetaData One, MetaData Two)
        {
            int result = string.Compare(One.Name, Two.Name);
            return result <= 0;
        }
        public bool Equals(MetaData other)
        {
            return this.Name == other.Name;
        }
    }
}
