using Microsoft.AspNetCore.Mvc;

namespace myFinalProject.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly Data.AppDbContext _context;

        public UsersController(Data.AppDbContext context)
        {
            _context = context;
        }

        [HttpPost("[action]")]

        public ActionResult<Data.Entities.Users.Users> Post(Dto.Users.UsersDto dto)
        {
            var model = new Data.Entities.Users.Users
            {
                Name = dto.Name,
                FullName = dto.FullName,
                Id = dto.Id,
                Birthdate = dto.Birthdate,
            };
            _context.Add(model);
            _context.SaveChanges();
            return Ok(model);
        }
    }
}
