using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tpts
{
    class Program
    {
        static void Main(string[] args)
        {
            string nap="";
            string pan = "";
            char[] ans = new char[nap.Length];
            string[,] ppt = new string[26, 26];

            using (StreamReader reader = new StreamReader(@"C:\abc\pol.txt",Encoding.Default))
            {
                nap = reader.ReadToEnd();
            }
            using (StreamReader reader = new StreamReader(@"C:\abc\ang.txt", Encoding.Default))
            {
                pan = reader.ReadToEnd();
            }
            Array.Resize(ref ans,nap.Length);
            for(int i=0;i<nap.Length;i++)
            {               
                ans[i] = nap[i];
            }
            Wyk(ans);
            WygBigra(ppt);

              foreach(string d in ppt)
              {
                  Console.Write(d+"\t");
              }
            Console.ReadKey();
            Console.WriteLine("\n{0}",SprawdzTxtBigram(nap,ppt));
            Console.WriteLine(SprawdzTxtBigram(pan,ppt));


            Console.ReadKey();
        }
        public static void Wyk(char[] ans)
        {
            for (int i = 0; i < ans.Length; i++)
            {
                if (ans[i] == 'ó')
                    ans[i] = 'o';
                if (ans[i] == 'Ó')
                    ans[i] = 'O';
                if (ans[i] == 'ą')
                    ans[i] = 'a';
                if (ans[i] == 'Ą')
                    ans[i] = 'A';
                if (ans[i] == 'ę')
                    ans[i] = 'e';
                if (ans[i] == 'Ę')
                    ans[i] = 'E';
                if (ans[i] == 'Ż')
                    ans[i] = 'Z';
                if (ans[i] == 'ż')
                    ans[i] = 'z';
                if (ans[i] == 'Ź')
                    ans[i] = 'Z';
                if (ans[i] == 'ź')
                    ans[i] = 'z';
                if (ans[i] == 'Ł')
                    ans[i] = 'L';
                if (ans[i] == 'ł')
                    ans[i] = 'l';
                if (ans[i] == 'ć')
                    ans[i] = 'c';
                if (ans[i] == 'Ć')
                    ans[i] = 'C';
                if (ans[i] == 'Ś')
                    ans[i] = 'S';
                if (ans[i] == 'ś')
                    ans[i] = 's';
                if (ans[i] == 'Ń')
                    ans[i] = 'N';
                if (ans[i] == 'ń')
                    ans[i] = 'n';
            }
        }

        public static void WygBigra(string[,] ppt)
        {
            char ttsp = 'a';
            char ddsp = 'a';
            string ttmp = "";
            ppt[0, 0] = (ttsp+ddsp).ToString();
            for(int i=0;i<26;i++)
            {
                for(int j=0;j<26;j++)
                {
                    ttmp = ttsp + ddsp.ToString();
                    ppt[i, j] = ttmp;
                    ddsp = (char)++ddsp;
                }
                ttsp = (char)++ttsp;
                ddsp = 'a';
            }
        }

        public static int SprawdzTxtBigram(string o,string[,] ppt)
        {
            string stt = "";
            char t = ' ';
            char dt = ' ';
            int chck = 0;
            for(int i=0;i< 26; i++)
            {
                for(int j=0;j<26;j++)
                {
                    stt=ppt[i,j];
                    t = stt[0];
                    dt = stt[1];
                    for(int k=0;k<o.Length-1;k++)
                    {
                        if((o[k]==t)&&(o[k+1]==dt))
                        {
                            chck++;
                        }
                    }
                }             
            }
            return chck;
        }
    }
}

