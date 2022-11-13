using NPOI.SS.UserModel;
using Syncfusion.DocIO.DLS;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using DAL;
using System.Threading;
using System.Globalization;
using Syncfusion.XlsIO;

namespace BLL
{
    public class Reports<T>
    {
        private bool _IsPringPriview = false;
        private static Syncfusion.XlsIO.IWorkbook workbook;
        private static WordDocument document;

        private static void PrinPriview_Excel(string fileToPrint)
        {
            if (string.IsNullOrEmpty(fileToPrint))
            {
                return;
            }

            Microsoft.Office.Interop.Excel.Application excelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook wb = null;

            try
            {
                wb = excelApp.Workbooks.Open(fileToPrint);

                if (wb != null)
                {
                    // Show print preview
                    excelApp.Visible = true;
                    wb.PrintPreview(true);
                }
            }
            catch (Exception ex)
            {
                //ShowMessage
                throw ex;
            }
            finally
            {
                // Cleanup:
                GC.Collect();
                GC.WaitForPendingFinalizers();

                wb.Close(false, Type.Missing, Type.Missing);
                Marshal.FinalReleaseComObject(wb);

                excelApp.Quit();
                Marshal.FinalReleaseComObject(excelApp);
            }
        }
        private void PrinPriview_word(string fileToPrint)
        {
            object missing = System.Type.Missing;
            object objFile = fileToPrint;
            object readOnly = true;
            object addToRecentOpen = false;

            // Create  a new Word application           
            Microsoft.Office.Interop.Word._Application wordApplication = new Microsoft.Office.Interop.Word.Application();
            try
            {
                // Create a new file based on our template
                Microsoft.Office.Interop.Word._Document wordDocument = wordApplication.Documents.Open(ref objFile, ref missing, ref readOnly, ref addToRecentOpen);

                wordApplication.Options.SaveNormalPrompt = false;

                if (wordDocument != null)
                {
                    // Show print preview
                    wordApplication.Visible = true;
                    wordDocument.PrintPreview();
                    wordDocument.Activate();
                    //wordDocument.op
                    while (!_IsPringPriview)
                    {
                        wordDocument.ActiveWindow.View.Magnifier = true;
                        Thread.Sleep(500);
                    }

                    wordDocument.Close(ref missing, ref missing, ref missing);
                    wordDocument = null;
                }
            }
            catch
            {
                //I didn't include a default error handler so i'm just throwing the error
                // throw ex;
            }
            finally
            {
                // Finally, Close our Word application
                wordApplication.Quit(ref missing, ref missing, ref missing);
                wordApplication = null;
            }
        }


        private static string SaveFile()
        {
            string result = string.Empty;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Workbook|*.xlsx|Excel 97- Excel 2003 Workbook|*.xls|Microsoft Excel 5.0/95 Workbook|*.xls|CSV|*.csv";
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = ".xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.CheckPathExists)
            {
                workbook.SaveAs(saveFileDialog.FileName);
                result = saveFileDialog.FileName;
            }

            return result;
        }

        private static string SaveFile_word()
        {
            string result = string.Empty;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Word|*.docx";
            saveFileDialog.AddExtension = true;
            saveFileDialog.DefaultExt = ".docx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK && saveFileDialog.CheckPathExists)
            {
                result = saveFileDialog.FileName;
                document.Save(saveFileDialog.FileName);
            }

            return result;
        }

        /// <summary>
        /// Opens the file.
        /// </summary>
        /// <param name="pPathFile">The p path file.</param>
        private static void OpenFile(string pPathFile)
        {
            if (string.IsNullOrEmpty(pPathFile))
            {
                return;
            }

            if (MessageBox.Show("Bạn muốn mở file", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                System.Diagnostics.Process proc = new System.Diagnostics.Process();
                proc.StartInfo.FileName = pPathFile;
                proc.Start();
            }
        }

        public static void export(IList<T> data, string pObj, string pFileName, object dataOther = null)
        {
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                IApplication application = excelEngine.Excel;
                application.DefaultVersion = ExcelVersion.Excel2013;
                workbook = application.Workbooks.Open(pFileName + ".xlsx");
                IWorksheet worksheet = workbook.Worksheets[0];

                //Create template marker processor for the workbook
                ITemplateMarkersProcessor marker = workbook.CreateTemplateMarkersProcessor();

                //GetSalesReports method returns list of sales persons and their reports
                IList<T> reports = data;

                //Adding reports collection to marker variables
                //Where the name should match with the input template
                marker.AddVariable(pObj, reports);

                switch (pObj)
                {
                    case "KetQuaLop":
                        {
                            marker.AddVariable("TenMonHoc", (dataOther as List<string>)[0]);
                            marker.AddVariable("TenLop", (dataOther as List<string>)[1]);
                            marker.AddVariable("HocKy", (dataOther as List<string>)[2]);
                            marker.AddVariable("NienKhoa", (dataOther as List<string>)[3]);
                        }
                        break;
                    case "KetQuaPhongThi":
                        {
                            marker.AddVariable("TenMonHoc", (dataOther as List<string>)[0]);
                            marker.AddVariable("PhongThi", (dataOther as List<string>)[1]);
                            marker.AddVariable("HocKy", (dataOther as List<string>)[2]);
                            marker.AddVariable("NienKhoa", (dataOther as List<string>)[3]);
                            marker.AddVariable("NgayThi", (dataOther as List<string>)[4]);
                        }
                        break;
                    default:
                        break;
                }

                //Applying Markers
                marker.ApplyMarkers();

                //Saving the workbook
                workbook.SaveAs(pFileName + "Result.xlsx");

                // print preview 
                string urlPriview = string.Format("{0}/{1}", Directory.GetCurrentDirectory(), pFileName + "Result.xlsx");

                PrinPriview_Excel(urlPriview);
                File.Delete(urlPriview);

                if (MessageBox.Show("Bạn muốn lưu kết quả?", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    OpenFile(SaveFile());
                }
            }
        }
        public void export_word(string pMaDT, List<string[]> data)
        {
            document = new WordDocument("report_dethi.docx");

            MailMergeDataSet dataSet = new MailMergeDataSet();

            MailMergeDataTable dataTable = new MailMergeDataTable("DeThi", new DeThiDAL().getDeThi(pMaDT));
            dataSet.Add(dataTable);

            List<DictionaryEntry> commands = new List<DictionaryEntry>();
            DictionaryEntry entry = new DictionaryEntry("DeThi", string.Empty);
            commands.Add(entry);

            document.MailMerge.ExecuteNestedGroup(dataSet, commands);
            document.MailMerge.Execute(data[0], data[1]);

            string fileBoNhiem = "temp.docx";

            //Saving the workbook
            document.Save(fileBoNhiem, Syncfusion.DocIO.FormatType.Docx);

            // print preview 
            string urlPriview = string.Format("{0}/{1}", Directory.GetCurrentDirectory(), fileBoNhiem);

            PrinPriview_word(urlPriview);

            if (MessageBox.Show("Bạn muốn lưu kết quả?", "Thông tin", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                OpenFile(SaveFile_word());
            }

            document.Close();
        }
    }
}