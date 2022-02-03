using System;
using System.Collections.Generic;
using System.Linq;

namespace DataFinder.DAL
{
    public class FileRepository
    {
        private IEnumerable<FileEntity> files { get; }
        public FileRepository()
        {
            files = new List<FileEntity>()
            {
                new FileEntity(Guid.NewGuid(), "Реферат.docx", @"C:\Users\Симаргл\Desktop\Реферат.docx"),
                new FileEntity(Guid.NewGuid(), "Отчет.docx", @"C:\Users\Симаргл\Desktop\Отчет.docx"),
                new FileEntity(Guid.NewGuid(), "Книга1.xls", @"C:\Users\Симаргл\Desktop\Книга1.xls"),
                new FileEntity(Guid.NewGuid(), "Фото на документы.jpeg", @"C:\Users\Симаргл\Desktop\Фото на документы.jpeg"),
                new FileEntity(Guid.NewGuid(), "Ярлык.lnk", @"C:\Users\Симаргл\Desktop\Ярлык.lnk"),
            };
        }

        public IEnumerable<FileEntity> GetFilesByDirectory()
        {
            return this.files;
        }

        public FileEntity GetFileByFileName(string fileName)
        {
            return this.files.FirstOrDefault(file => file.Name == fileName);
        }
    }
}
