using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GrokkingAlgorithms.MyGraph
{
    class Graph
    {
        public List<Vertex> Vertices { get; }
        public Graph()
        {
            Vertices = new List<Vertex>();
        }
        /// <summary>
        /// Добавление вершины
        /// </summary>
        /// <param name="VertexName"></param>
        public void AddVertex(string VertexName)
        {
            Vertices.Add(new Vertex(VertexName));
        }
        public Vertex FindVertex(string VertexName)
        {
            foreach (var v in Vertices)
            {
                if (v.Name.Equals(VertexName))
                {
                    return v;
                }
            }
            return null;
        }
        public void AddEdge(string firstName, string secondName, int weight)
        {
            var v1 = FindVertex(firstName);
            var v2 = FindVertex(secondName);
            if (v1 != null && v2 != null)
            {
                v1.AddEdge(weight, v2);
                v2.AddEdge(weight, v1);
            }
        }
    }
}
