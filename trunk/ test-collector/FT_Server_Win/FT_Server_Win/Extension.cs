using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Net.Sockets;

namespace FT_Server_Win
{
    public static class Extension
    {
        #region Client Status
        public const int CONNECTED = 1;
        public const int SENDING = 2;
        public const int SENT = 3;
        public const int DISCONNECTED = 4;
        #endregion

        #region Server Status Text
        public const string SERVER_STARTED = "Đã bật kết nối!";
        public const string SERVER_STOPPED = "Đã tắt kết nối!";
        public const string SERVER_IP = "Địa chỉ IP: ";
        public const string SERVER_PORT = "Cổng: ";
        public const string SERVER_NAME = "Tên máy: ";
        #endregion

        #region Client Information Fields
        public const int COMPUTERNAME = 3;
        public const int STUDENTNAME = 1;
        public const int STUDENTID = 0;
        public const int BIRTHDAY = 2;
        #endregion

        #region COLUMN Index
        public const int COLUMN_ITEMINDEX = 0;
        public const int COLUMN_COMPUTERNAME = 1;
        public const int COLUMN_IPADDRESS = 2;
        public const int COLUMN_STUDENTID = 3;
        public const int COLUMN_STUDENTNAME = 4;
        public const int COLUMN_BIRTHDAY = 5;
        public const int COLUMN_CLIENTSTATUS = 6;
        public const int COLUMN_SUBMITTIMES = 7;
        #endregion

        #region constant strings
        public const string STRING_CONNECTED = "Đã kết nối";
        public const string STRING_SENDING = "Đang gửi bài...";
        public const string STRING_SENT = "Đã gửi";
        public const string STRING_DISCONNECTED = "Gửi hoàn tất";
        #endregion
        public static DataTable CreateDataTableWithHeader()
        {
            DataTable dataTableResult = new DataTable();
            dataTableResult.Columns.Add("STT", typeof(int));
            dataTableResult.Columns.Add("Tên máy", typeof(string));
            dataTableResult.Columns.Add("Địa chỉ IP", typeof(string));
            dataTableResult.Columns.Add("Mã số sinh viên", typeof(string));
            dataTableResult.Columns.Add("Họ tên sinh viên", typeof(string));
            dataTableResult.Columns.Add("Ngày sinh", typeof(string));
            dataTableResult.Columns.Add("Trạng thái", typeof(string));
            dataTableResult.Columns.Add("Lần nộp", typeof(int));

            DataColumn[] primaryKey = new DataColumn[1];
            primaryKey[0] = dataTableResult.Columns[2];
            dataTableResult.PrimaryKey = primaryKey;

            return dataTableResult;
        }

        public static string GetMessage(int status)
        {
            string message = String.Empty;
            switch (status)
            {
                case CONNECTED:
                    message = STRING_CONNECTED;
                    break;
                case SENDING:
                    message = STRING_SENDING;
                    break;
                case SENT:
                    message = STRING_SENT;
                    break;
                case DISCONNECTED:
                    message = STRING_DISCONNECTED;
                    break;
            }
            return message;
        }

        public static int GetStatusCode(String message)
        {
            if (message == STRING_CONNECTED)
                return CONNECTED;
            else
                if (message == STRING_SENT)
                    return SENT;
                else
                    if (message == STRING_SENDING)
                        return SENDING;
                    else
                        if (message == STRING_DISCONNECTED)
                            return DISCONNECTED;
                        else return -1;
        }

        public static string getPortString(int port)
        {
            return SERVER_PORT + port.ToString();
        }

        public static string getIPAdressString(string IPAdress)
        {
            return SERVER_IP + IPAdress;
        }

        public static int GetIndex(List<ClientItem> currentList, string IPAdress)
        {
            foreach (ClientItem item in currentList)
            {
                if (item.IPAdress == IPAdress)
                    return currentList.IndexOf(item);
            }
            return -1;
        }

    }

    public struct ClientObject
    {
        public Socket clientSocket;
        public ClientItem informationItem;
    }


    public class Clocker
    {
        private int m_Hours;
        private int m_Minutes;
        private int m_Seconds;

        public Clocker()
        {
            m_Hours = 0;
            m_Minutes = 0;
            m_Seconds = 0;
        }

        public void AddSecond()
        {
            m_Seconds++;
            if (m_Seconds >= 60)
            {
                m_Minutes++;
                m_Seconds = 0;
            }
            if (m_Minutes >= 60)
            {
                m_Hours++;
                m_Minutes = 0;
            }
        }

        public String GetTimeText()
        {
            String second = m_Seconds.ToString();
            if (m_Seconds < 10)
                second = "0" + second;
            String minute = m_Minutes.ToString();
            if (m_Minutes < 10)
                minute = "0" + minute;
            String hour = m_Hours.ToString();
            if (m_Hours < 10)
                hour = "0" + hour;
            return String.Format("{0}:{1}:{2}", hour, minute, second);
        }
    }
}
