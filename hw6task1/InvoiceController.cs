using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Text;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/[controller]")]

namespace hw6task1
{

    public class InvoiceController : ControllerBase
    {
        private static List<InvoiceDocument> invoices = new List<InvoiceDocument>();

        [HttpPost]
        public IActionResult CreateInvoice([FromBody] InvoiceDocument invoice)
        {
            invoice.Id = invoices.Count + 1;
            invoices.Add(invoice);

            return Ok(invoice);
        }
    }
}
