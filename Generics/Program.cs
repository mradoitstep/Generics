using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            TelefonnyZoznam telefonnyZoznam = new TelefonnyZoznam();
            telefonnyZoznam.AddStudent(new Student { TelCislo = "123654789", Meno = "Rado", RC = "852654" });
            telefonnyZoznam.AddStudent(new Student { TelCislo = "987456321", Meno = "Fero", RC = "741258" });
            telefonnyZoznam.AddStudent(new Student { TelCislo = "123654789", Meno = "Ivo", RC = "456987" });
            Student student = new Student();
            if(telefonnyZoznam.Find("123654789", out student))
            {
                Console.WriteLine(student.Meno);
                Console.WriteLine(student.TelCislo);

            }
            else
            {



            }
            GenericSmallStack<string> stringSmallStack = new GenericSmallStack<string>();
            stringSmallStack.Pop();

            Console.ReadLine();


        }
        
    }
}
