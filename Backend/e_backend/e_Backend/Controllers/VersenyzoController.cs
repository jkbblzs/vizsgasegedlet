using Europass_Backend.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Security.Policy;
using System.Threading.Tasks;

namespace Europass_Backend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class VersenyzoController : ControllerBase
    {
        //Scaffold-DbContext "server=localhost;database=********;user=root;password=;ssl mode = none;"mysql.entityframeworkcore -outputdir Models –f
        [HttpGet]

        public IActionResult Get()
        {

            using (var context = new euroskillsContext())
            {
                try
                {
                    var response = context.Versenyzos.ToList();
                    return Ok(response);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }

        [Route("stepbystep")]
        [HttpGet]

        public IActionResult GetStepByStep(int Id)
        {

            using (var context = new euroskillsContext())
            {
                try
                {
                    return Ok(context.Versenyzos.Where(f => f.Id == Id).ToList());
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }

        [HttpGet("osszesOrszagSzama")]

        public async Task<IActionResult> osszesOrszagSzama()
        {
            using (var context = new euroskillsContext())
            {
                try
                {
                    var response = await context.Orszags.ToListAsync();
                    return StatusCode(200, response.Count);
                }
                catch (Exception ex)
                {
                    return BadRequest(ex.Message);
                }
            }
        }
        [HttpPost("{uId}")]

        public IActionResult Post(string uId, Versenyzo versenyzo)
        {
            string userId="FKB3F4FEA09CE43C";

            if (userId==uId)
            {
                using (var context = new euroskillsContext())
                {
                    try
                    {
                        context.Versenyzos.Add(versenyzo);
                        context.SaveChanges();
                        return Ok("Versenyző hozzáadása sikeresen megtörtént.");
                    }
                    catch (Exception ex)
                    {
                        return BadRequest(ex.Message);
                    }
                }
            }
            else
            {
                return StatusCode(404,"Helytelen azonosító!");
            }
        }
    }
}
