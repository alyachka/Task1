using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Circle
{
    public class InOutFile
    {
        public Round[] Input(string str)
        {
            Round[] ar = null;
            Round rnd = new Round();
            using (StreamReader fileIn = new StreamReader(str))
            {
                int n;
                if(int.TryParse(fileIn.ReadLine(), out n))
                {
                    ar = new Round[n];
                    
                    for (int i = 0; i < n; i++)
                    {
                        string[] text = fileIn.ReadLine().Split(' ');
                        double x;
                        double y;
                        double radius;
                        Point Center = null;
                        double Radius;

                        if (double.TryParse(text[0], out x) && double.TryParse(text[1], out y) && double.TryParse(text[2], out radius))
                        {
                            Center = new Point(x, y);
                            Radius = radius;
                        }
                        else
                        {
                            throw new ArgumentException("Wrong parametr.");
                        }
                        


                    }
                }
                return ar;


            }
        }

        public void Output(Round[] ar)
        {
            using (StreamWriter fileOut = new StreamWriter("output.txt"))
            {
                foreach(Round item in ar)
                {
                    fileOut.WriteLine("Радиус = {0}", item.Radius);
                    fileOut.WriteLine("Координаты центра окружности: ({0},{1})", item.Center.x, item.Center.y);
                    fileOut.WriteLine("Площадь окружности: ", item.RoundArea);
                    fileOut.WriteLine("Длина окружности: ", item.Roundference);
                   
                    fileOut.WriteLine();
                }
            }
        }

    }
}
