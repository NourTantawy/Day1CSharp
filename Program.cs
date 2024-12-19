using System;

class Program
{
    public enum Gender
    {
        Male, Female, None
    }

    public struct Employee
    {
        public int ID;
        public float salary;
        public HiringDate hiringDate;
        public Gender gender;

        public Employee()
        {
            ID = 0;
            salary = 0;
            hiringDate = new HiringDate();
            gender = Gender.None;
        }

        public Employee(int _ID, float _salary, HiringDate _hiringDate, Gender _gender)
        {
            ID = _ID; 
            salary = _salary;
            hiringDate = _hiringDate;
            gender = _gender;
        }

        public void print()
        {
            Console.WriteLine($"Employee ID: {ID}");
            Console.WriteLine($"Employee Salary: {salary:c}");
            Console.WriteLine($"Employee Hiring Date: {hiringDate.day} - {hiringDate.month} - {hiringDate.year}");
            Console.WriteLine($"Employee Gender: {gender}");
        }

        public int getID() { return ID; }
        public float getSalary() { return salary; }
        public HiringDate getHiringDate() { return hiringDate; }
        public Gender getGender() { return gender; }

        public void setID(int _ID) { ID = _ID; }
        public void setSalary(float _salary) { salary = _salary; }
        public void setGender(Gender _gender) { gender = _gender; }
        public void setHiringDate(HiringDate _hiringDate) { hiringDate = _hiringDate; }

    }

    public struct HiringDate
    {
        public int day;
        public int month;
        public int year;

        public HiringDate()
        {
            day = 0;
            month = 0;
            year = 0;
        }

        public HiringDate(int _day, int _month, int _year)
        {
            day = _day; 
            month = _month;
            year = _year;
        }

        public int getDay() { return day; }
        public int getMonth() { return month; } 
        public int getYear() { return year; }

        public void setDay(int _day) { day = _day; }
        public void setMonth(int _month) { month = _month; }
        public void setYear(int _year) { year = _year; }
    }
    static void Main(string[] args)
    {
        Employee[] employees = new Employee[3];

        employees[0].ID = 1711;
        employees[0].gender = Gender.Female;
        employees[0].salary = 100000;
        employees[0].hiringDate = new HiringDate(16, 10, 2024);

        employees[0].print();
    }
}