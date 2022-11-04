using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WDP2022A2Win.Data;
using WDP2022A2Win.Models;
using WDP2022A2Win.ViewModels;

namespace WDP2022A2Win.Controllers;

public class CompanyController : Controller
{
    private readonly ApplicationDbContext dbContext; 
    private readonly IWebHostEnvironment webHostEnvironment;  
    
    public CompanyController(ApplicationDbContext context, IWebHostEnvironment hostEnvironment)  
    {  
        dbContext = context;
        webHostEnvironment = hostEnvironment;  
    }
    
    [Authorize(Roles = "Admin")]
    // GET
    public async Task<IActionResult> Companies()
    {
        var companies = await dbContext.Companies.ToListAsync();
        return View(companies);
    }
    
    [HttpGet]
    [Authorize(Roles = "Admin")]
    public IActionResult Detail()
    {
        var id = Int32.Parse(ControllerContext.RouteData.Values["id"].ToString());
        var company = dbContext.Companies.SingleOrDefault(c => c.Id == id);
        return View(company);
    }
    
    [Authorize(Roles = "Admin")]
    public IActionResult Create()
    {
        return View();
    }
    
    [HttpGet]
    [Authorize(Roles = "Admin")]
    public IActionResult Edit()
    {
        var id = Int32.Parse(ControllerContext.RouteData.Values["id"].ToString());
        var company = dbContext.Companies.SingleOrDefault(c => c.Id == id);
        string path = "./wwwroot/images/" + company.ImageFilename;
        IFormFile FileData;
        using var stream = System.IO.File.OpenRead(path);
        FileData = new FormFile(stream, 0, stream.Length, null, Path.GetFileName(stream.Name));
            
        var model = new CompanyViewModels
        {
            Id = company.Id,
            Summary = company.Summary,
            CompanyName = company.CompanyName,
            Image = FileData
        };

        return View(model);
    }

    [HttpGet]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Delete()
    {
        var id = Int32.Parse(ControllerContext.RouteData.Values["id"].ToString());
        var company = new Company { Id = id };

        dbContext.Remove(company);
        await dbContext.SaveChangesAsync();
        return RedirectToAction("Companies", "Company");
    }

    [Authorize(Roles = "Admin")]
    public IActionResult DeleteView()
    {
        var id = Int32.Parse(ControllerContext.RouteData.Values["id"].ToString());
        var company = dbContext.Companies.SingleOrDefault(c => c.Id == id);
        return View(company);
    }

    [HttpPost]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> Save(CompanyViewModels model)
    {
        if (ModelState.IsValid)
        {
            var uniqueFileName = UploadedFile(model);

            Company company;
            
            if (model.Id == null)
            {
                company = new Company
                {
                    Like = 0,
                    Summary = model.Summary,
                    AnchorLink = "/Home/Companies/#" + model.CompanyName,
                    canIncreaseLike = true,
                    CompanyName = model.CompanyName,
                    ImageFilename = uniqueFileName
                };
                dbContext.Add(company);
            }
            else
            {
                company = dbContext.Companies.SingleOrDefault(c => c.Id == model.Id);
                
                if (company == null)
                    return RedirectToAction("Create", "Company");
                
                company.Summary = model.Summary;
                company.CompanyName = model.CompanyName;
                company.ImageFilename = uniqueFileName;
                company.AnchorLink = "/Home/Companies/#" + model.CompanyName;
            }
            
            await dbContext.SaveChangesAsync();
            return RedirectToAction("Companies", "Company");
        }
        
        
        return RedirectToAction("Create", "Company");
    }
    
    [Authorize(Roles = "Admin")]
    private string UploadedFile(CompanyViewModels model)  
    {  
        string uniqueFileName = null;  
  
        if (model.Image != null)  
        {  
            string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");  
            uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Image.FileName;  
            string filePath = Path.Combine(uploadsFolder, uniqueFileName);  
            using (var fileStream = new FileStream(filePath, FileMode.Create))  
            {  
                model.Image.CopyTo(fileStream);  
            }  
        }  
        return uniqueFileName;  
    }
}