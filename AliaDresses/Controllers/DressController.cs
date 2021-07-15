using AliaDresses.Models;
using AliaDresses.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AliaDresses.Controllers
{
    public class DressController : Controller
    {
        private readonly IDressRepository _dressRepository;
        private readonly ICategoryRepository _categoryRepository;

        public DressController(IDressRepository dressRepository, ICategoryRepository categoryRepository )
        {
            _dressRepository = dressRepository;
            _categoryRepository = categoryRepository;
        } 
        public ViewResult List ()
        {
            DressesListViewModel dressesListViewModel = new DressesListViewModel();
            dressesListViewModel.Dresses = _dressRepository.AllDresses;

            dressesListViewModel.CurrentCategory = "Soiree";
            return View(dressesListViewModel);
        }

    }
}
