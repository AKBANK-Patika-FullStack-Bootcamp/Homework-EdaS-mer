using Microsoft.AspNetCore.Authorization;
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
    public class ProductsController : ControllerBase
    {

        [HttpGet]
        [Authorize]
        public IActionResult GetAll() // veri cekerken kullanıyoruz 
        {
            NorthwindDBContext dBContext = new NorthwindDBContext();
            var product = dBContext.Products.ToList();
            return Ok(product);
        }

        [HttpGet("{id}")]

        public IActionResult GetByID(int id) // idye göre kategori cekme
        {
            NorthwindDBContext dBContext = new NorthwindDBContext();
            var product = dBContext.Products.FirstOrDefault(x => x.ProductID == id);
            return Ok(product);
        }

        [HttpPost]
        public IActionResult Create(Products p)
        {

            NorthwindDBContext dBContext = new NorthwindDBContext();
            dBContext.Products.Add(p);
            dBContext.SaveChanges();

            return Ok(p);

        }


        [HttpPut]
        public IActionResult Update(Products p)
        {

            NorthwindDBContext dBContext = new NorthwindDBContext();
            var guncellenecekProduct = dBContext.Products.FirstOrDefault(x => x.ProductID == p.ProductID);
            guncellenecekProduct.ProductName = p.ProductName;
            guncellenecekProduct.UnitsInStock= p.UnitsInStock;

            dBContext.SaveChanges();

            return Ok(guncellenecekProduct);

        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {

            NorthwindDBContext dBContext = new NorthwindDBContext();
            var silinecekProduct = dBContext.Products.FirstOrDefault(x => x.ProductID == id);

            dBContext.Products.Remove(silinecekProduct);
            dBContext.SaveChanges();

            return Ok(silinecekProduct);

        }

    }
}
