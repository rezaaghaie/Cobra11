using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Cobra11.Model
{
    public class ToDoItem
    {
        [Key]
        public long Id { get; set; }
        public string Title { get; set; }
        public bool IsCompleted { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastUpdateDateTime { get; set; }
    }
}
