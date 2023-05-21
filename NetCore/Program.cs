using System.Net;
using System.Text.RegularExpressions;

WebClient webClient = new WebClient();

string address = $"https://www.google.com/search?q=weather+";
string city = "warsaw";
string text = webClient.DownloadString(address + city);

string pattern = "<div class=\"BNeawe iBp4i AP7Wnd\">(-{0,1}\\d{1,2}.{0,1}\\d{0,2}).C<\\/div>";

string someString = "hello\\ntomasz";
Console.WriteLine(someString);

Regex rx = new Regex(pattern);
Match match = rx.Match(text);

string result = match.Groups[1].Value;

Console.WriteLine(result);

File.WriteAllText("output.html", text);
//Console.ReadKey();
