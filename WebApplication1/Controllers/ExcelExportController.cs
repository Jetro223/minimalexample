using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using OfficeOpenXml;

namespace MinimalExample.Controllers
{
    public class MyData
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Dezimal { get; set; }
    }

    [Produces("application/json")]
        [Route("api/ExcelExport")]
        public class ExcelExportController : Controller
        {
            public IActionResult GetExcelFile()
            {
                var data = new List<MyData>
                {
                    new MyData {Id = 1, Name =" Eins", Dezimal = 12.55M},
                    new MyData {Id = 2, Name =" Zwei", Dezimal = 1313.3443M},
                };
                var pck = new ExcelPackage();
                var ws = pck.Workbook.Worksheets.Add("Content");


                ws.Cells["A1"].LoadFromCollection(data);

                return File(pck.GetAsByteArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", $"Qualitaetsberichte-Export - {DateTime.Now.ToLongDateString()}.xlsx");

            }
        }
    
}