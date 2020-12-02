using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MeetingScheduler
{
  static class Program
  {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread] 
    static void Main()
    {
      Meeting[,] MeetingSlots = new Meeting[6, 4];
      //Application.EnableVisualStyles();
      //Application.SetCompatibleTextRenderingDefault(false);
      //Application.Run(new Form1());
      char[] meetings = { 'a','c','d'};
      User testUser = new User("Mazen","Omar", User.EmployeeType.systemAdmin,meetings, meetings, meetings);
      User testUser2 = new User("Mazen", "Omar", User.EmployeeType.systemAdmin, meetings, meetings, meetings);
      User testUser33 = new User("Mazen", "Omar", User.EmployeeType.systemAdmin, meetings, meetings, meetings);

            


      Console.WriteLine("hello world");

            
    }
  }
}
