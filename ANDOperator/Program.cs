﻿

int math, biology, chemistry;

Console.WriteLine("Enter your math result");
math = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your biology result");
biology = Int32.Parse(Console.ReadLine());

Console.WriteLine("Enter your chemistry result");
chemistry = Int32.Parse(Console.ReadLine());


if(math >= 90 && biology >= 90 && chemistry >= 90)
{
    Console.WriteLine("Congrats! You got acceepted");
}
else
{
    Console.WriteLine("Your applicatiopn cannot be approved");
}