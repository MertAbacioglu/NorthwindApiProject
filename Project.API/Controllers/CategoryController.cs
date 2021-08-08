using Project.BLL.DesignPatterns.GenericRepository.ConcRepository;
using Project.BLL.DTO.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Project.API.Controllers
{


    public class CategoryController : ApiController
    {
        CategoryReporsitory _categoryRep;

        public CategoryController()
        {
            _categoryRep = new CategoryReporsitory();
        }

        [HttpGet]
        public HttpResponseMessage BringCategories()
        {
            return Request.CreateResponse(HttpStatusCode.OK, _categoryRep.GetAll());
        }

        [HttpGet]
        public HttpResponseMessage BringTheCategory(int id)
        {
            if (_categoryRep.Any()
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "there is no record");
            }
            return Request.CreateResponse(HttpStatusCode.OK, _categoryRep.Find(id));

        }

        [HttpPut]
        public HttpResponseMessage UpdateCategory(CategoryDTO categoryDto, int id)
        {
            
            if (_categoryRep.Any()
            {
                _categoryRep.Update(categoryDto, id);
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
            else if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }
            _categoryRep.Update(categoryDto, id);
            return Request.CreateResponse(HttpStatusCode.OK, _categoryRep.GetAll());

        }

        [HttpPost]
        public HttpResponseMessage CreateCategory(CategoryDTO categoryDto)
        {
            if (ModelState.IsValid)
            {
                _categoryRep.Add(categoryDto);
                return Request.CreateResponse(HttpStatusCode.OK, _categoryRep.GetAll());
            }
            return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);

        }

        [HttpDelete]
        public HttpResponseMessage DeleteCategory(int id)
        {
            if (_categoryRep.Any()
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, "there is no record");
            }
            _categoryRep.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, _categoryRep.GetAll());
        }
    }
}
