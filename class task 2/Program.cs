// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

Console.WriteLine("Enter your weight ");
double weight = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Enter your height");
double height = Convert.ToDouble(Console.ReadLine());
double bmi = weight / Math.Pow(height, 2) / 100;
string bmistate = ""; 
Console.WriteLine("your bmi is");


Console.WriteLine("Enter BMI");

if (bmi < 18.5)
{
    bmistate = "underweight";
    
}
else if (bmi >= 18.5 && bmi <= 24.9)
{
    bmistate = "healthy";
    

}

else if (bmi >= 25 && bmi <= 29.9)
{
    bmistate = "overweight";
    

}
else  {

    bmistate = "overweight";



}

Console.WriteLine("Enter your age");
int age = Convert.ToInt32(Console.ReadLine());

    if (age>=19 &&age<=24 &&  bmi>=19 && bmi<=24)
{
    bmistate ="healthy" ;
    

}
    else if  (age>=25  && age <=34 && bmi>= 20&& bmi <=25)

{
    bmistate= "healthy";

}
    else if (age>=35 && age <= 44 && bmi>= 21 && bmi <=26)
{
    bmistate ="healthy";
}
    else if(age>=45 && age  <= 54 && bmi>= 22 && bmi<= 27)
{
    bmistate = "healthy";

}
    else if (age>=55 && age <=64  && bmi >= 23 && bmi<= 28){
    bmistate  ="healthy";
}
    else if (age>=65 && bmi >=24 && bmi <= 29){

    bmistate ="healthy";
}
