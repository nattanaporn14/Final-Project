using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class CSV
    {
        //ที่อยู่ของไฟล์
        private string path = @"D:\Natty\FinalProject\Final Project\final.csv";

        //ฟังก์ชันเขียนไฟล์
        public bool SavetoFile(string name, int hour, int Calculation )
        {
            //\n เอาไว้ขึ้นบรรทัดใหม่ (new line)
            string content = name + "," + hour + "," + Calculation+"\n";
            //หากเขียนไฟล์สำเร็จจะเป็น true
            try
            {
                File.WriteAllText(path, content);
                return true;
            }
            //หากเขียนไม่สำเร็จจะเป็น false
            catch 
            { 
                return false;
            }
        }
    }
}
