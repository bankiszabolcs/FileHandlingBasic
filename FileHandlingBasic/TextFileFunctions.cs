using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileHandlingBasic
{
    public class TextFileFunctions
    {
        private readonly string _rootPath = AppDomain.CurrentDomain.BaseDirectory;
        private string _fileName = "TextFileExample1.txt";

        public TextFileFunctions(string fileName)
        {
            this._fileName = fileName;
        }

        public void WriteTextToFile(string[] lines)
        {
            using StreamWriter outputFile = new StreamWriter(Path.Combine(this._rootPath, _fileName), true);
            foreach (var line in lines)
            {
                outputFile.WriteLine(line);
            }
        }

        public string ReadFile()
        {
            using StreamReader inputStreamReader = new StreamReader(Path.Combine(this._rootPath, this._fileName));
            string content = inputStreamReader.ReadToEnd();
            return content;
        }
    }
}

//Amint lefutott ez a kód, a program megszabadul tőle automatikusan. Nem kell meghívni az outputFile.Close() -t
//vagy outputFile.Dispose()