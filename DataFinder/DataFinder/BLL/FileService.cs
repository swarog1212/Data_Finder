using System;
using System.Collections.Generic;
using System.Linq;
using DataFinder.DAL;

namespace DataFinder.BLL
{
    public class FileService
    {
        public FileRepository FileRepository { get; }
        public FileService()
        {
            this.FileRepository = new FileRepository();
        }

        public IEnumerable<File> GetAllFiles()
        {
            return FileRepository.GetFilesByDirectory().ToList()
                .Select(fileEntity => new File(fileEntity));
        }
         public File GetFileByFileName(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
                throw new BusinessRuleException("Введите коректное значение!");

            var fileEntity = FileRepository.GetFileByFileName(fileName);
            if (fileEntity is null)
                throw new BusinessRuleException("Файл с указанным именем не обнаружен!");

            return new File(fileEntity);
        }
    }
}
