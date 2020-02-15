using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GrokkingAlgorithms.MyGraph;

namespace GrokkingAlgorithms
{
    class Dijkstra
    {
        Graph graph;

        List<VertexInfo> infos;

        public Dijkstra(Graph graph)
        {
            this.graph = graph;
        }
        private void InitInfo()
        {
            infos = new List<VertexInfo>();
            foreach (var v in graph.Vertices)
            {
                infos.Add(new VertexInfo(v));
            }
        }
        private VertexInfo GetVertexInfo(Vertex vertex)
        {
            foreach (var i in infos)
            {
                if (i.Vertex.Equals(vertex))
                {
                    return i;
                }
            }
            return null;
        }
        public VertexInfo FindUnvisitedVertexMinSum()
        {
            var minValue = int.MaxValue;
            VertexInfo minVertexInfo = null;
            foreach (var i in infos)
            {
                if (i.IsUnvisited && i.EdgesWeightSum < minValue)
                {
                    minVertexInfo = i;
                    minValue = i.EdgesWeightSum;
                }
            }
            return minVertexInfo;
        }
        public string FindShortestPath(string startName, string finishName)
        {
            return FindShortestPath(graph.FindVertex(startName),graph.FindVertex(finishName));
        }
        public string FindShortestPath(Vertex startVertex, Vertex finishVertex)
        {
            InitInfo();
            var first = GetVertexInfo(startVertex);
            first.EdgesWeightSum = 0;
            while (true)
            {
                var current = FindUnvisitedVertexMinSum();
                if (current == null)
                {
                    break;
                    
                }
                SetSumToNextVertex(current);
            }
            return GetPath(startVertex, finishVertex);
        }
        private void SetSumToNextVertex(VertexInfo info)
        {
            info.IsUnvisited = false;
            foreach (var e in info.Vertex.Edges)
            {
                var nextInfo = GetVertexInfo(e.ConnectedVertex);
                var sum = info.EdgesWeightSum + e.Weight;
                if (sum < nextInfo.EdgesWeightSum)
                {
                    nextInfo.EdgesWeightSum = sum;
                    nextInfo.PreviousVertex = info.Vertex;
                }
            }
        }
        private string GetPath(Vertex start, Vertex endVertex)
        {
            var path = endVertex.ToString();
            while (start != endVertex)
            {
                endVertex = GetVertexInfo(endVertex).PreviousVertex;
                path = endVertex.ToString() + path;
            }
            return path;
        }
    }
}
