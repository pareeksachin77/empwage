// See https://aka.ms/new-console-template for more information
using EmpWays;

Console.WriteLine("Hello, World!");

//uc1 obj1 = new uc1();
//obj1.empwage1();

//uc2 obj2 = new uc2();
//obj2.empwage2();

//if we use static with function then we can call directly without creationg object of class
//uc3.empwage3();

//uc4.empwage4();
//uc5.empwage5();

//uc8.empwage8("TCS", 200, 25, 120);
//uc8.empwage8("Wipro", 300, 20, 130);

uc9 dmart = new uc9("dmart",20,20,100);
uc9 reliance = new uc9("reliance", 30, 22, 120);
dmart.computeWage();
Console.WriteLine(dmart.ToString());
reliance.computeWage();
Console.WriteLine(reliance.ToString());