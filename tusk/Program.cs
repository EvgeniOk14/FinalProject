Console.Clear();
string s = Console.ReadLine();
string [] arr = s.Split(" "); 
string [] arr2 = new string[arr.Length];
for(int i = 0; i < arr.Length; i++)
{
  if (arr[i].Length <= 3)
  {
    arr2[i] =arr[i];
  }
}
    Console.WriteLine($"[{string.Join(" ", arr2)}]");
  



