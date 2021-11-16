using System;

class Faculty : Person
{
  private int lengthofemployment;

  //auto-implemented properties
  public string Id {get; set;}
  public string Title {get; set;}
  public string Employer {get; set;}
  public double YearlySalary {get; set;}
  public bool Tenure {get; set;}
  public DateTime DateOfEmployment {get; set;}
    

  //constructors
  public Faculty () : base()
  {
    Console.WriteLine("faculty constructor");
    Title="Instructor";
  }
  public Faculty (string fname, string lname) : base(fname, lname)
  {
    Title="Instructor";
    Console.WriteLine("faculty constructor");
  }
  public Faculty (string title)
  {
    Title = title;
    Console.WriteLine("faculty constructor");

  }

  //methods
  public void GrantTenure()
  {
    if (lengthofemployment >=5)
    {Tenure=true; 
    Console.WriteLine("Tenure Granted");}
    else
    Tenure=false;
  }
  public void Promote()
  {
    if ((Title =="Instructor") &&  (lengthofemployment>=2))
    {
      Title="Assistant Professor";
      Console.WriteLine("Faculty promoted to Assistant Professor rank.");
    }
    else if((Title=="Assistant Professor")&&(lengthofemployment>=5))
    {
      Title="Associate Professor";
      Console.WriteLine("Faculty promoted to Associate Professor rank.");
    }
    else if ((Title=="Associate Professor")&&(lengthofemployment>=10))
    {
      Title="Professor";
      Console.WriteLine("Faculty promoted to Professor rank.");
    }
    else if (Title=="Professor")
    {
      Console.WriteLine("No more promotion possible.");
    }
  }
  public override void Intro()
  {
    base.Intro();
    Console.WriteLine("I work as "+Title+" at "+Employer+" since "+ DateOfEmployment);
  }
  public void LengthOfEmployment()
  {
    lengthofemployment = DateTime.Now.Year - DateOfEmployment.Year;
    Console.WriteLine("Length of employment = "+lengthofemployment);
  }

  
}