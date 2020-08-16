using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MediaFileTask.Models
{
    public class MediaFileContext : DbContext
    {
        public MediaFileContext() : base ("Data Source=DESKTOP-14MJTR1\\SQLEXPRESS;Initial Catalog=MediaFilesDB;Integrated Security=True")
        {
            
        }
        public DbSet<MediaFile> MediaFiles { get; set; }
    }
}