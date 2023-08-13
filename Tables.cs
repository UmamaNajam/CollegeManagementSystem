using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2
{
    public class Student
    {
        public string username {get; set;}
        public string password { get; set; }
        public Student()
        {
            username = password = "";
        }
    }
    public class StudentInfo
    {
        public string RollNumber { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string CNIC { get; set; }
        public DateTime DOB { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }
        public int Batch { get; set; }

        public StudentInfo()
        {
            this.RollNumber = "";
            this.FName = "";
                this.LName = "";
                this.CNIC = "";
                this.DOB = new DateTime(2018,06,14);
                this.PhoneNo = "";
                this.Address ="";
                this.Batch = 0;
        }
        
    }
    public class facultyLogin
    {
        public string username { get; set; }
        public string password { get; set; }

        public facultyLogin()
        {
            this.username = "";
            this.password = "";
        }
    }
    public class Faculty
    {
        public string FacID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string CNIC { get; set; }
        public DateTime JoinDate { get; set; }
        public string PhoneNo { get; set; }
        public string Address { get; set; }

        public Faculty()
        {
            this.FacID = "";
            this.FName = "";
            this.LName = "";
            this.CNIC = "";
            this.JoinDate = new DateTime(2018, 06, 14);
            this.PhoneNo = "";
            this.Address = "";
        }
    }
    public class adminLogin
    {
        public string username { get; set; }
        public string password { get; set; }

        public adminLogin()
        {
            this.username = "";
            this.password = "";
        }
    }
    public class Course
    {
        public string CourseID { get; set; }
        public string CourseName { get; set; }

        public Course()
        {
            this.CourseID = "";
            this.CourseName = "";
        }
    }
    public class YearInfo
    {
        public string YearID { get; set; }
        public string YearName { get; set; }

        public YearInfo()
        {
            this.YearID = "";
            this.YearName = "";
        }
    }
    public class Enrolled
    {
        public string RollNo { get; set; }
        public string CID { get; set; }
        public string YearID { get; set; }
        public string SlotID { get; set; }

        public Enrolled()
        {
            this.RollNo = "";
            this.CID = "";
            this.YearID = "";
            this.SlotID = "";
        }
    }
    public class Section
    {
        public string SlotID { get; set; }
        public string CID { get; set; }

        public Section()
        {
            this.SlotID = "";
            this.CID = "";
        }
    }
    public class slot
{
	public string SecID {get;set;}
	public string SecName {get;set;}

	public slot()
	{
		this.SecID = "";
		this.SecName = "";
	}
}
    public class Teacher
    {
        public string CID { get; set; }
        public string YearID { get; set; }
        public string FacID { get; set; }
        public string SecID { get; set; }
        public int Seats { get; set; }

        public Teacher()
        {
            this.CID = "";
            this.YearID = "";
            this.FacID = "";
            this.SecID = "";
            this.Seats = 0;
        }
    }
    public class FeeInfo
    {
        public string CID { get; set; }
        public int Fee { get; set; }

        public FeeInfo()
        {
            this.CID = "";
            this.Fee = 0;
        }
    }
    public class FeeStat
    {
        public string RollNo { get; set; }
        public string Status { get; set; }
        public int Due { get; set; }
        public string YearID { get; set; }

        public FeeStat()
        {
            this.RollNo = "";
            this.Status = "";
            this.Due = 0;
            this.YearID = "";
        }
    }
    public class AdminInfo
    {
        public string AdID { get; set; }
        public string Description { get; set; }

        public AdminInfo()
        {
            this.AdID = "";
            this.Description = "";
        }
    }
    public class Attendance
{
	public string RollNumber {get;set;}
	public string CID {get;set;}
	public string YearID {get;set;}
	public DateTime date {get;set;}
	public string Status {get;set;}
	public string SecID {get;set;}
	

	public Attendance()
	{
		this.RollNumber = "";
		this.CID = "";
		this.YearID = "";
        this.date = new DateTime(2018, 06, 14); 
		this.Status = "";
		this.SecID = "";
	}
}
    public class Grading
    {
        public string RollNumber { get; set; }
        public string CID { get; set; }
        public string YearID { get; set; }
        public double GPA { get; set; }

        public Grading()
        {
            this.RollNumber = "";
            this.CID = "";
            this.YearID = "";
            this.GPA = 0;
        }
    }
    public class Review
    {
        public string FacID { get; set; }
        public string SecID { get; set; }
        public string YearID { get; set; }
        public string CID { get; set; }
        public string Satisfied { get; set; }
        public string Improvement { get; set; }
        public string RollNumber { get; set; }

        public Review()
        {
            this.FacID = "";
            this.SecID = "";
            this.YearID = "";
            this.CID = "";
            this.Satisfied = "";
            this.Improvement = "";
            this.RollNumber = "";
        }
    }

}