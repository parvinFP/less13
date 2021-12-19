// See https://aka.ms/new-console-template for more information
using Axtarish.Extension;

string str=Console.ReadLine();
string searchtext=Console.ReadLine() ;
bool searchresult= str.Searching(searchtext) ;

if (searchresult)
{
    Console.WriteLine(  "true");

}
else
{ 
    Console.WriteLine( "false");
}
