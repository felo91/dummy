using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;


namespace prueba2_dummy
{
    class DBExcel
    {
        string path = "";
        Excel.Application excel = new Excel.Application();
        Excel.Workbook wb;
        Excel.Worksheet ws;

        public DBExcel(string path, int Sheet)
        {

            this.path = path;
            wb = excel.Workbooks.Open(path);
            ws = wb.Worksheets[Sheet];
        }


        public string[,] leerCeldas(int starti, int starty, int endi, int endy)
        {
            Excel.Range range = (Excel.Range) ws.Range[ws.Cells[starti, starty], ws.Cells[endi, endy]];
            object[,] holder = range.Value2;
            string[,] returnstring = new string[endi - starti+1, endy - starty+1];
            for (int p=1; p<= endi - starti; p++)
            {
                for (int q = 1; q <= endy - starty; q++)
                {
                    returnstring[p - 1, q - 1] = holder[p, q].ToString();
                }
            }
            return returnstring;
        }
        public string leerCelda(int i, int j)
        {
            i++;
            j++;
            if (ws.Cells[i, j].Value2 != null)
                return ws.Cells[i, j].Value2;
            else
                return null;
        }



        public void escribirCelda(int i, int j, string s)
        {
            i++;
            j++;
            ws.Cells[i, j].Value2 = s;
        }

        public void close()
        {
            wb.Close(0);
            excel.Quit();
            System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcessesByName("Excel");
            foreach (System.Diagnostics.Process p in process)
            {
                if (!string.IsNullOrEmpty(p.ProcessName))
                {
                    try
                    {
                        p.Kill();
                    }
                    catch { }
                }
            }
        }

        internal Seguros[] llenarSeguros()
        {
            int minY=39, minX=2, maxY=47, maxX=7;
            
            this.path = "C:\\05 - Proyectos\\JAI\\dummy\\recursos\\Eventos adversos.xlsx";
            this.ws = wb.Worksheets[3];

            Excel.Range range = (Excel.Range)ws.Range[ws.Cells[minY, minX], ws.Cells[maxY, maxX]];
            object[,] holder = range.Value2;

            Seguros[] seguros = new Seguros[9];

            //llena el nombre de cada seguro, su valor inicial e inicializa el nivel en 0
            //luego lleno el 
                for (int p = 1; p <= maxY - minY+1; p++)
                {
                    seguros[p - 1] = new Seguros();
                    seguros[p - 1].area = holder[p, 1].ToString();
                    //seguros[p - 1].costoProximo = Convert.ToInt16(holder[p, 2]);
                    seguros[p - 1].nivel = 0;
                    for (int q = 2; q <= maxX - minX+1; q++)
                    {
                        //seguros[p - 1].area = holder[p, q].ToString();
                        seguros[p - 1].costoProximo[q - 2] = Convert.ToInt32(holder[p, q]);
                        //returnstring[p - 1, q - 1] = holder[p, q].ToString();
                    }
                
                }

            //llena el seguro con los valores de la franquisia
            minY = 61;
            minX = 3;
            maxY = 69;
            range = ws.Range[ws.Cells[minY, minX], ws.Cells[maxY, maxX]];
            holder = range.Value2;
            for (int p = 1; p <= maxY - minY + 1; p++)
            {
                for (int q = 1; q <= maxX - minX + 1; q++)
                { 
                    seguros[p - 1].franquicia[q - 1] = Convert.ToInt32(holder[p, q]);
                }
            }

            //llena el seguro con los valores de la cobertura
            minY = 74;
            maxY = 82;
            range = ws.Range[ws.Cells[minY, minX], ws.Cells[maxY, maxX]];
            holder = range.Value2;
            for (int p = 1; p <= maxY - minY + 1; p++)
            {
                for (int q = 1; q <= maxX - minX + 1; q++)
                {
                    seguros[p - 1].cobertura[q - 1] = Convert.ToInt32(holder[p, q]);
                }
            }


            return seguros;
        }

        internal Gerentes[] llenarGerentes(string path)
        {
            int minY = 61, minX = 3, maxY = 69, maxX = 8;

            this.path = path;
            this.ws = wb.Worksheets[3];

            Excel.Range range = (Excel.Range)ws.Range[ws.Cells[minY, minX], ws.Cells[maxY, maxX]];
            object[,] holder = range.Value2;

            Gerentes[] gerentes = new Gerentes[9];

            //llena el nombre de cada seguro, su valor inicial e inicializa el nivel en 0
            //luego lleno el 
            for (int p = 1; p <= maxY - minY + 1; p++)
            {
                gerentes[p - 1] = new Gerentes();
                gerentes[p - 1].area = holder[p, 1].ToString();
                //seguros[p - 1].costoProximo = Convert.ToInt16(holder[p, 2]);
                gerentes[p - 1].nivel = 0;
                for (int q = 2; q <= maxX - minX + 1; q++)
                {
                    //seguros[p - 1].area = holder[p, q].ToString();
                    gerentes[p - 1].costoProximo[q - 2] = Convert.ToInt32(holder[p, q]);
                    //returnstring[p - 1, q - 1] = holder[p, q].ToString();
                }

            }

            //llena el seguro con los valores de la cobertura
            minY = 74;
            minX = 4;
            maxY = 82;
            range = ws.Range[ws.Cells[minY, minX], ws.Cells[maxY, maxX]];
            holder = range.Value2;
            for (int p = 1; p <= maxY - minY + 1; p++)
            {
                for (int q = 1; q <= maxX - minX + 1; q++)
                {
                    gerentes[p - 1].cobertura[q - 1] = Convert.ToInt32(holder[p, q]);
                }
            }


            return gerentes;
        }
    }
}
