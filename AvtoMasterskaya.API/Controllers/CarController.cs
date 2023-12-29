using AvtoMasterskaya.Context.Contracts.Models;
using Microsoft.AspNetCore.Mvc;

namespace AvtoMasterskaya.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarController : ControllerBase
    {
        private readonly IContext context1;
        public CarController(IContext context1)
        {
            this.context1 = context1;
        }
        [HttpGet] //localhost:111224/group
        public IActionResult GetAllTovar()
        {
            var tovarlist = context1.Cars.ToList();
            return Ok(tovarlist);
        }
        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            var tovarlist = context1.Cars.FirstOrDefault(x => x.Id == id);
            return Ok(tovarlist);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            var group3 = context1.Cars.FirstOrDefault(x => x.Id == id);
            if (group3 != null)
            {
                context1.Cars.Remove(group3);
            }
            return Ok();
        }
        [HttpPost]
        public IActionResult Create(Car model)
        {
            var item3 = new Car
            {
                Id = Guid.NewGuid(),
                Marka = model.Marka,
                Model = model.Model,
                Gos_Number = model.Gos_Number,
                ViN = model.ViN,
                Probeg = model.Probeg,
                CreatedAT = DateTime.Now,
                CreatedBy = "Я",
                UpdatedAt = DateTime.Now,
                UpdatedBy = "Я богатырь!"
            };
            context1.Cars.Add(item3);
            return Ok(item3);
        }
        [HttpPut("{id}")]
        public IActionResult Edit(Guid Id, Car model)
        {
            var group3 = context1.Cars.FirstOrDefault(x => x.Id == Id);
            if (group3 != null)
            {
                return NotFound();
            }
            group3.Marka = model.Marka;
            group3.Model = model.Model;
            group3.Gos_Number = model.Gos_Number;
            group3.ViN = model.ViN;
            group3.Probeg = model.Probeg;
            group3.UpdatedAt = DateTime.Now;
            return Ok(group3);
        }
    }
}
