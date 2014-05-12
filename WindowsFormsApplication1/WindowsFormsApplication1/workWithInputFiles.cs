using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace WindowsFormsApplication1
{
    class workWithInputFiles
    {
        StreamReader strRead = new StreamReader("input.txt");
        void readInfo()
        {
            

            if (strRead.ReadLine() == "True")
            {
                Settings1.Default.wantToSave = true;
            }
            else
            {
                Settings1.Default.wantToSave = false;
                Settings1.Default.token = "";
                Settings1.Default.id = "";
                Settings1.Default.auth = false;
            }

        }

        void writeAnsFor_First_q(string ans) //запись в файл ответа на вопрос о сохранении данных пользователя
        {
            StreamWriter strWrite = new StreamWriter("input.txt");
            strWrite.Write(ans.ToString());
        }
    }
}
