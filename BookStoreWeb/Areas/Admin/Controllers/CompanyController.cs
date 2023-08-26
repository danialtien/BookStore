using BookStore.DataAccess.Repository.IRepository;
using BookStore.Models;
using BookStore.Utility;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Data;

namespace BookStoreWeb.Areas.Admin.Controllers
{
    [Area("Admin")]
    //[Authorize(Roles = SD.Role_Admin)]
    public class CompanyController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public CompanyController(IUnitOfWork unitOfWork, IWebHostEnvironment webHostEnvironment)
        {
            _unitOfWork = unitOfWork;
            _webHostEnvironment = webHostEnvironment;
        }
        public IActionResult Index()
        {
            List<Company> listCompany = _unitOfWork.Company.GetAll().ToList();
            return View(listCompany);
        }

        public IActionResult Upsert(int? id)
        {

            if (id == 0 || id == null)
            {
                //create
                return View(new Company());

            }
            else
            {
                //update
                Company company = _unitOfWork.Company.Get(u => u.Id == id);
                return View(company);
            }
        }

        [HttpPost]
        public IActionResult Upsert(Company company)
        {
            if (ModelState.IsValid)
            {

                if (company.Id != 0)
                {
                    _unitOfWork.Company.Update(company);
                    _unitOfWork.Save();
                    TempData["success"] = "Company updated succesfully";
                }
                else
                {
                    _unitOfWork.Company.Add(company);
                    _unitOfWork.Save();
                    TempData["success"] = "Company created succesfully";
                }
                return RedirectToAction("Index", "Company");
            }
            else
            {
                return View(company);
            }
        }

        #region API CAll
        [HttpGet]
        public IActionResult GetAll()
        {
            List<Company> listCompany = _unitOfWork.Company.GetAll().ToList();
            return Json(new { data = listCompany });
        }

        [HttpDelete]
        public IActionResult Delete(int? id)
        {
            var objectToDelete = _unitOfWork.Company.Get(u => u.Id == id);
            if (objectToDelete == null)
            {
                return Json(new { success = false, message = "Detete Failure" });
            }
            _unitOfWork.Company.Remove(objectToDelete);
            _unitOfWork.Save();
            return Json(new { success = true, message = "Detete Successful" });
        }

        #endregion 
    }
}
