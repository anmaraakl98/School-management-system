using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace StudentLectureManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentLectureController : ControllerBase
    {
        // GET: api/<StudentLectureController>
        [HttpGet]
        public IEnumerable<StudentLectureDetailsModel> Get()
        {
            StudentLectureDetailsModel attendanceObj1 = new StudentLectureDetailsModel();
            StudentLectureDetailsModel attendanceObj2 = new StudentLectureDetailsModel();
            StudentLectureDetailsModel attendanceObj3 = new StudentLectureDetailsModel();
            StudentLectureDetailsModel attendanceObj4 = new StudentLectureDetailsModel();
            attendanceObj1.StudentID = 1;
            attendanceObj1.StudentName = "Anmar";
            attendanceObj1.LectureName = "WDC";

            attendanceObj2.StudentID = 2;
            attendanceObj2.StudentName = "Naseem";
            attendanceObj2.LectureName = "WDC";

            attendanceObj3.StudentID = 3;
            attendanceObj3.StudentName = "Kheder";
            attendanceObj3.LectureName = "WDC";

            attendanceObj4.StudentID = 4;
            attendanceObj4.StudentName = "Wafaa";
            attendanceObj4.LectureName = "WDC";

            List<StudentLectureDetailsModel> listObj = new List<StudentLectureDetailsModel>
            {
                attendanceObj1,
                attendanceObj2,
                attendanceObj3,
                attendanceObj4
            };
            return listObj;
        }
    }
}