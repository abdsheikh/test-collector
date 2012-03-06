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
        public string Birthday;
        public int Status;
        public int SentTimes;

        public ClientItem()
        {}

        public ClientItem(string computerName, string iPAdress, string studentID, string studentName, String birthday, int status)
        {
            ComputerName = computerName;
            IPAdress = iPAdress;
            StudentID = studentID;
            StudentName = studentName;
            Birthday = birthday;
            Status = 1;
            SentTimes = 0;
        }
    }
}
