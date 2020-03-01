using System;
using myBinaryTree;
using myGraph;

namespace DataStructures
{
    class Program 
    {
        static Graph CreateGraph()
        {
            // Total 6 vertices in graph 
            Graph g = new Graph(7);

            g.AddEdge(1, 0);
            g.AddEdge(0, 2);
            g.AddEdge(2, 1);
            g.AddEdge(0, 3);
            g.AddEdge(1, 4);
            g.AddEdge(0, 5);
            g.AddEdge(5, 1);
            g.AddEdge(1, 6);

            return g;
        }

        static bool IsPalindrome(string s)
        {
            if (s.Length <= 1)
                return true;

            if (s[0] != s[s.Length-1])
                return false;

            else
            {
                string str = s.Substring(1, s.Length - 2);
                return IsPalindrome(str);

            }
        }

        static void PrintGraphBFS( Graph g, int from)
        {
            Console.Write("Following is the Breadth First Traversal from {0}\n");
            g.BFS(0);

        }

        static void PrintGraphDFS( Graph g, int from)
        {
            Console.Write("Following is the Depth First Traversal from {0}\n");
            g.DFS(0);
        }

        static void Main(string[] args)
        {
            //declrations
            BinaryTree tree = new BinaryTree();
            int choice = -1;

            // end of declarations

            // initialize data structures
           

            do
            {
                // display user menu
                Console.WriteLine();
                Console.WriteLine("Please enter your choice:");
                Console.WriteLine("0. Press O to exit");
                Console.WriteLine("1. Create a new Tree");
                Console.WriteLine("2. Add new nodes to Tree");
                Console.WriteLine("3. Print Tree in Inorder");
                Console.WriteLine("4. Print Tree in Preorder");
                Console.WriteLine("5. Print Size of Tree");
                Console.WriteLine("6. Print Depth of Tree");
                Console.WriteLine("7. Print Tree");
                Console.WriteLine("8. Print a Graph DFS");
                Console.WriteLine("9. Print a Graph BFS");
                Console.WriteLine("10. Check for Palindrome");
                // get user choice
                try
                {
                    choice = Int32.Parse((Console.ReadLine()));

                }

                catch (System.FormatException)
                {
                    choice = -1;
                    Console.WriteLine("Error!");
                }

                // process user choice
                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Goodbye...");
                        break;

                    case 1:
                        tree.CreateTree();
                        break;

                    case 2:
                        Console.WriteLine("What is the value of new Node?");
                        int i = Int32.Parse(Console.ReadLine());
                        Node newnode = new Node(i);
                        tree.InsertNode(newnode);
                        //tree.InsertNode(b);
                        break;

                    case 3:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Inorder Traversal for the tree is:");
                        tree.PrintInorder();
                        Console.ResetColor();
                        break;

                    case 4:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Preorder Traversal for the trees is:");
                        tree.PrintPreorder();
                        Console.ResetColor();
                        break;

                    case 5:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Size of Tree is {0}", tree.size());
                        Console.ResetColor();
                        break;

                    case 6:
                        Console.BackgroundColor = ConsoleColor.Blue;
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Depth of the Tree is {0}", tree.depth());
                        Console.ResetColor();
                        break;

                    case 7:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Printing the Tree");
                        tree.PrintTree();
                        Console.ResetColor();
                        break;
                    case 8:
                        //Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Cyan;

                        Graph g = CreateGraph();
                        PrintGraphDFS(g, 0);
                        Console.ResetColor();
                        break;

                    case 9:
                        //Console.BackgroundColor = ConsoleColor.Cyan;
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        g = CreateGraph();
                        PrintGraphBFS(g, 0);
                        Console.ResetColor();
                        break;

                    case 10:
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("Please enter the string to check: ");
                        string str = Console.ReadLine();
                        Console.WriteLine(IsPalindrome(str.Trim()));
                        Console.ResetColor();
                        break;

                    default:
                        Console.WriteLine("Invalid selection, please try again..");
                        break;
                }
            } while (choice != 0);

        }

    }
}