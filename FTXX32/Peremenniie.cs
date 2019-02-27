using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FTXX32
{
    //Место, через которые все формы будут общаться друг с другом
    //Статический класс всегда присутствует в памяти
    static class Peremenniie 
    {
        public static string curItem = "";
        static public UInt32 NumberFt;
    }
}
