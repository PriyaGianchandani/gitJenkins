﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
{

    class Genericswithindexers<T>
    {
        private T[] data = new T[3];
        private T var;
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        public T Var
        {
            get { return var; }
            set { var = value; }

        }

        public T this[int index]
        {
            get { return data[index]; }
            set { data[index] = value; }
        }
        public T this[float index]
        {
            get { return data[(int)index]; }
            set { data[(int)index] = value; }
        }

        public T this[string index]
        {
            get { return data[2]; }
            set { data[2] = value; }
        }


    }

    class Program
    {
        static void Main(string[] args)
        {
            Genericswithindexers<float> gi = new Genericswithindexers<float>();
            gi[0] = 5.5f;
            gi[1.0f] = 10.5f;
            gi[2] = 15.5f;
            gi.Var = 1.5f;
            gi.Name = "L N T";
            Console.WriteLine("At Position 1" + " " + gi[0]);
            Console.WriteLine("At Position 1" + " " + gi[1.0f]);
            Console.WriteLine("At Position 1" + " " + gi[2]);
            Console.WriteLine("Generic variable" + " " + gi.Var);
            Console.WriteLine("Non Generic variable" + " " + gi.Name);
            Console.Read();

        }
    }

}

