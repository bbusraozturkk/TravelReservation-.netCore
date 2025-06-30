using DocumentFormat.OpenXml.Wordprocessing;
using iTextSharp.text.pdf;
using Microsoft.AspNetCore.Mvc;
using System.IO;
using iTextSharp.text;
using Paragraph = iTextSharp.text.Paragraph;
using Document = iTextSharp.text.Document;
using PageSize = iTextSharp.text.PageSize;


namespace TravelReservation.Controllers
{
    public class PdfReportController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult StaticPdfReport()
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/pdfreports", "dosyal.pdf");

            // Klasör yoksa oluştur
            Directory.CreateDirectory(Path.GetDirectoryName(path));

            using (var stream = new FileStream(path, FileMode.Create))
            {
                Document document = new Document(PageSize.A4);
                PdfWriter.GetInstance(document, stream);

                document.Open();
                Paragraph paragraph = new Paragraph("Traversal Rezervasyon Pdf Raporu");
                document.Add(paragraph);
                document.Close();
            }

            byte[] fileBytes = System.IO.File.ReadAllBytes(path);
            return File(fileBytes, "application/pdf", "dosyal.pdf");
        }

    }
}
