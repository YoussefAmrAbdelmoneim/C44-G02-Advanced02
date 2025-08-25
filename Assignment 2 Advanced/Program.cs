using System.Collections;

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
        #region Q4
        //public static bool IsBalanced(string parentheses)
        //{
        //    Stack<char> stack = new Stack<char>();

        //    foreach (char c in parentheses)
        //    {
        //        if (c == '(' || c == '{' || c == '[')
        //        {
        //            stack.Push(c);
        //        }
        //        else if (c == ')' || c == '}' || c == ']')
        //        {
        //            if (stack.Count == 0) return false;

        //            char top = stack.Pop();

        //            if ((c == ')' && top != '(') ||
        //                (c == '}' && top != '{') ||
        //                (c == ']' && top != '['))
        //            {
        //                return false;
        //            }
        //        }
        //    }
        //    return stack.Count == 0;
        //}
        #endregion
        #region Q5
        //public static int[] RemoveDuplication(int[] arr)
        //{
        //    Array.Sort(arr);
        //    int n = arr.Length;
        //    int[] temp = new int[n];
        //    int j = 0;
        //    for (int i = 0; i < n - 1; i++)
        //    {
        //        if (arr[i] != arr[i + 1])
        //        {
        //            temp[j++] = arr[i];
        //        }
        //    }
        //    temp[j++] = arr[n - 1];
        //    int[] result = new int[j];
        //    Array.Copy(temp, result, j);
        //    return result;
        //}
        #endregion
        #region Q6
        //public static ArrayList RemoveOdd(ArrayList? list)
        //{
        //    if (list == null)
        //        return new ArrayList();
        //    for (int i = list.Count - 1; i >= 0; i--)
        //    {
        //        if ((int?)list[i] % 2 != 0)
        //        {
        //            list.RemoveAt(i);
        //        }
        //    }
        //    return list;
        //}
        #endregion
        #region Q8
        //public static void StackSearch(Stack<int> stack , int target )
        //{
        //    int count = 0;
        //    bool isFound = false;
        //    while (stack.Count > 0)
        //    {
        //        count++;
        //        if (stack.Pop() == target)
        //        {
        //            isFound = true;
        //            break;
        //        }
        //    }
        //    if (isFound)
        //        Console.WriteLine($"Target was found successfully and the count = {count}");
        //    else
        //        Console.WriteLine("Target was not found");
        //}
        #endregion
        #region Q9
        //public static int[] IntersectArrays(int[] arr1, int[] arr2)
        //{
        //    List<int> result = new List<int>();
        //    for (int i = 0; i < arr2.Length; i++)
        //    {
        //        for (int j = 0; j < arr1.Length; j++)
        //        {
        //            if (arr2[i] == arr1[j])
        //            {
        //                result.Add(arr2[i]);
        //                arr1[j] = int.MinValue;
        //                break;
        //            }
        //        }
        //    }
        //    return result.ToArray();
        //}
        #endregion
        #region Q10
        //public static ArrayList FindContiguousSublist(ArrayList? list, int target)
        //{
        //    for (int i = 0; i < list?.Count; i++)
        //    {
        //        int sum = 0;
        //        ArrayList sublist = new ArrayList();
        //        for (int j = i; j < list.Count; j++)
        //        {
        //            int current = (int?)list[j]??0;
        //            sum += current;
        //            sublist.Add(current);
        //            if (sum == target)
        //                return sublist;
        //            else if (sum > target)
        //                break;
        //        }
        //    }
        //    return null;
        //}
        #endregion
        #region Q11
        //public static Queue<int> ReverseFirstKElements(Queue<int> queue, int k)
        //{
        //    Stack<int> stack = new Stack<int>();
        //    for (int i = 0; i < k; i++)
        //    {
        //        stack.Push(queue.Dequeue());
        //    }
        //    while (stack.Count > 0)
        //    {
        //        queue.Enqueue(stack.Pop());
        //    }
        //    int n = queue.Count - k;
        //    for (int i = 0; i < n; i++)
        //    {
        //        queue.Enqueue(queue.Dequeue());
        //    }
        //    return queue;
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
            #region Q4
            //string parentheses = "[()]{ }";
            //if (IsBalanced(parentheses))
            //    Console.WriteLine("Balanced");
            //else
            //    Console.WriteLine("Not Balanced");
            #endregion
            #region Q5
            //int[] arr = [ 1, 2, 3, 4, 2, 3 ];
            //int[] removedDuplicationArray = RemoveDuplication(arr);
            //foreach (var item in removedDuplicationArray)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q6
            //ArrayList arrayList = new ArrayList() { 1, 2, 3, 4, 5, 6 };
            //RemoveOdd(arrayList);
            //foreach (int item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion
            #region Q7
            //Queue queue = new Queue();
            //queue.Enqueue(1);
            //queue.Enqueue("Apple");
            //queue.Enqueue(5.28);
            #endregion
            #region Q8
            //Stack<int> stack = new Stack<int>();
            //int[] numbers = [ 3, 7, 1, 9, 5, 2 ];
            //foreach (int item in numbers)
            //{
            //    stack.Push(item);
            //}
            //Console.Write("Enter the target integer: ");
            //  int.TryParse(Console.ReadLine(),out int target);
            //StackSearch(stack, target);
            #endregion
            #region Q9
            //int[] arr1 = { 1, 2, 3, 4, 4 };
            //int[] arr2 = { 10, 4, 4 };
            //int[] intersection = IntersectArrays(arr1, arr2);
            //Console.WriteLine("Intersection:");
            //Console.WriteLine("[" + string.Join(", ", intersection) + "]");
            #endregion
            #region 10
            //ArrayList list = new ArrayList() { 1, 2, 3, 7, 5 };
            //int target = 12;
            //ArrayList result = FindContiguousSublist(list, target);
            //if (result != null)
            //    Console.WriteLine("Contiguous sublist: [" + string.Join(", ", result.ToArray()) + "]");
            //else
            //    Console.WriteLine("No sublist found with the target sum.");
            #endregion
            #region Q11
            //Queue<int> queue = new Queue<int>();
            //queue.Enqueue(1);
            //queue.Enqueue(2);
            //queue.Enqueue(3);
            //queue.Enqueue(4);
            //queue.Enqueue(5);
            //int k = 3;
            //Queue<int> result = ReverseFirstKElements(queue, k);
            //Console.WriteLine("Result:");
            //Console.WriteLine("[" + string.Join(", ", result) + "]");
            #endregion
        }
    }
}
