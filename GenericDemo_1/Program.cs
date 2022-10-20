using System;

namespace GenericDemo_1
{
    class Program
    {
        static void Main(string[] args)
        {
           DataStore<string> strStore = new DataStore<string>();

            idValuePair<int, string> ivp1 = new idValuePair<int, string>();
            ivp1.id = 1;
            ivp1.Value = "Information Technology";
            Console.WriteLine(ivp1.id + ", " + ivp1.Value);

            idValuePair<string,string> ivp2 = new idValuePair<string, string>();
            ivp2.id = "Jay";
            ivp2.Value = "B.E. Computer Engineering";
            Console.WriteLine(ivp2.id + ", " + ivp2.Value);
        }
    }

    class DataStore <T>
    {
        public T Data { get; set; }
    }

    class idValuePair<Tid, TValue>
    {
        public Tid id { get; set; }
        public TValue Value { get; set; }
    }
}
