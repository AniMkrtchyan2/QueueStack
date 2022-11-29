namespace QueueStack
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyQueue<int> queue = new MyQueue<int>();

            // enqueue integers 1..3
            for (int i = 1; i <= 3; i++)
                queue.Enqueue(i);

            // execute 2 dequeue operations 
            for (int i = 0; i < 2; i++)
                Console.WriteLine($"Dequeued: " + queue.Dequeue());

            // enqueue integers 4..5
            for (int i = 4; i <= 6; i++)
                queue.Enqueue(i);

            // dequeue the rest
            while (!queue.isEmpty())
                Console.WriteLine($"Dequeued: " + queue.Dequeue());
        }
    }
}