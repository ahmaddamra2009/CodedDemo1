// See https://aka.ms/new-console-template for more information

// Datatype Var-Name ;
string FirstName;
string LastName;

int num1, num2, sum;
num1 = 5;
num2 = 7;
sum = num1 + num2;
FirstName = "Ahmad";
LastName = "Damra";


string N1, N2, N3;
N1 = "3";
N2 = "4";
N3 = "5";

string Total = (Convert.ToInt32(N1) + Convert.ToInt32(N2) + Convert.ToInt32(N3)).ToString();


Console.WriteLine("Mr." + FirstName + " " + LastName + ", Your number is: "
    + sum);
Console.WriteLine("Total is: " + Total);

Console.WriteLine("------------------------------");

Console.Write("Enter Your Full Name: ");
string FullName = Console.ReadLine();

Console.Write("Enter City: ");
string City = Console.ReadLine();

Console.Write("Welcome " + FullName + " My city is: " + City);

Console.WriteLine("------------------------------");

Console.WriteLine("Enter Mark 1");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter Mark 2");
int m2 = Convert.ToInt32(Console.ReadLine());
int totMark = m1 + m2;
Console.Write("Total Marks: " + totMark);
Console.WriteLine("------------------------------");

Console.WriteLine("Enter Avg");
double avg = Convert.ToDouble(Console.ReadLine());
if (avg >= 50 && avg <= 100)
{
    Console.WriteLine("Pass");
}
else if (avg < 50 && avg >= 0)
{
    Console.WriteLine("Fail");
}
else
{
    Console.WriteLine("Out of range");
}