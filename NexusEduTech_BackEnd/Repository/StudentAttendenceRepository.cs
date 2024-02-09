using NexusEduTech_BackEnd.Models;
using AutoMapper;
using NexusEduTech_BackEnd.DTOs;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using System.Drawing;
namespace NexusEduTech_BackEnd.Repository
{
    public class StudentAttendenceRepository : IStudentAttendence
    {
        private readonly MyContext _context;
        private readonly IMapper _mapper;

        public StudentAttendenceRepository(MyContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public void AddStudentAttendence(StudentAttendenceDTO data)
        {
            try
            {
                var item = _mapper.Map<StudentAttendence>(data);
                item.AttendanceDate= DateTime.Now;
                _context.StudentAttendences.Add(item);
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public AttendenceResult GetStudAttendenceById(int sid)
        {
            try
            {
                AttendenceResult r = new AttendenceResult();
                var item = _context.StudentAttendences.Where(s=>s.StudentId == sid).ToList();
                var NoOfPresent = 0;
                /*var dates = item.Count();*/
                int TotalWorkingDays = item.Count();
                foreach (var i in item)
                {

                    if (i.Status.Equals("Present"))
                    {
                        NoOfPresent++;
                    }

                }
                int NoOfAbsent = TotalWorkingDays - NoOfPresent;


                r.TotalWorkingDays = TotalWorkingDays;
                r.NoOfPresent = NoOfPresent;
                r.NoOfAbsent = NoOfAbsent;
                return r;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public List<StudentAttendenceDTO> GetStudentAttendencebyMonth(int month)
        {
            try
            {
                var studattendences = _context.StudentAttendences.Where(
                      x => x.AttendanceDate.Month == month).ToList();
                var item = _mapper.Map<List<StudentAttendenceDTO>>(studattendences);
                return item;

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void Update(StudentAttendenceDTO data)
        {
            try
            {
                var _item = _mapper.Map<StudentAttendence>(data);
                _context.StudentAttendences.Update(_item );
                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public List<AttendenceLayout> GetAttendenceByClassStdSec(string std, string sec)
        {
            try
            {
                List<AttendenceLayout> result = (from s in _context.Students
                              join i in _context.Class
                              on s.ClassId equals i.ClassId
                              join a in _context.StudentAttendences
                              on s.StudentId equals a.StudentId
                              where i.Standard == std && i.Section== sec
                              select new AttendenceLayout()
                              {
                                  name = s.Name,
                                 RollNo = s.RegistrationNumber,
                                  Status = a.Status
                              }
                               ).ToList();
                //Console.WriteLine(result.ToString());
                return result;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
