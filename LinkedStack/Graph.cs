using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedStack
{
    public struct NodeEdge
    {
        public char node;
        public int weight;

        public NodeEdge(char node, int weight)
        {
            this.node = node;
            this.weight = weight;
        }
    }
    public struct GraphNode
    {
        public char node;
        public Stack<NodeEdge> edges;

        public GraphNode(char node)
        {
            this.node = node;
            edges = new Stack<NodeEdge>();
        }
    }
    public class Graph
    {
        Stack<GraphNode> nodes;
            
        public Graph()
        {
            nodes = new Stack<GraphNode>();
        }

        public void AddNode(char node)
        {
            GraphNode graphNode = new GraphNode(node);
            nodes.push(graphNode);
        }

        public void AddEdge(char node1, char node2, int weight)
        {
            GetNode(node1).edges.push(new NodeEdge(node2, weight));
            GetNode(node2).edges.push(new NodeEdge(node1, weight));
        }

        public IEnumerable<char> GetNodes()
        {
            foreach (GraphNode graphNode in nodes.list())
                yield return graphNode.node;
        }

        public GraphNode GetNode(char node)
        {
            foreach (GraphNode graphNode in nodes.list())
                if (graphNode.node == node)
                    return graphNode;
            throw new Exception("Node not found");
        }
    }
}
