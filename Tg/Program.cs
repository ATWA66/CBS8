Console.Write("enter the sum of credit\n");
double creditSum = Convert.ToInt32(Console.ReadLine());
Console.Write("enter the percent\n");
int percent = Convert.ToInt32(Console.ReadLine());
double overpay = 0;
double overpay1;
int sum=0;
credit(sum);
void credit(int sum)
{
    if (creditSum > 0)
    {
        Console.WriteLine("the sum of credit is " + creditSum);
        Console.WriteLine("enter the sum( shoud be >= 100)");
        sum = Convert.ToInt32(Console.ReadLine());
        if (sum < 100)
        {
            Console.WriteLine("you have entered not inafe money");
            credit(sum);
        }
        else
        {
            overpay += (creditSum /100 * percent);
            overpay1 = (creditSum / 100 * percent);
            Console.WriteLine("your overpay is {0} in total", overpay);
            creditSum += overpay1 - sum;
            credit(sum);
        }
    }
    else
    {
        Console.WriteLine("you have fineshed this credit!");
    }
}
