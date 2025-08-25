namespace Assignment_2_Advanced
{
    internal class Program
    {
        #region Q3
        //public static void ReverseQueue(Queue<int> queue)
        //{
        //    Stack<int> stack = new Stack<int>();
        //    while (queue.Count > 0)
        //    {
        //        stack.Push(queue.Dequeue());
        //    }
        //    while (stack.Count > 0)
        //    {
        //        queue.Enqueue(stack.Pop());
        //    }
        //}
        #endregion
        static void Main(string[] args)
        {
            #region Q1
            //Console.WriteLine("Please enter size of array");
            //int.TryParse(Console.ReadLine(), out int size);
            //int[] arr = new int[size];
            //Console.WriteLine("Please enter number of Queries");
            //int.TryParse(Console.ReadLine(), out int query);
            //Console.WriteLine($"Array : ");
            //for (int i = 0; i < arr?.Length; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}
            //for (int i = 0; i < query; i++)
            //{
            //    Console.WriteLine($"Query {i+1}: ");
            //    int.TryParse(Console.ReadLine(), out int x);
            //    int count = 0;
            //    for (int j = 0; j < arr?.Length; j++)
            //    {
            //        if (arr[j] > x)
            //        {
            //            count++;
            //        }
            //    }
            //    Console.WriteLine($"Numbers greater than {x} = {count}");
            //}
            #endregion
            #region Q2
            //Console.WriteLine("Please enter size of array: ");
            //int.TryParse(Console.ReadLine(), out int size);
            //int[] arr = new int[size];
            //Console.WriteLine("Please enter items in array: ");
            //for (int i = 0; i < arr?.Length; i++)
            //{
            //    int.TryParse(Console.ReadLine(), out arr[i]);
            //}
            //bool isPalindrome = true;
            //for (int i = 0; i < size / 2; i++)
            //{
            //    if (arr?[i] != arr?[size - i - 1])
            //    {
            //        isPalindrome = false;
            //        break;
            //    }
            //}
            //if (isPalindrome)
            //    Console.WriteLine("YES");
            //else
            //    Console.WriteLine("NO");
            #endregion
            #region Q3
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //ReverseQueue(queue);
            //foreach (int item in queue)
            //{
            //    Console.Write($"{item} ");
            //}
            #endregion
        }
    }
}
