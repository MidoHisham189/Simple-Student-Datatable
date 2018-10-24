using School.Domain.Abstract;
using School.Domain.Concerte;
using School.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace School.WebUI.Controllers
{
    public class StudentController : Controller
    {
        private IUnitOfWork UnitOfWork;

        public StudentController(IUnitOfWork UniParam )
        {
            UnitOfWork = UniParam;
        }
        // GET: Student
        public ActionResult Index()
        {

             return View();    
        }

        public JsonResult StudentsList()
        {

            
            try
            {
                var Students = UnitOfWork.students.GetAll();
                return Json(new { data = Students },
                    JsonRequestBehavior.AllowGet);
            }
            catch(Exception ex)
            {
                Logging.log(ex);
                return Json(ex.Message);
            }

            
        }


        public JsonResult getByID(int stuId)
        {
            try
            {
                var Student = UnitOfWork.students
                               .getById(stuId);

                return Json(Student, JsonRequestBehavior.AllowGet);
            }

            catch (Exception ex)
            {
                Logging.log(ex);
                return Json(ex.Message);
            }
           
        }


        public JsonResult Update(Student student)
        {
            try
            {
                var Student = UnitOfWork.students
                .getById(student.id);

                if (Student != null)
                {
                    Student.firstName = student.firstName;
                    Student.lastName = student.lastName;
                    Student.address = student.address;
                    Student.phone = student.phone;
                    Student.enrollmentDate = DateTime.Now;

                    UnitOfWork.Complete();
                }

                return Json("data has been Updated");
            }

            catch(Exception ex)
            {
                Logging.log(ex);
                return Json(ex.Message);
            }
        }



        public JsonResult Add(Student student)
        {
           try
            {
                student.enrollmentDate = DateTime.Now;
                UnitOfWork.students.Add(student);
                UnitOfWork.Complete();
                return Json("Student has been Added");
            }

            catch (Exception ex)
            {
                Logging.log(ex);
                return Json(ex.Message);
            }
        }

        public JsonResult Delete(int stuId)
        {

            try
            {
                var Student = UnitOfWork.students.getById(stuId);
                if (Student != null)
                {
                    UnitOfWork.students.remove(Student);
                    UnitOfWork.Complete();
                }

                return Json("Student has been Deleted");
            }

            catch (Exception ex)
            {
                Logging.log(ex);
                return Json(ex.Message);
            }
       
        }
}
    
}