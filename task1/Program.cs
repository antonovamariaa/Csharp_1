Console.Write("input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num1>num2) {Console.WriteLine("max = " + num1);}
else if (num2>num1) {Console.WriteLine("max = " + num2);}
else {Console.WriteLine("numbers are equal");}