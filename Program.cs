using System;
string? l1 = Console.ReadLine();
if (string.IsNullOrEmpty(l1)) return;
int n = int.Parse(l1);
string[] inp = Console.ReadLine()?.Split(' ', StringSplitOptions.RemoveEmptyEntries) ?? Array.Empty<string>();
int[] num = new int[n];
for (int i = 0; i < n; i++)
{
    num[i] = int.Parse(inp[i]);
}
int m = num[0];
foreach(int a in num) {
    if (a > m) m = a;
}
Console.WriteLine(m);
