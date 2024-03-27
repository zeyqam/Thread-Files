

//void Method1()
//{
//    Thread.Sleep(3000);
//    for(int i = 0; i < 100; i++)
//    Console.WriteLine("Method1-" +i);
//}
//void Method2()
//{
//    for (int i = 0; i < 100; i++) Console.WriteLine("Method2-" + i);
//}
//void Method3()
//{
//    for (int i = 0; i < 100; i++)
//        Console.WriteLine("Method3-" + i);
//}


//void Method4()
//{
//    for (int i = 0; i < 100; i++)
//        Console.WriteLine("Method4-" + i);
//}
//Thread thread1 = new Thread(Method1);


//Thread thread2 = new Thread(Method2);
//thread1.Start();
//Method3();
//thread2.Start();
//Method4();

using Thread_Files;
using Thread_Files.Controllers;


//ExampleFile file = new ExampleFile();
//file.WriteToFile("C:\\Users\\HP\\Desktop\\C#\\file2.txt", "Salam Yusif");
//file.WriteToFile("C:\\Users\\HP\\Desktop\\C#\\file3.txt", "salam Behruz");
//file.ReadFromFile("C:\\Users\\HP\\Desktop\\C#\\file2.txt");
//file.WriteToNewFile("C:\\Users\\HP\\Desktop\\C#\\file7.txt","necesiz Nesir bey?");

FileController fileController = new FileController();
//await fileController.ReadDataAsync();
await fileController.CreateFileWithContentAsync();
//await fileController.DeleteAsync();