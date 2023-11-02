//class ThreadExample
//{
//    static void Main()
//    {
//        // Create two threads
//        Thread thread1 = new Thread(T1);
//        Thread thread2 = new Thread(T1);


//        // Start the threads
//        thread1.Start();
//        thread2.Start();

//        // Wait for the threads to finish
//        thread1.Join();
//        thread2.Join();

//        Console.WriteLine("Both threads have completed their work.");
//    }

//    static void T1()
//    {
//        for (int i = 1; i <= 5; i++)
//        {
//            Console.WriteLine("Thread " + Thread.CurrentThread.ManagedThreadId + " is working: " + i);
//            Thread.Sleep(100); // Simulate some work
//        }
//    }
//}
/***********************************************************************************************************/
//class Warehouse
//{
//    private int boxCount = 0;

//    public void AddBox(int workerId)
//    {
//        for (int i = 1; i <= 5; i++)
//        {
//            Thread.Sleep(100); // Simulate the time it takes to add a box
//            boxCount++;
//            Console.WriteLine($"Worker {workerId} added a box. Total boxes: {boxCount}");
//        }
//    }
//    public int GetTotalBoxes()
//    {
//        return boxCount;
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        Warehouse warehouse = new Warehouse();

//        Thread worker1 = new Thread(() => warehouse.AddBox(1));
//        Thread worker2 = new Thread(() => warehouse.AddBox(2));

//        worker1.Start();
//        worker2.Start();


//        worker1.Join();
//        worker2.Join();

//        Console.WriteLine("Work completed. Total boxes in the warehouse: " + warehouse.GetTotalBoxes());
//    }
//}
/*************************************************************************************************************/
//class Program
//{
//    static async Task Main()
//    {
//        Console.WriteLine("Starting the asynchronous operation...");

//        // Perform an asynchronous operation
//        await PerformAsyncOperation();

//        Console.WriteLine("Asynchronous operation completed.");
//    }

//    static async Task PerformAsyncOperation()
//    {
//        // Simulate an asynchronous operation
//        await Task.Delay(2000); // Delay for 2 seconds (simulating work)
//        Console.WriteLine("Async operation is complete.");
//    }
//}
/*******************************************************************************************/
