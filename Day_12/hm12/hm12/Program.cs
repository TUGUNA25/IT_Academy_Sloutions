using hm12;

int x = 13;
int y = 13;
int z = -1;
Statuses minStatus;
Statuses maxStatus;
Statuses powStatus;
Console.WriteLine(ForMath.Min(x, y, out minStatus));
Console.WriteLine(minStatus);
Console.WriteLine(ForMath.Max(x, y, out maxStatus));
Console.WriteLine(maxStatus);
Console.WriteLine(ForMath.Pow(x, z, out powStatus));
Console.WriteLine(powStatus);

