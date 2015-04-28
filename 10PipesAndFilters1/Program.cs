using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10PipesAndFilters1
{
    public class Program
    {
        static void Main(string[] args)
        {
            var pipeline = new KwicPipeline();
            pipeline.Execute();
        }
    }

    public interface IOperation<T>
    {
        IEnumerable<T> Execute(IEnumerable<T> input);
    }

    public class KwicPipeline : Pipeline<string>
    {
        public KwicPipeline()
        {
            Register(new Reader());
            Register(new Shifter());
            Register(new Sorter());
            Register(new Writer());
        }
    }


    public class Pipeline<T>
    {
        private readonly List<IOperation<T>> operations = new List<IOperation<T>>();

        public Pipeline<T> Register(IOperation<T> operation)
        {
            operations.Add(operation);
            return this;
        }

        public void Execute()
        {
            IEnumerable<T> current = new List<T>();
            foreach (IOperation<T> operation in operations)
            {
                current = operation.Execute(current);
            }
            IEnumerator<T> enumerator = current.GetEnumerator();
            while (enumerator.MoveNext());
        }
    }

    public class Reader : IOperation<string>
    {
        public IEnumerable<string> Execute(IEnumerable<string> input)
        {
            Console.Title = "Pipes and Filters Pattern in .NET";
            Console.WriteLine("Enter the file name:");
            return File.ReadLines(Console.ReadLine());
        }
    }

    public class Shifter : IOperation<string>
    {
        public IEnumerable<string> Execute(IEnumerable<string> input)
        {
            List<string> shifts = new List<string>();

            foreach (string line in input)
            {
                string[] words = line.Split(new char[] { ' ' });

                for (int i = 0; i <= words.Length - 1; i++)
                {
                    shifts.Add(string.Join(" ", words));

                    string firstWord = words[0];

                    for (int j = 1; j <= words.Length - 1; j++)
                    {
                        words.SetValue(words[j], j - 1);
                    }
                    words.SetValue(firstWord, words.Length - 1);
                }
            }

            return shifts;
        }
    }

    public class Sorter : IOperation<string>
    {
        public IEnumerable<string> Execute(IEnumerable<string> input)
        {
            return input.OrderBy(x => x);
        }
    }

    public class Writer : IOperation<string>
    {
        public IEnumerable<string> Execute(IEnumerable<string> input)
        {
            foreach (string line in input)
            {
                Console.WriteLine();
                Console.WriteLine(line);
            }
            Console.ReadLine();
            yield break;
        }
    }




}
