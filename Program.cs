using System;

namespace EmployeeLeavesManagementSystem2
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Henry";
            string ID = "123456789";
            Console.WriteLine("WELCOME TO EMPLOYEE LEAVES PLAN MANAGEMENT!");


            int i = 0;
                for (; i < 3; i++)
                {


                    Console.Write("Please Enter Your Name: ");
                    string emplopyeeName = Console.ReadLine();

                    Console.Write("Please Enter Your Employees ID: ");
                    string employeesId = Console.ReadLine();

                if (emplopyeeName == name && employeesId == ID)
                {
                    
                    break;
                }
                else{
                    Console.WriteLine("Invalid Name or ID. Please try again");

                }
                
                }
            if (i == 3)
            {
                Console.WriteLine("Invalid input of Name or Emplopyees ID. System will exit....");
                Environment.Exit(0);
            }

            string[] departments;  //Declaration
            departments = new string[3] //Initialization
            { "Production", "Research and Development", "Purchasing" }; //Pupulation
                Console.WriteLine("(Production),(Research and Development),(Purchasing)");
                Console.Write("Please Choose What Your Department is: ");
                string employeesDepartment = Console.ReadLine();


            var choicesOfPlan = new[] { "Yes", "No" }; //Declaration,Initialization,Pupulation
                Console.WriteLine("Plan on leaving? Please Enter Yes or No");
                Console.Write("Enter Here: ");
                string choiceAnswer = Console.ReadLine();



                if (choiceAnswer == choicesOfPlan[0]&& (employeesDepartment == departments[0] || employeesDepartment == departments[1] || employeesDepartment == departments[2]))
                {
                    Console.WriteLine("When do you plan on leaving? The Format Must be YY-MM-DD.");
                    DateTime dateOfPlan = Convert.ToDateTime(Console.ReadLine());
       

                    if (dateOfPlan != null)
                    
                    {
                    string[] reasons; //Declaration
                    reasons = new string[3] //Initialization
                    {"Maternity","Paternity","Parental" }; //Pupulation

                        Console.WriteLine("PLEASE INDICATE YOUR REASON OF LEAVE:");
                        Console.WriteLine("Choose Whether it is Maternity, Paternity, Parental");
                        string leaveReason = Console.ReadLine();
                        if (leaveReason == reasons[0] || leaveReason == reasons[1] || leaveReason == reasons[2])
                        {
                        var information = new[] {"EMPLOYEE LEAVE REGISTERED","YourName: "+name,"Your ID: "+ID,"Your Department: "+employeesDepartment,
                        "Your Reason of Leave: "+leaveReason,"Your Leave Date: "+dateOfPlan,"Thankyou!"+name };
                        var currDateTime = DateTime.Now;
                        Console.WriteLine("THE CURRENT DATE AND TIME IS: ");
                        Console.WriteLine(currDateTime.ToLongDateString());

                        foreach (var infodisplay in information)
                        {
                            Console.WriteLine($"{infodisplay}");
                        }
                        }
                    }
                }
                else if (choiceAnswer == choicesOfPlan[1])
                {
                    Console.WriteLine("Thankyou System will Exit!");
                }
                else if (choiceAnswer != choicesOfPlan[0] ||choiceAnswer !=choicesOfPlan[1]|| employeesDepartment != departments[0] || employeesDepartment != departments[1] || employeesDepartment != departments[2])
                {
                    Console.WriteLine("Invalid Information Please Check Again");
                }
        }

    }
}
