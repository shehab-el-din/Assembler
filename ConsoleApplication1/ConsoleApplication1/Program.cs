using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            int PC = -1;

            string[][] functions = new string[27][];
            functions[0] = new string[2];
            functions[1] = new string[2];
            functions[2] = new string[2];
            functions[3] = new string[2];
            functions[4] = new string[2];
            functions[5] = new string[2];
            functions[6] = new string[2];
            functions[7] = new string[2];
            functions[8] = new string[2];
            functions[9] = new string[2];
            functions[10] = new string[2];
            functions[11] = new string[2];
            functions[12] = new string[2];
            functions[13] = new string[2];
            functions[14] = new string[2];
            functions[15] = new string[2];
            functions[16] = new string[2];
            functions[17] = new string[2];
            functions[18] = new string[2];
            functions[19] = new string[2];
            functions[20] = new string[2];
            functions[21] = new string[2];
            functions[22] = new string[2];
            functions[23] = new string[2];
            functions[24] = new string[2];
            functions[25] = new string[2];
            functions[26] = new string[2];


            functions[0][0] = "AND";
            functions[0][1] = "08";

            functions[1][0] = "ADD";
            functions[1][1] = "19";

            functions[2][0] = "LDA";
            functions[2][1] = "2A";

            functions[3][0] = "STA";
            functions[3][1] = "3B";

            functions[4][0] = "BUN";
            functions[4][1] = "4C";

            functions[5][0] = "BSA";
            functions[5][1] = "5D";

            functions[6][0] = "ISZ";
            functions[6][1] = "6E";

            functions[7][0] = "CLA";
            functions[7][1] = "7800";

            functions[8][0] = "CLE";
            functions[8][1] = "7400";

            functions[9][0] = "CMA";
            functions[9][1] = "7200";

            functions[10][0] = "CME";
            functions[10][1] = "7100";

            functions[11][0] = "CIR";
            functions[11][1] = "7080";

            functions[12][0] = "CIL";
            functions[12][1] = "7040";

            functions[13][0] = "INC";
            functions[13][1] = "7020";

            functions[14][0] = "SPA";
            functions[14][1] = "7010";

            functions[15][0] = "SNA";
            functions[15][1] = "7008";

            functions[16][0] = "SZA";
            functions[16][1] = "7004";

            functions[17][0] = "SZE";
            functions[17][1] = "7002";

            functions[18][0] = "HLT";
            functions[18][1] = "7001";

            functions[19][0] = "INP";
            functions[19][1] = "F800";

            functions[20][0] = "OUT";
            functions[20][1] = "F400";

            functions[21][0] = "SKI";
            functions[21][1] = "F200";

            functions[22][0] = "SKO";
            functions[22][1] = "F100";

            functions[23][0] = "ION";
            functions[23][1] = "F080";

            functions[24][0] = "IOF";
            functions[24][1] = "F040";

            functions[25][0] = "DEC";


            functions[26][0] = "HEX";




            // string[,] test = new string[,] { { "", "ORG", "100", "" }, { "", "LDA", "SUB", "" }, { "", "CMA", "", "" }, { "", "INC", "", "" }, { "", "ADD", "MIN", "" }, { "", "STA", "DIF", "" }, { "", "HLT", "", "" }, { "MIN,", "DEC", "83", "" }, { "SUB,", "DEC", "-23", "" }, { "DIF,", "HEX", "0", "" }, { "END", "", "", "" } };
            Console.WriteLine("Enter your code");

            //code for array here

            string[][] finalcode = new string[100][];
            string[] code = new string[100];
            int q = 0;
            while ((code[q] = Console.ReadLine()) != "END")
            {
                q++;

            }
            for (int i = 0; i < q; i++)
            {
                string[] temp = new string[100];
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
                    temp[3] = "";
                    temp[1] = code[i].Substring(0, 3);
                    if (code[i].Contains(" I"))
                    {
                        temp[3] = " I";
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
                        else Console.WriteLine("label error in line" + q);
                    }
                    else {
                        if (code[i].Length > 7)
                        {
                            Console.WriteLine("label error in line" + q);
                        }
                        else
                        {
                            temp[2] = code[i].Substring(4);
                            if (temp[2].Length > 3)
                                Console.WriteLine("label error in line" + q);
                        }
                    }

                }
                else if (code[i].Contains(","))
                {
                    string[] temp2 = code[i].Split(',');
                    temp[0] = temp2[0] + ",";
                    temp2 = temp2[1].Split(' ');
                    temp[1] = temp2[0];
                    temp[2] = temp2[1];
                    temp[3] = "";
                }
                else
                {
                    if (code[i].Length != 3)
                        Console.WriteLine("wrong lable usage in line" + q);
                    temp[0] = "";
                    temp[1] = code[i].Substring(0, 3);
                    temp[2] = "";
                    temp[3] = "";
                }

                finalcode[i] = temp;
            }
            string[] temp0 = new string[4];
            temp0[0] = "";
            temp0[1] = "END";
            temp0[2] = "";
            temp0[3] = "";
            finalcode[q] = temp0;
            q++;
            //code is done


            int n;
            if (finalcode[0][1] != "ORG")
                Console.WriteLine("Initialization ERROR (check ORG )");

            if (!int.TryParse((finalcode[0][2]), out n))
                Console.WriteLine("Initialization ERROR (check start location)");
            else
                PC = int.Parse(finalcode[0][2]);

            ArrayList testlable = new ArrayList();
            ArrayList lable = new ArrayList();

            for (int x = 1; x < q; x++)
            {
                for (int y = 0; y < 7; y++)
                {
                    if (functions[y][0] == finalcode[x][1])
                    {
                        string temp = finalcode[x][2];
                        if (temp != null)
                        {
                            testlable.Add(temp + ",");//
                            if (int.TryParse((temp.Substring(0, 1)), out n))
                                Console.WriteLine("lables cant start with numbers error in line " + (x + 1));
                        }
                    }
                }




            }

            for (int x = 1; x < q; x++)//lable test
            {

                if (finalcode[x][0] == "")
                {

                    continue;
                }
                else if (testlable.Contains(finalcode[x][0]))
                {
                    string temp = finalcode[x][0];

                    testlable.Remove(finalcode[x][0]);
                    continue;
                }
                else
                {

                    Console.WriteLine("error in line:" + x + "check lable");
                }

                bool found = false;
                for (int y = 0; y < functions.GetLength(0); y++)
                {
                    if (functions[y][0] == finalcode[x][1])
                    {
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("error in line:" + x);

                }
            }
            if (testlable.Count != 0)
            {
                Console.WriteLine("lables with no value " + testlable.Count);

            }

            Console.WriteLine("");
            Console.WriteLine("FIRST PASS");
            Console.WriteLine("");

            ArrayList ad = new ArrayList();
            for (int i = 1; i < q; i++)//First pass
            {
                if (finalcode[i][1] == "END")
                    break;
                if (finalcode[i][0] != "")
                {
                    string temp = finalcode[i][0];
                    lable.Add(temp + "   " + PC);
                    ad.Add(PC);
                    PC++;
                }
                else PC++;
            }
            foreach (string a in lable)
                Console.WriteLine(a);

            int cnt = 0;
            //SECOND PASS
            Console.WriteLine("");
            Console.WriteLine("SECOND PASS");
            Console.WriteLine("");

            for (int m = 0; m < q; m++)
            {
                for (int u = 0; u < 25; u++)
                {
                    if (finalcode[m][1] == functions[u][0])
                    {
                        if (u < 7)
                            if (finalcode[m].Contains(" I"))
                            {
                                Console.WriteLine(functions[u][1].Substring(1, 1) + ad[cnt]);
                                cnt++;
                            }
                            else {
                                Console.WriteLine(functions[u][1].Substring(0, 1) + ad[cnt]);
                                cnt++;
                            }
                        else
                            Console.WriteLine(functions[u][1]);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}