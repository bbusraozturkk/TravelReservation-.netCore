using Business_layer.Abstract;
using ClosedXML.Excel;
using DataAccess_layer.Concrete;
using DocumentFormat.OpenXml.Spreadsheet;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using TravelReservation.Models;

namespace TravelReservation.Controllers
{
    public class ExcelController : Controller
    {
        private readonly IExcelService _excelService;

        public ExcelController(IExcelService excelService)
        {
            _excelService = excelService;
        }

        public IActionResult Index()
        {

            return View();

        }

        public List<DestinationModel> DestinationList()
        {
            List<DestinationModel> destinationModels = new List<DestinationModel>(); using (var c = new Context())
            {
                destinationModels = c.Destinations.Select(x => new DestinationModel
                {
                    City = x.City,
                    DayNight = x.DayNight,
                    Price = x.Price,
                    Capacity = x.Capacity
                }).ToList();
                return destinationModels;

            }
        }

        public IActionResult StaticExcelReport()
        {

            return File(
    _excelService.ExcelList(DestinationList()),
    "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
    "YeniExcel.xlsx"
);
        }
        public IActionResult DestinationExcelReport()
        {
            using (var workBook = new XLWorkbook())
            {
                var worksheet = workBook.Worksheets.Add("Tur Listesi");

                worksheet.Cell(1, 1).Value = "Şehir";
                worksheet.Cell(1, 2).Value = "Konaklama Süresi";
                worksheet.Cell(1, 3).Value = "Fiyat";
                worksheet.Cell(1, 4).Value = "Kapasite";

                int rowCount = 2;
                foreach (var item in DestinationList())
                {
                    worksheet.Cell(rowCount, 1).Value = item.City;
                    worksheet.Cell(rowCount, 2).Value = item.DayNight;
                    worksheet.Cell(rowCount, 3).Value = item.Price;
                    worksheet.Cell(rowCount, 4).Value = item.Capacity;
                    rowCount++;
                }
                using (var stream = new MemoryStream())
                {
                    workBook.SaveAs(stream);
                    var content = stream.ToArray();
                    return File(content,
                                "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet",
                                "YeniListe.xlsx");
                }
            }
        }
    }
}
