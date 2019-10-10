using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataInterface
{
    public interface ICourse
    {
        public void AddCourse(string courseName, Teacher teacherName, int roomName){}
    }
}