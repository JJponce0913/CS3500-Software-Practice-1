// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
StringUtil sUtil = new StringUtil();
List<char> digits = sUtil.GetDigits("abc123"); // returns the correct result
foreach(char var in digits)
{    
    Console.WriteLine(var);
}
StringUtil sUtil2 = new StringUtil();
digits = sUtil2.GetDigits("xyz456"); 
foreach(char var in digits)
{    
    Console.WriteLine(var);
}