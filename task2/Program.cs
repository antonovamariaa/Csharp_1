Console.Write("input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("input third number: ");
int num3 = Convert.ToInt32(Console.ReadLine());

int maxval = num1;

if (num2>maxval) {
    maxval = num2;
}
if (num3>maxval) {
    maxval = num3;
}
Console.WriteLine(maxval); 
//Так же задачу можно решать через массивы и при увеличении количества вводимых чисел длина кода не меняется, то есть программа будет более оптимизирована

