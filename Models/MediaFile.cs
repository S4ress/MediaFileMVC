using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MediaFileTask.Models
{
    public class MediaFile
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public int Size { get; set; }
    }
}