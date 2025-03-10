using Microsoft.AspNetCore.Mvc;
using Hometown_Application.Models;
using Hometown_Application.Data;

public class RequestTypeController : Controller
{
    private readonly ApplicationDBContext _context;

    public RequestTypeController(ApplicationDBContext context)
    {
        _context = context;
    }

    // GET: Create Request Type Form
    public IActionResult Create()
    {
        return View(new RequestTypeModel());
    }

    // POST: Save Request Type
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult SaveRequestType(RequestTypeModel model)
    {
        if (!ModelState.IsValid)
        {
            return View("Create", model);
        }

        if (model.RequestTypeId == 0)
        {
            _context.RequestTypes.Add(model);
        }
        else
        {
            _context.RequestTypes.Update(model);
        }

        _context.SaveChanges();
        return RedirectToAction("Index"); // Redirect to list of request types
    }

    /* public IActionResult Index()
     {
         var requestTypes = _context.RequestTypes.ToList();
         return View(requestTypes);
     }*/

    public IActionResult Index(string searchQuery)
    {
        var requestTypes = _context.RequestTypes.AsQueryable();

        // Search functionality
        if (!string.IsNullOrEmpty(searchQuery))
        {
            requestTypes = requestTypes.Where(rt => rt.Name.Contains(searchQuery));
        }

        // Sort alphabetically
        requestTypes = requestTypes.OrderBy(rt => rt.Name);

        return View(requestTypes.ToList());
    }

    // GET: Delete Request Type
    public IActionResult Delete(int id)
    {
        var requestType = _context.RequestTypes.Find(id);
        if (requestType == null)
        {
            return NotFound();
        }

        _context.RequestTypes.Remove(requestType);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

    public IActionResult RequestTypeForm(int? id)
    {
        if (id == null)
        {
            // Creating a new request type
            return View(new RequestTypeModel());
        }

        var requestType = _context.RequestTypes.Find(id);
        if (requestType == null)
        {
            return NotFound(); // If ID doesn't exist
        }

        return View(requestType);
    }

    // POST: /RequestType/RequestTypeForm
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult RequestTypeForm(RequestTypeModel model)
    {
        if (ModelState.IsValid)
        {
            if (model.RequestTypeId == 0)
            {
                // Create new entry
                _context.RequestTypes.Add(model);
            }
            else
            {
                // Update existing entry
                _context.RequestTypes.Update(model);
            }
            _context.SaveChanges();
            return RedirectToAction("Index"); // Redirect to list view
        }
        return View(model);
    }

}
