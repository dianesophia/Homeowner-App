using Hometown_Application.Data;
using Hometown_Application.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

public class BillingManagementController : Controller
{
    private readonly ApplicationDBContext _context;

    public BillingManagementController(ApplicationDBContext context)
    {
        _context = context;
    }

    // Display all bills
    public async Task<IActionResult> Index()
    {
        var bills = await _context.Bills.Include(b => b.ApplicationUser).ToListAsync();
        return View(bills);
    }

    // Display an empty view
    public IActionResult EmptyIndex()
    {
        return View();
    }

    // Display form to create a new bill
    public IActionResult Create()
    {
        return View();
    }

    // Handle the creation of a new bill
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("UserId,BillingDate,DueDate,TotalAmount,BillingPeriod,Status")] BillModel bill)
    {
        if (ModelState.IsValid)
        {
            _context.Add(bill);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(bill);
    }

    // Display form to edit an existing bill
    public async Task<IActionResult> Edit(int id)
    {
        var bill = await _context.Bills.FindAsync(id);
        if (bill == null)
        {
            return NotFound();
        }
        return View(bill);
    }

    // Handle the update of an existing bill
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("BillId,UserId,BillingDate,DueDate,TotalAmount,BillingPeriod,Status")] BillModel bill)
    {
        if (id != bill.BillId)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            _context.Update(bill);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(bill);
    }

    // Display details of a specific bill
    public async Task<IActionResult> Details(int id)
    {
        var bill = await _context.Bills
            .Include(b => b.ApplicationUser)
            .FirstOrDefaultAsync(m => m.BillId == id);
        if (bill == null)
        {
            return NotFound();
        }
        return View(bill);
    }

    // Confirm deletion of a bill
    public async Task<IActionResult> Delete(int id)
    {
        var bill = await _context.Bills
            .Include(b => b.ApplicationUser)
            .FirstOrDefaultAsync(m => m.BillId == id);
        if (bill == null)
        {
            return NotFound();
        }
        return View(bill);
    }

    // Handle the deletion of a bill
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        var bill = await _context.Bills.FindAsync(id);
        _context.Bills.Remove(bill);
        await _context.SaveChangesAsync();
        return RedirectToAction(nameof(Index));
    }
}
