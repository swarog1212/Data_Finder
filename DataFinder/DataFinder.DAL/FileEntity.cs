using System;
using System.Collections.Generic;
using System.Text;

namespace DataFinder.DAL
{
    public class FileEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Puth { get; set; }

        public FileEntity(Guid id, string name, string puth)
        {
            this.Id = id;
            this.Name = name;
            this.Puth = puth;
        }
    }
}
