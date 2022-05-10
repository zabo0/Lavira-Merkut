using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelApp = Microsoft.Office.Interop.Excel;

namespace Lavira_Merkut
{
    class Simulation
    {
        ArrayList velocity = new ArrayList();
        ArrayList velocityX = new ArrayList();
        ArrayList velocityZ = new ArrayList();
        ArrayList altitude = new ArrayList();
        ArrayList locationX = new ArrayList();
        ArrayList locationY = new ArrayList();
        ArrayList temperature = new ArrayList();
        ArrayList moisture = new ArrayList();
        ArrayList accelerationX = new ArrayList();
        ArrayList accelerationY = new ArrayList();
        ArrayList accelerationZ = new ArrayList();


        public Simulation()
        {
            getDataFromExcel();
        }

        public ArrayList Velocity { get => velocity; set => velocity = value; }
        public ArrayList VelocityX { get => velocityX; set => velocityX = value; }
        public ArrayList VelocityZ { get => velocityZ; set => velocityZ = value; }
        public ArrayList Altitude { get => altitude; set => altitude = value; }
        public ArrayList LocationX { get => locationX; set => locationX = value; }
        public ArrayList LocationY { get => locationY; set => locationY = value; }
        public ArrayList Temperature { get => temperature; set => temperature = value; }
        public ArrayList Moisture { get => moisture; set => moisture = value; }
        public ArrayList AccelerationX { get => accelerationX; set => accelerationX = value; }
        public ArrayList AccelerationY { get => accelerationY; set => accelerationY = value; }
        public ArrayList AccelerationZ { get => accelerationZ; set => accelerationZ = value; }

        public void getDataFromExcel()
        {
            //Create COM Objects.
            ExcelApp.Application excelApp = new ExcelApp.Application();

            if (excelApp == null)
            {
                Console.WriteLine("Excel is not installed!!");
                return;
            }

            ExcelApp.Workbook excelBook = excelApp.Workbooks
                .Open(@"C:\Users\Sabahattin\Desktop\Lavira Rocket\documents\ucus benzetim raporlari\reports\LaviraKTRUcusBenzetimCiktilari.xlsx");
            ExcelApp._Worksheet excelSheet = excelBook.Sheets[1];
            ExcelApp.Range excelRange = excelSheet.UsedRange;

            //int rows = excelRange.Rows.Count;
            //int cols = excelRange.Columns.Count;

            //int rows = excelRange.Rows.Count - 1;
            int rows = 2530;
            int colX = 3;
            int colVz = 7;

            //dataGridView1.RowCount = rows;
            //dataGridView1.ColumnCount = cols;

            for (int i = 2; i <= rows; i++)
            {
                //write to cell
                if (excelRange.Cells[i, colX] != null && excelRange.Cells[i, colX].Value2 != null)
                {
                    altitude.Add(excelRange.Cells[i, colX].Value2);
                }

                //write to cell
                if (excelRange.Cells[i, colVz] != null && excelRange.Cells[i, colVz].Value2 != null)
                {
                    velocityZ.Add(excelRange.Cells[i, colVz].Value2);
                }
            }


            //after reading, relaase the excel project
            excelApp.Quit();
            System.Runtime.InteropServices.Marshal.ReleaseComObject(excelApp);
        }
    }



        //OPEN STREET MAp
}
