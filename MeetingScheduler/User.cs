using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace MeetingScheduler
{
  class User
  {
    private static int noOfUsers = 0;
    private int userID;
    private String firstName;
    private String lastName;
    public enum EmployeeType { systemAdmin = 0, equipmentKeeper = 1, meetingInitiator = 2, participant = 3 }
    private EmployeeType EmpType;
    private List<char> meetingList;
    private List<char> exclustionSet;
    private List<char> preferenceSet;
    public User(string fname, string lName, EmployeeType empType, char[] meetings, char[] exclude, char[] preference)
    {
      userID = noOfUsers++;
      firstName = fname;
      lastName = lName;
      EmpType = empType;

      meetingList = new List<char>();
      foreach (char c in meetings)
      {
                this.meetingList.Add(c);
      }
      exclustionSet= new List<char>();
      foreach (char c in exclude)
      {
        this.exclustionSet.Add(c);

      }
      preferenceSet = new List<char>();
      foreach (char c in preference)
      {
        this.preferenceSet.Add(c);
      }
    }

  }
}