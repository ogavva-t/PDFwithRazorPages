using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Wkhtmltopdf.NetCore;
using PDFwithRazorPages.Models;

namespace PDFwithRazorPages.Pages
{
    public class PDFTestModel : PageModel
    {
        readonly IGeneratePdf _generatePdf;
        public string Title {get; set;}

        public PDFTestModel(IGeneratePdf generatePdf)
        {
            _generatePdf = generatePdf;
        }

        public void OnGet()
        {
            Title = "PDF Test 222";
            return;
        }
    }
}