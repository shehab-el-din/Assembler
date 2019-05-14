using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace turn_code_to_array
{
    class Program
    {
        static void Main(string[] args)
        {

            string[,] test = new string[,] { { "", "ORG", "100", "" }, { "", "LDA", "SUB", "" }, { "", "CMA", "", "" }, { "", "INC", "", "" }, { "", "ADD", "MIN", "" }, { "", "STA", "DIF", "" }, { "", "HLT", "", "" }, { "MIN,", "DEC", "83", "" }, { "SUB,", "DEC", "-23", "" }, { "DIF,", "HEX", "0", "" }, { "END", "", "", "" } };

            
            string[][] finalcode = new string[100][];
            Console.WriteLine("code hena");
            string[] code = new string[100];
            int q = 0;
            while ((code[q] = Console.ReadLine())!="END")
            {
                q++;
                
            }
            for (int i = 0; i < q; i++)
            {
            string []temp=new string[100];
                if (code[i].Contains("ORG"))
                {
                    temp[0] = "";
                    temp[1] = "ORG";
                    temp[2] = code[i].Substring(4);
                    temp[3] = "";
                    

                }
                else if (code[i].Contains("ADD") || code[i].Contains("AND") || code[i].Contains("LDA") || code[i].Contains("STA") || code[i].Contains("BUN") || code[i].Contains("BSA") || code[i].Contains("ISZ"))
                {
                    temp[0] = "";
                    temp[1] = code[i].Substring(0, 3);
                    if (code[i].Contains(" I"))
                    {
                        if (code[i].Length == 7)
                        {
                            temp[2] = code[i].Substring(4, 1);
                        }
                        else if (code[i].Length == 8)
                        {
                            temp[2] = code[i].Substring(4, 2);
                        }
                        else if (code[i].Length == 9)
                        {
                            temp[2] = code[i].Substring(4, 3);
                        }
                    }
                    else
                        temp[2] = code[i].Substring(4);

                    temp[3] = "";

                }
                else if (code[i].Contains(","))
                {
                    string[] temp2 = code[i].Split(',');
                    temp[0] = temp2[0]+",";
                    temp2 = temp2[1].Split(' ');
                    temp[1] = temp2[0] ;
                    temp[2] = temp2[1];
                    temp[3] = "";
                }
                else
                {
                    temp[0] = "";
                    temp[1] = code[i].Substring(0, 3);
                    temp[2] = "";
                    temp[3] = "";
                }
                
                finalcode[i] = temp;
            }


            for (int a = 0; a < q; a++)
                for (int j = 0; j < 4; j++)
                {
                    Console.WriteLine(finalcode[a][j]);
                   
                }
            Console.ReadKey();
        }
    }
}
