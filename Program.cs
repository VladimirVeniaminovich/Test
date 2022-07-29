string[] ArrayString;
int count = 0;
string s;
string[] ArrayString2;
Console.WriteLine("Введите строки:");
ArrayString = new string[count];
void SortingStrings()
{
  for (int i = 0; i < ArrayString.Length; i++)
  {
    if (ArrayString[i].Length<=3)
    Console.WriteLine("ArrayString[{0}] = {1}", i, ArrayString[i]);
  }
}
do
{
  s = Console.ReadLine();
  if (s!="")
  {
    count++;
    ArrayString2 = new string[count];
    for (int i = 0; i < ArrayString2.Length - 1; i++)
    {
      ArrayString2[i] = ArrayString[i];
    }
    ArrayString2[count - 1] = s;
    ArrayString = ArrayString2;
  }
} while (s != "");
SortingStrings();