using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.MyGraph
{
    class Edge
    {
        public int Weight { get; }
        public Vertex ConnectedVertex { get; }
        public Edge(int weight, Vertex vertex)
        {
            Weight = weight;
            ConnectedVertex = vertex;
        }
    }
}
