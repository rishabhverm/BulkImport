using Bulkimport.Bussiness;
using Bulkimport.Bussiness.Interface;
using Microsoft.AspNetCore.Mvc;

namespace BulkDataImport.Client.Controllers
{
    public class ImportController : Controller
    {
        private readonly IBulkImport _bulkrepo;

        public ImportController(IBulkImport bulkrepo)
        {
            _bulkrepo = bulkrepo;
        }

        [HttpPost("upload-csv")]
        public async Task<IActionResult> GetBulkImportCSV([FromForm] List<IFormFile> files)
        {
            if (files == null || files.Count == 0)
                return BadRequest("No files uploaded.");

            foreach (var file in files)
            {
                // Validate file type
                if (!file.FileName.EndsWith(".csv", System.StringComparison.OrdinalIgnoreCase))
                    return BadRequest($"Invalid file type: {file.FileName}");

                // Process file asynchronously
                var filePath = Path.Combine(Path.GetTempPath(), file.FileName);

                try
                {
                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(stream);
                    }
                }
                catch (IOException ex)
                {
                    return StatusCode(StatusCodes.Status500InternalServerError, $"File save error: {ex.Message}");
                }
            }

            return Ok($"{files.Count} CSV file(s) uploaded successfully.");
        }
    }
}
