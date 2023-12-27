using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiAppC6.Models
{
    public class TodoModel
    {
        public int ID { get; set; }
        public string? Task { get; set; }
        public bool IsCompleted { get; set; }
    }
}
