using Hometown_Application.Data;
using Hometown_Application.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Hometown_Application.Controllers
{
    [Authorize]
    public class DocumentController : Controller
    {
        private readonly ApplicationDBContext _context;

        public DocumentController(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: Display uploaded files
        [HttpGet]
        public IActionResult Index()
        {
            var documents = _context.Documents.ToList();
            return View(documents);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> UploadFiles(List<IFormFile> files)
        {
            if (files == null || files.Count == 0)
            {
                TempData["MessageType"] = "error";
                TempData["Message"] = "No files selected.";
                return RedirectToAction("Index");
            }

            var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Files");
            Directory.CreateDirectory(uploadsFolder);

            List<DocumentModel> uploadedDocuments = new List<DocumentModel>();
            bool uploadSuccessful = true;

            foreach (var file in files)
            {
                try
                {
                    if (file.Length > 0)
                    {
                        var fileName = Path.GetFileName(file.FileName);
                        var filePath = Path.Combine(uploadsFolder, fileName);

                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            await file.CopyToAsync(stream);
                        }

                        var document = new DocumentModel
                        {
                            DocumentName = fileName,
                            DocumentType = file.ContentType,
                            FilePath = $"/Files/{fileName}",
                            FileSize = file.Length / 1024,
                            UploadedOn = DateTime.Now,
                            UploadedBy = "Admin"
                        };

                        uploadedDocuments.Add(document);
                        _context.Documents.Add(document);
                    }
                }
                catch (Exception)
                {
                    uploadSuccessful = false;
                }
            }

            if (uploadSuccessful)
            {
                await _context.SaveChangesAsync();
                TempData["MessageType"] = "success";
                TempData["Message"] = $"{files.Count} file(s) uploaded successfully!";
            }
            else
            {
                TempData["MessageType"] = "error";
                TempData["Message"] = "Error uploading some files. Please try again.";
            }

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult FileDownload()
        {
            var documents = _context.Documents.ToList();
            return View(documents);
        }

        // GET: Download file
        [HttpGet]
        public IActionResult Download(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                TempData["MessageType"] = "error";
                TempData["Message"] = "Invalid file name.";
                return RedirectToAction("FileDownload");
            }

            var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Files");
            var filePath = Path.Combine(uploadsFolder, fileName);

            if (!System.IO.File.Exists(filePath))
            {
                TempData["MessageType"] = "error";
                TempData["Message"] = "File not found.";
                return RedirectToAction("FileDownload");
            }

            var fileBytes = System.IO.File.ReadAllBytes(filePath);
            var contentType = "application/octet-stream"; // Default content type

            return File(fileBytes, contentType, fileName);
        }

        public IActionResult DeleteDocument(int id)
        {
            var documentDb = _context.Documents.SingleOrDefault(doc => doc.Id == id);
            if (documentDb == null)
            {
                TempData["MessageType"] = "error";
                TempData["Message"] = "Document not found.";
                return RedirectToAction("Index");
            }

            // Delete the physical file
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "Files", documentDb.DocumentName);
            if (System.IO.File.Exists(filePath))
            {
                System.IO.File.Delete(filePath);
            }

            _context.Documents.Remove(documentDb);
            _context.SaveChanges();

            TempData["MessageType"] = "success";
            TempData["Message"] = "Document deleted successfully!";
            return RedirectToAction("Index");
        }
    }
}