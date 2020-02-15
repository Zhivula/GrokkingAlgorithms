using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.MyGraph
{
    class Vertex
    {
        public string Name { get; }
        public List<Edge> Edges { get; }
        public Vertex(string name)
        {
            Name = name;
            Edges = new List<Edge>();
        }
        public void AddEdge(Edge newEdge)
        {
            Edges.Add(newEdge);
        }
        public void AddEdge(int weight, Vertex vertex)
        {
            Edges.Add(new Edge(weight, vertex));
        }
        public override string ToString() => Name;
    }
}
