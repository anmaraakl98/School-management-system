using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace StudentAdmissionManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentAdmissionController : ControllerBase
    {
        // GET: api/<StudentAdmissionController>
        [HttpGet]
        public IEnumerable<StudentAdmissionDetailsModel> Get()
        {
            StudentAdmissionDetailsModel admissionobj1 = new StudentAdmissionDetailsModel();
            StudentAdmissionDetailsModel admissionobj2 = new StudentAdmissionDetailsModel();
            StudentAdmissionDetailsModel admissionobj3 = new StudentAdmissionDetailsModel();
            StudentAdmissionDetailsModel admissionobj4 = new StudentAdmissionDetailsModel();

            admissionobj1.StudentID = 1;
            admissionobj1.StudentName = "Anmar";
            admissionobj1.StudentClass = "C1";
            admissionobj1.DateofJoining = DateTime.Now;

            admissionobj2.StudentID = 2;
            admissionobj2.StudentName = "Naseem";
            admissionobj2.StudentClass = "C2";
            admissionobj2.DateofJoining = DateTime.Now;

            admissionobj3.StudentID = 3;
            admissionobj3.StudentName = "Kheder";
            admissionobj3.StudentClass = "C3";
            admissionobj3.DateofJoining = DateTime.Now;

            admissionobj4.StudentID = 4;
            admissionobj4.StudentName = "Wafaa";
            admissionobj4.StudentClass = "C4";
            admissionobj4.DateofJoining = DateTime.Now;

            List<StudentAdmissionDetailsModel> listofobj = new List<StudentAdmissionDetailsModel>
            {
                admissionobj1,
                admissionobj2,
                admissionobj3,
                admissionobj4
            };
            return listofobj;
        }
    }
}