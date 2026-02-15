using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lessons_7_8
{
    class PrintJob
    {
        public string DocumentName { get; set; }
        public int Pages { get; set; }

        public PrintJob(string documentName, int pages)
        {
            DocumentName = documentName;
            Pages = pages;
        }
    }
}
