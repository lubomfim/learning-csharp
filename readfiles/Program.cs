using System.IO;
using System.Collections.Generic;
using Newtonsoft.Json;

var salesFiles = FindFiles($".{Path.DirectorySeparatorChar}mslearn-dotnet-files{Path.DirectorySeparatorChar}stores");

foreach (var file in salesFiles)
{
  Console.WriteLine(file);
}

IEnumerable<string> FindFiles(string folderName)
{
  List<string> salesFiles = new List<string>();

  var foundFiles = Directory.EnumerateFiles(folderName, "*", SearchOption.AllDirectories);

  foreach (var file in foundFiles)
  {
    if (file.EndsWith("sales.json"))
    {
      salesFiles.Add(file);
    }
  }

  return salesFiles;
}

// Get current directory path
Console.WriteLine(Directory.GetCurrentDirectory());
Console.WriteLine(Path.GetExtension("sales.json")); // outputs: .json

string fileName = $".{Path.DirectorySeparatorChar}mslearn-dotnet-files{Path.DirectorySeparatorChar}stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales{Path.DirectorySeparatorChar}sales.json";

FileInfo info = new FileInfo(fileName);

Console.WriteLine($"Full Name: {info.FullName}{Environment.NewLine}Directory: {info.Directory}{Environment.NewLine}Extension: {info.Extension}{Environment.NewLine}Create Date: {info.CreationTime}"); // Get infos from the file


// Create file
Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "mslearn-dotnet-files", "stores", "201", "newDir"));


bool doesDirectoryExist = Directory.Exists(fileName);


File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "greeting.txt"), "Hello World!");


Console.WriteLine(File.ReadAllText($"./mslearn-dotnet-files/stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales.json"));

var salesJson = File.ReadAllText($"./mslearn-dotnet-files/stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales.json");
var salesData = JsonConvert.DeserializeObject<SalesTotal>(salesJson);

Console.WriteLine(salesData.Total);

class SalesTotal
{
  public double Total { get; set; }
}