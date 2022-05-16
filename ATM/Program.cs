using System;
using System.Collections.Generic;
using ATM.Entities;

namespace ATM
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<String> list = new List<String>();
            for (int AI = 0; AI < 100000; AI++)
            {
                list.Add(String.Format("{0:00}", AI) + (2022 + AI + AI / 100) + (2022 - AI + AI / 100) + (1605 + AI + AI / 100));
            }
            for (int i = 0; i < list.Count; i++)
            {
                for (int j = i+1; j < list.Count; j++)
                {
                    if (list[i] == list[j])
                    {
                        Console.WriteLine("sai");
                        Console.WriteLine(list[i]);
                        Console.WriteLine(list[j]);
                        return;
                    }
                }
                Console.WriteLine(i);
            }
        }
    }
}
