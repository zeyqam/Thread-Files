using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Thread_Files.Extensions;
using Thread_Files.Services;
using Thread_Files.Services.Interfaces;

namespace Thread_Files.Controllers
{
    internal class FileController
    {
        private readonly IFileService _fileService;
        public FileController()
        {
            _fileService = new FileService();
        }
        public async Task ReadDataAsync()
        {
            string result = await _fileService.ReadFromFileAsync("C:\\Users\\HP\\Desktop\\C#\\file2.txt");
            Console.WriteLine(result);
            
           
            
        }

        public async Task CreateFileWithContentAsync()
        {
            string data = AppDomain.CurrentDomain.BaseDirectory;
            var datas = data.Split("\\");
            var path = string.Empty;
            foreach (var item in datas)
            {
                if (item != "C#")
                {
                    path += item + "\\";
                }
                else
                {
                    break;
                }
            }
            path += "C#";

            await Console.Out.WriteLineAsync("Add fileName");
            string? fileName = Console.ReadLine();
            await Console.Out.WriteLineAsync("Add your text:");
            string text=Console.ReadLine();
            string resultPath=path.GenerateFullPath(fileName);
            await _fileService.WriteToNewFileAsync(resultPath, text);
        }



        public async  Task DeleteAsync()
        {
            await _fileService.DeleteAsync("C:\\Users\\HP\\Desktop\\C#\\file7.txt");
        }
    }
}
