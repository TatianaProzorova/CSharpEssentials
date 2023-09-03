using System;

namespace CSharpEssentials
{
    public static class GetExtension
    {
        static string GetFileExtension(this FileFormat fileFormat)
        {
            switch (fileFormat)
            {
                case FileFormat.PlainText: return "txt";
                case FileFormat.OfficeWord: return "docx";
                case FileFormat.Markdown: return "md";
                case FileFormat.Json: return "json";
                case FileFormat.XML: return "xml";
                default: throw new Exception("Unrecognized file format");
            }
        }
        // code from Main()
        //var format = FileFormat.Markdown;
        //var fileExt = format.GetFileExtension(); // "md"
        //var fileName = $"output.{fileExt}"; // "output.md"
    }
}
