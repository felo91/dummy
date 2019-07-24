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
        Excel._Workbook wb;
        Excel._Worksheet ws;

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
            wb.Close();
        }

        internal Seguros[] llenarSeguros()
        {
            int minY=39, minX=2, maxY=47, maxX=3;
            
            this.path = "C:\\05 - Proyectos\\JAI\\dummy\\recursos\\Eventos adversos.xlsx";
            this.ws = wb.Worksheets[3];

            Excel.Range range = (Excel.Range)ws.Range[ws.Cells[minY, minX], ws.Cells[maxY, maxX]];
            object[,] holder = range.Value2;

            Seguros[] seguros = new Seguros[8];
            //string[,] returnstring = new string[endi - starti + 1, endy - starty + 1];
            for (int p = 1; p <= maxY - minY; p++)
            {
                seguros[p - 1] = new Seguros();
                seguros[p - 1].area = holder[p, 1].ToString();
                seguros[p - 1].costoProximo = Convert.ToInt16(holder[p, 2]);
                seguros[p - 1].nivel = 0;
                /*for (int q = 1; q <= maxX - minX; q++)
                {
                    //seguros[p-1].area= holder[p, q].ToString()
                    //returnstring[p - 1, q - 1] = holder[p, q].ToString();
                }*/
            }

            return seguros;
        }
    }
}
