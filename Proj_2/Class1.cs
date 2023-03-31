using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _Курсовая_Длл
{
    public class Class1
    {
        public static int[] arr = new int[16];
        public static void pravilno(int nomer, int otvet)
        {
            arr[nomer] = otvet;
        }
        public static void metod1(int nomer, string rite_ans,string ans)
        {
            if(ans == rite_ans)
            {
                MessageBox.Show("Вы ответили верно!");
                pravilno(nomer, 1);
            }
            else
            {
                MessageBox.Show("Вы ответили не верно!");
                pravilno(nomer, 0);
            }
        }
       /* public static void metod2(int nomer, string rite_ans, string ans)
        {
            /*string summ = "";
            for (int i = 1; i < 7; i++)
            {
                checkBox1 + i;
            }
            if (ans == rite_ans)
            {
                MessageBox.Show("Вы ответили верно!");
                pravilno(nomer, 1);
            }
            else
            {
                MessageBox.Show("Вы ответили не верно!");
                pravilno(nomer, 0);
            }
        }*/
        public static string Tbox(TextBox t)
        {
            return t.Text;
        }
        public static string case_(int nomer)
        {
            if (nomer == 1)
            {
                return "Мультипрограммирование"; 
            }
            else if (nomer == 2)
            {
                return "Solaris";
            }
            else if (nomer == 3)
            {
                return "1356";
            }
            else if (nomer == 4)
            {
                return "1235";
            }
            else if (nomer == 5)
            {
                return "4";
            }
            else if (nomer == 6)
            {
                return "";
            }
            else if (nomer == 7)
            {
                //2)а
                //3)г
                //1)в
                //4)б
                return "";
            }
            else if (nomer == 8)
            {
                return "";
            }
            else if (nomer == 9)
            {
                return "3) Оперативная память";
            }
            else if (nomer == 10)
            {
                return "RISC";
            }
            else if (nomer == 11)
            {
                return "2006";
            }
            else if (nomer == 12)
            {

                return "";
            }
            else if (nomer == 13)
            {

                return "";
            }
            else if (nomer == 14)
            {

                return "";
            }
            else if (nomer == 15)
            {

                return "";
            }
            else if (nomer == 16)
            {

                return "";
            }
            else
            {
                return nomer.ToString();
            }
        }

    }
}
