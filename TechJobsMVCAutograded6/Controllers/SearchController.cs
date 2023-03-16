﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechJobsMVCAutograded6.Data;
using TechJobsMVCAutograded6.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace TechJobsMVCAutograded6.Controllers;

public class SearchController : Controller
{
    // GET: /<controller>/
    public IActionResult Index()
    {
        ViewBag.columns = ListController.ColumnChoices;
        return View();
    }

    // TODO #3 - Create an action method to process a search request and render the updated search views.
    public IActionResult Results(string searchType, string searchTerm)
    {
        List<Job> jobs;
        if (string.IsNullOrEmpty(searchTerm))
        {
            jobs = JobData.FindAll();
        }
        else
        {
            jobs = JobData.FindByColumnAndValue(searchType, searchTerm);
        }
        ViewBag.columns = ListController.ColumnChoices;
        ViewBag.title = "Jobs with " + ListController.ColumnChoices[searchType] + ": " + searchTerm;
        ViewBag.jobs = jobs;


        return View("Index");
    }
}

