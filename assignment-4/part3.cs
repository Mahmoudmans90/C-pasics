
using System.Diagnostics;
using System.Text;

namespace Assignment_3 {
    public class part3
{
        public static void DisplayPart_3()
        {
            string fileExt = ".pdf";
            string fileType;
            // a
            switch (fileExt)
            {
                case ".pdf":
                fileType = "PDF Document";
                break;
                case ".docx":
                case ".doc":
                fileType = "Word Document";
                break;
               
                case ".xlsx":
                case ".xls":
                fileType = "Exel Sheet";
                break;
                case "jpg":
                case ".png":
                case ".jpeg":
                fileType = "Image File";
                break;
                default:
                fileType = "Unknown";
                break;
               
            }

            //b
            string fileTypeExpression = fileType switch
            {
                 ".pdf" => "PDF Document",
                ".docx" or ".doc"       => "Word Document",
                ".xlsx"or ".xls"        => "Exel Sheet",
                "jpg"or ".png"or ".jpeg"=> "Image File",
                _ =>
                "Unknown"
                
            };
            Console.WriteLine(fileType , fileTypeExpression);
       
        }
}
}