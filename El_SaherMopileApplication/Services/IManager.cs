using El_SaherMopileApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace El_SaherMopileApplication.Services
{
	public interface IManager
	{
        public static Student student { get; set; } = new Student();

        public Task<List<Student>> GetStudents();
        public Task<Student> GetStudentById(int id);
        public Task<ServiceResponse<Student>> GetStudentByNameAndPhoneNumber(string Name, string PhoneNumber);
        public Task<List<Student>> GetExcellentStudents(int CourseId);

		public Task<bool> ISValid(string UserName, string PhoneNumber);



	}
}
