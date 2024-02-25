using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace StudentAttendanceManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAttendanceController : ControllerBase
    {
        // GET: api/<StudentAttendanceController>
        [HttpGet]
        public IEnumerable<StudentAttendanceDetailsModel> Get()
        {
            StudentAttendanceDetailsModel attendanceObj1 = new StudentAttendanceDetailsModel();
            StudentAttendanceDetailsModel attendanceObj2 = new StudentAttendanceDetailsModel();
            StudentAttendanceDetailsModel attendanceObj3 = new StudentAttendanceDetailsModel();
            StudentAttendanceDetailsModel attendanceObj4 = new StudentAttendanceDetailsModel();
            attendanceObj1.StudentID = 1;
            attendanceObj1.StudentName = "Anmar";
            attendanceObj1.AttendencePercentage = 96.02;

            attendanceObj2.StudentID = 2;
            attendanceObj2.StudentName = "Naseem";
            attendanceObj2.AttendencePercentage = 97.40;

            attendanceObj3.StudentID = 3;
            attendanceObj3.StudentName = "Kheder";
            attendanceObj3.AttendencePercentage = 95.32;

            attendanceObj4.StudentID = 4;
            attendanceObj4.StudentName = "Wafaa";
            attendanceObj4.AttendencePercentage = 95.89;

            List<StudentAttendanceDetailsModel> listObj = new List<StudentAttendanceDetailsModel>
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