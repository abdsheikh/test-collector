using System;
using System.Collections.Generic;
using System.Text;

namespace FT_Server_Win
{
    public class ClientItem
    {
        public string ComputerName;
        public string IPAdress;
        public string StudentID;
        public string StudentName;
        public int Status;

        public ClientItem()
        {}

        public ClientItem(string computerName, string iPAdress, string studentID, string studentName, int status)
        {
            ComputerName = computerName;
            IPAdress = iPAdress;
            StudentID = studentID;
            studentName = studentName;
            Status = 1;
        }
    }
}
