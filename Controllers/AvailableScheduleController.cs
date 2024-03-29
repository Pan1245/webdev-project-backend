using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace houseofgriffin_api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]

    [Authorize(Roles = "ea")]

    public class CheckAvailable : ControllerBase
    {
        private readonly ICheckAvailableService _checkAvailable;
        public CheckAvailable(ICheckAvailableService checkAvailable)
        {
            _checkAvailable = checkAvailable;

        }

        [HttpGet("GetAvailableTime")]
        public async Task<ActionResult<ServiceResponse<List<GetAvailableTimeDto>>>> GetAvailableTime([FromQuery] int[] listOfStudentId, string date, int hour, int classId)
        {
            var response = await _checkAvailable.GetAvailableTime(listOfStudentId, date, hour, classId);
            return Ok(response);
        }

        [HttpGet("GetAvailableTeacher")]
        public async Task<ActionResult<ServiceResponse<List<GetAvailableTeacherDto>>>> GetAvailableTeacher(string fromTime, string toTime, string date, int classId)
        {
            var response = await _checkAvailable.GetAvailableTeacher(fromTime, toTime, date, classId);
            return Ok(response);
        }

    }
}