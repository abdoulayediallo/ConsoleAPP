using System.Linq;
using Excel = Microsoft.Office.Interop.Excel;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(@"C:\Users\abdia\Desktop\Docs\C.P. BOURG\DATA\Test\SAP_FOURNISSEURS_CSV.xlsx"); 
            xlApp.Visible = false;
            foreach (Excel.Worksheet sht in xlWorkBook.Worksheets)
            {
                sht.Select();
                xlWorkBook.SaveAs(string.Format("{0}{1}.csv", "C:\\Users\\abdia\\Desktop\\Docs\\C.P. BOURG\\DATA\\Test\\", sht.Name), Excel.XlFileFormat.xlCSV, Excel.XlSaveAsAccessMode.xlNoChange);
            }
            xlWorkBook.Close(false);
          
        }
    }
}