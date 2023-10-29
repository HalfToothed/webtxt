
using System.Text.RegularExpressions;
using System.Net;
using System;
using System.Net.Http;
namespace Program;

class Program{

    static async Task Main(string[] args){

        Console.Write("enter URL: ");

        string url = Console.ReadLine();

        url = "http://www." + url;

        using HttpClient httpClient = new HttpClient();
        var result = await httpClient.GetStringAsync(url);
        Console.WriteLine(result);

        var plainText = StripHTMLTags(result);
        Console.WriteLine(plainText);       
    }

     static string StripHTMLTags(string input)
    {
        return Regex.Replace(input, "<.*?>", "");
    }
}