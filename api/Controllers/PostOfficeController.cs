using api.Context;
using api.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers
{
    [ApiController]
    [Route("api/postoffices")]
    public class PostOfficeController: Controller
    {
        private readonly DBContext dbContext;

        public PostOfficeController(DBContext context)
        {
            dbContext = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<PostOfficeDTO> postoffices = dbContext.PostOffices
                .Select(po => new PostOfficeDTO()
                {
                    id = po.id,
                    wardId = po.wardId,
                    postCode = po.postCode,
                    postName = po.postName,
                    address = po.address,
                    latitude = po.latitude,
                    longtitude = po.longtitude
                })
                .ToList();
            return Ok(postoffices);
        }

        [HttpGet]
        [Route("bydist/{id}")]
        public IActionResult POByDistrict(int id)
        {
            
            List<PostOfficeDTO> postoffices = dbContext.PostOffices
                .Where(po => dbContext.Wards.Any(ward => ward.district_id == id && ward.id == po.wardId))
                .Select(po => new PostOfficeDTO()
                {
                    id = po.id,
                    wardId = po.wardId,
                    postCode = po.postCode,
                    postName = po.postName,
                    address = po.address,
                    latitude = po.latitude,
                    longtitude = po.longtitude
                })
                .ToList();
            return Ok(postoffices);
        }
    }
}

