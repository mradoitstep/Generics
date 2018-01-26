using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class TelefonnyZoznam
    {
        Dictionary<string, Student> zoznam = new Dictionary<string, Student>();

        public void AddStudent(Student student)
        {
            try
            {

                zoznam.Add(student.TelCislo, student);

            }
            // odchytenie vynimky pokial sa nepodar9 pridat kluc do dictonary - duplicitu 

            catch(Exception exception)
            {
                Console.WriteLine(exception.ToString());
            }
            
        }
        public bool Find(string telCislo,out Student student)
        {
            return zoznam.TryGetValue(telCislo, out student);

        }
       

    }
}
