using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDesignation
{
    public class UserProgramCode
        {
            public static string[] getEmployee(string[] input1, string input2)
            {
                int count = 0;
                string[] employees = new string[input1.Length / 2];
                input2 = input2.ToLower(); 

                
                for (int i = 0; i < input1.Length; i += 2)
                {
                    string employeeName = input1[i];
                    string designation = input1[i + 1].ToLower();

                    if (designation == input2)
                    {
                        employees[count++] = employeeName;
                    }
                }

               
                string[] result = new string[count];
                for (int i = 0; i < count; i++)
                {
                    result[i] = employees[i];
                }

                return result;
            }
        }
    }
