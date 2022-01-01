using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NetCoreWebAPI.Data;
using NetCoreWebAPI.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NetCoreWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll() // veri cekerken kullanıyoruz 
        {
            NorthwindDBContext dBContext = new NorthwindDBContext();
            var categories = dBContext.Categories.ToList();
            return Ok(categories);
        }

        [HttpGet("{id}")]

        public IActionResult GetByID(int id) // idye göre kategori cekme
        {
            NorthwindDBContext dBContext = new NorthwindDBContext();
            var category = dBContext.Categories.FirstOrDefault(x => x.CategoryID == id);
            return Ok(category);
        }

        [HttpPost]
        public IActionResult Create(Category category)
        {

            NorthwindDBContext dBContext = new NorthwindDBContext();
            dBContext.Categories.Add(category);
            dBContext.SaveChanges();

            return Ok(category);

        }


        [HttpPut]
        public IActionResult Update(Category category)
        {

            NorthwindDBContext dBContext = new NorthwindDBContext();
            var guncellenecekKategori = dBContext.Categories.FirstOrDefault(x => x.CategoryID == category.CategoryID);
            guncellenecekKategori.CategoryName = category.CategoryName;
            guncellenecekKategori.Description = category.Description;
           
            dBContext.SaveChanges();

            return Ok(guncellenecekKategori);

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            NorthwindDBContext dBContext = new NorthwindDBContext();
            var silinecekKategori = dBContext.Categories.FirstOrDefault(x => x.CategoryID == id);

            dBContext.Categories.Remove(silinecekKategori);
            dBContext.SaveChanges();

            return Ok(silinecekKategori);

        }

    }
}
