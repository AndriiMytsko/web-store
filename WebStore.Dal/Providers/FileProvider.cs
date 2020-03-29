using Newtonsoft.Json;
using OfficeOpenXml;
using System.Data;
using System.IO;

namespace WebStore.Dal.Providers
{
    public class FileProvider : IFileProvider
    {
        private readonly string _rootPath;

        public FileProvider(string rootPath)
        {
            _rootPath = rootPath;
        }
        public byte[] GetFile(string fileName)
        {
            return null;
        }

        public void WriteToExel<T>(T obj, string fileName)
        {
            DataTable table = (DataTable)JsonConvert.DeserializeObject(JsonConvert.SerializeObject(obj), (typeof(DataTable)));
            var fullFilePath = GetFullFilePath(fileName);

            FileInfo filePath = new FileInfo(fullFilePath);
            using (var excelPack = new ExcelPackage(filePath))
            {
                var ws = excelPack.Workbook.Worksheets.Add("WriteTest");
                ws.Cells.LoadFromDataTable(table, true, OfficeOpenXml.Table.TableStyles.Light8);
                excelPack.Save();
            }
        }

        private string GetFullFilePath(string fileName)
        {
            return Path.Combine(_rootPath, fileName);
        }
    }
}
