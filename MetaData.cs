using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partee_LinkedListSearch
{
    public class MetaData
    {
        private char _gender;
        private string _name;
        private int _rank;
        private int _overall;
        private int _males;
        private int _females;
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
        public int Overall
        {
            get { return _overall; }
            set { _overall++; }
        }
        public int MaleNames
        {
            get { return _males; }
            set { _males++; }
        }
        public int FemaleNames
        {
            get { return _females; }
            set { _females++; }
        }
        public MetaData(string name, char gender, int rank)
        {
            _gender = gender;
            _name = name;
            _rank = rank;

            Overall++;                     
            if (gender == 'F')
            {
                FemaleNames++;
            }
            if (gender == 'M')
            {
                MaleNames++;
            }

        }
    }
}
