using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedStack
{
    class Program
    {
        static void Main(string[] args)
        {
            Graph graph = new Graph();
            graph.AddNode('A');
            graph.AddNode('B');
            graph.AddNode('C');
            graph.AddNode('D');
            graph.AddNode('E');
            graph.AddNode('F');
            graph.AddNode('G');
            graph.AddEdge('A', 'B', 2);
            graph.AddEdge('A', 'C', 3);
            graph.AddEdge('A', 'D', 6);
            graph.AddEdge('B', 'C', 4);
            graph.AddEdge('C', 'D', 1);
            graph.AddEdge('B', 'E', 9);
            graph.AddEdge('C', 'E', 7);
            graph.AddEdge('C', 'F', 6);
            graph.AddEdge('D', 'F', 4);
            graph.AddEdge('E', 'F', 1);
            graph.AddEdge('E', 'G', 5);
            graph.AddEdge('F', 'G', 8);
            Dijkstra dijkstra = new Dijkstra(graph);
            Console.WriteLine(dijkstra.GetShortestPath('A', 'G'));
            Console.ReadKey();
        }

        static void StackDemo()
        { 
            Stack<Dog> stack = new Stack<Dog>();
            stack.push(new Dog("Sharik"));
            stack.push(new Dog("Bobik"));
            stack.push(new Dog("Enter"));

            Console.WriteLine(stack.pop().Voice());

            foreach (Dog item in stack.list())
                Console.WriteLine(item.Voice());

            Console.WriteLine();

            Console.WriteLine(stack.pop().Voice());
            Console.WriteLine(stack.pop().Voice());

            Console.ReadKey();
        }
    }
}
