using System;
using System.Collections.Generic;
using System.Text;

namespace hw6task1
{
    public class InvoiceDocument : Document
    {
        public decimal Amount { get; set; }
        public DateTime InvoiceDate { get; set; }
    }
}
