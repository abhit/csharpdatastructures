using System;
using System.Collections.Generic;

namespace myGraph
{
    public class Graph
    {
        public int V; // number of vertices
        public LinkedList<int>[] adj; // Array of adjancey lists

        public Graph(int _v)
        {

            // initialize number of vertices
            this.V = _v;

            // create V number of linked lists
            this.adj = new LinkedList<int>[V]; 

            for (int i=0; i<adj.Length;i++)
            {
                adj[i] = new LinkedList<int>();
            }
        }

        // method to add an edge to graph
        public void AddEdge(int _to, int _new)
        {
            adj[_to].AddLast(_new);

        }

        public void DFS (int s)
        {
            Boolean[] visited = new Boolean[V];

            for (int i = 0; i < V; i++)
                visited[i] = false;

            Stack<int> stack = new Stack<int>();

            stack.Push(s);

            while(stack.Count > 0)
            {
                s = stack.Peek();

                stack.Pop();


                if(visited[s] == false)
                {
                    Console.Write(s + " ");
                    visited[s] = true;
                }

                foreach (int u in adj[s])
                {
                    if (!visited[u])
                        stack.Push(u);

                }   
            }
        }

        public void BFS (int s)
        {
            Boolean[] visited = new Boolean[V];

            for (int i = 0; i < V; i++)
                visited[i] = false;

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(s);

            while(queue.Count > 0)
            {
                s = queue.Peek();
                queue.Dequeue();

                if(visited[s] == false)
                {
                    Console.Write(s + " ");
                    visited[s] = true;
                }

                foreach (int u in adj[s])
                {
                    if (!visited[u])
                        queue.Enqueue(u);
                }
            }
        }
    }
}
