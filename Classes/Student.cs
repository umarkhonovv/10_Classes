using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace src;

public class Student
{
    public string Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public int Course { get; set; }
    public int Scholarship { get; set; }


    public void DisplayInfo()
    {
        var result = $"Id : {Id}  Name : {Name}  Age : {Age}  Course : {Course}  Scholarship : {Scholarship}";
        Console.Write(result);
    }

}
