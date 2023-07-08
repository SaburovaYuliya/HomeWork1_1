//Задача1
Console.WriteLine("Введите первое число:");
int a1 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите второе число:");
int b1 = Convert.ToInt32(Console.ReadLine());
int max1 = a1;
if (b1 > a1) max1 = b1;
Console.WriteLine(max1);

//Задача2
Console.WriteLine("Введите первое число:");
int a2 = Convert.ToInt32(Console.ReadLine());
 Console.WriteLine("Введите второе число:");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число:");
int c2 = Convert.ToInt32(Console.ReadLine());
int max2 = a2;
if (b2 > a2) max2 = b2;
 if (c2 > b2) max2 = c2;
Console.WriteLine(max2);

//Задача3
Console.WriteLine("Введите число:");
int a3 = Convert.ToInt32(Console.ReadLine());
int result = a3 % 2;
if (result > 0)
    {
         Console.WriteLine("Ваше число нечетное");
    }
else
    {
         Console.WriteLine("Ваше число четное");
    }

//Задача4
Console.WriteLine("Введите число:");
int n4 = Convert.ToInt32(Console.ReadLine());
int i4 = 2;
while (n4 > i4)
    {
        if (i4 % 2==0)
         Console.Write($"{i4}, ");
        i4++;
     }
    
