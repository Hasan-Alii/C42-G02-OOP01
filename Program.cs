using System.Security.Cryptography;

namespace C42_G02_OOP01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Part 1
            //========================== Q_1 ==========================
            /*Point p1;
            p1= new Point(1,1);
            //distance between any 2 points is space: d=√((x2 – x1)² + (y2 – y1)²)

            static double distance(Point p1, Point p2)
            {
                return Math.Sqrt(Math.Pow((p1.x - p2.x), 2) +
                    Math.Pow((p2.y - p1.y), 2));
            }

            //test for points (4, 2) and (6, 9)
            Console.WriteLine(distance(new Point(4, 2), new Point(6, 9)));
            */


            //========================== Q_2 ==========================
            /*static Person OldestPerson(Person p1, Person p2, Person p3)
            {
                //int maxAge;
                //string maxName;
                if (p1.age >= p2.age)
                {
                    return p1;
                    //maxName = p1.name;
                    //maxAge = p1.age;
                }
                else if(p2.age >= p3.age)
                {
                    return p2;
                    //maxName = p2.name;
                    //maxAge = p2.age;
                }
                else
                {
                    return p3;
                    //maxName = p3.name;
                    //maxAge = p3.age;
                }
                //Console.WriteLine($"the oldest person's name: {maxName}, and age: {maxAge}");
                //Console.WriteLine(Math.Max(p1.Age, Math.Max(p3.Age, p2.Age)));
            }

            Console.WriteLine(OldestPerson(new Person("Hasan", 22), new Person("Taro2a", 23), new Person("Akram", 23)).ToString());
            */
            #endregion

            #region Part 2
            //========================== Q_1 ==========================
            /*Employee emp1;
            emp1 = new Employee(1, "Hasan", SecPriv.Developer, 1500.73, new DateOnly(2000,10,20), true);
            Console.WriteLine(emp1.ToString());
            Console.WriteLine(emp1.Id);
            Console.WriteLine(emp1.Name);
            Console.WriteLine(emp1.Priv);
            Console.WriteLine(emp1.HireDate);
            Console.WriteLine(emp1.IsMale);
            */


            //========================== Q_2 ==========================
            /*class created and used in Q_3
             */

            //========================== Q_3 ==========================
            /*Employee[] EmpArr = {
            new Employee(1, "Hasan", SecPriv.DBA, 1500.73, new HireDate(2000, 02, 30), true),
            new Employee(2, "Tarek", SecPriv.guest, 250.53, new HireDate(2011, 06, 23), true),
            new Employee(3, "Aya", SecPriv.securityOfficer, 1600.3, new HireDate(2008, 01, 11), false),
            };
            foreach (Employee emp in EmpArr) {
                Console.WriteLine(emp);
                Console.WriteLine();
            }
            */


            //========================== Q_4 ==========================
            /*Employee[] EmpArr = {
            new Employee(1, "Hasan", SecPriv.DBA, 1500.73, 
            new HireDate(2000, 02, 30), true),
            new Employee(2, "Tarek", SecPriv.guest, 250.53, 
            new HireDate(2011, 06, 23), true),
            new Employee(3, "Aya", SecPriv.securityOfficer, 1600.3, 
            new HireDate(2008, 01, 11), false),
            };

            foreach (Employee emp in EmpArr) {
                Console.WriteLine(emp);
                Console.WriteLine();
            }
            
            static void OldestEmployee(Employee e1, Employee e2, Employee e3)
            {
                Employee max;
                Employee min;

                Employee[] arr = new Employee[3];
                if (e1.HireDate.Year >= e2.HireDate.Year)
                {
                    if (e1.HireDate.Month >= e2.HireDate.Month)
                    {
                        if (e1.HireDate.Day >= e2.HireDate.Day)
                        {
                            arr[0] = e1;
                            arr[1] = e2;
                            arr[2] = e3;
                        }
                    }
                }
                else if (e2.HireDate.Year >= e3.HireDate.Year)
                {
                    if (e2.HireDate.Month >= e3.HireDate.Month)
                    {
                        if (e2.HireDate.Day >= e3.HireDate.Day)
                        {
                            arr[0] = e2;
                            arr[1] = e3;
                            arr[2] = e1;
                        }
                    }
                }
                else
                {
                    //max = e3;
                    //min = e1;
                    arr[0] = e3;
                    arr[1] = e2;
                    arr[2] = e1;
                }

                foreach (Employee emp in arr)
                {
                    Console.WriteLine(emp);
                }
                //Console.WriteLine($"the oldest person's name: {maxName}, and age: {maxAge}");
                //Console.WriteLine(Math.Max(p1.Age, Math.Max(p3.Age, p2.Age)));
            }*/
            #endregion

        }

    }
}
