using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

/*
var lines = File.ReadAllLines("TextFile1.txt");
foreach (var item in lines)
{
    Console.WriteLine(item);
}
*/

//async Task ReadFile()
//{
//    var lines = await File.ReadAllLinesAsync("TextFle1.txt");
//    foreach (var line in lines)
//    {
//        Console.WriteLine(line);
//    }
//}

// await ReadFile();


static async Task<int> GetDataFromNetworkAsync()
{
    // Simulate Network call
    await Task.Delay(150);
    var result = 42;

    return result;

}

var networkResult = await GetDataFromNetworkAsync();

// escribir la función en formato lamda
Func<Task<int>> getDataFromNetworkViaLambda = async () =>
{
    // simula network call
    await Task.Delay(150);
   var result = 42;

   return result;
};


//File.ReadAllLinesAsync("TextFile1.txt")
//    .ContinueWith(t =>
//    {
//        if (t.IsFaulted)
//        {
//            Console.Error.WriteLine(t.Exception);
//            return;
//        }
//        When the Task will be completed!
//        foreach (var line in t.Result)
//        {
//            Console.WriteLine(line);
//        }
//    });
//Console.WriteLine("I am here ");
//Console.ReadKey();


// haciendo sincronicamente 
/*
fileReadTask = File.ReadAllLinesAsync("TextFile1.txt");
fileReadTask.Wait();
*/