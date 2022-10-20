using System;

namespace GenericDemo_2
{
    class Program
    {
        static void Main(string[] args)
        {
            DataStore<string> trainee = new DataStore<string>();

            trainee.add(0,"Jay");
            trainee.add(1,"Fayzan");
            trainee.add(2,"Kenil");
            trainee.add(3,"Smit");
            trainee.add(4,"Mitesh");

            Console.WriteLine(trainee.getData(2));

            DataStore<string> city = new DataStore<string>();
		    city.add(0, "Vadodara");
		    city.add(1, "Rajkot");
		    city.add(2, "Mumbai");

            Console.WriteLine(city.getData(2));
        }

        class DataStore<T>
        {
            private T[] data = new T[10];

            public void add(int id, T value)
            {
                if(id >= 0  && id < 10)
                    data[id] = value;
            }

            public T getData(int id)
            {
                if(id >= 0  && id < 10)
                    return data[id];
                
                else
                    return default(T);
            }
        }


    }
}
