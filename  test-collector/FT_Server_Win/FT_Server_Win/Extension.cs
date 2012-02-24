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

        public static DataTable CreateDataTableWithHeader()
        {
            DataTable dataTableResult = new DataTable();
            dataTableResult.Columns.Add("STT", typeof(int));
            dataTableResult.Columns.Add("Tên máy", typeof(string));
            dataTableResult.Columns.Add("Địa chỉ IP", typeof(string));
            dataTableResult.Columns.Add("Mã số sinh viên", typeof(string));
            dataTableResult.Columns.Add("Họ tên sinh viên", typeof(string));
            dataTableResult.Columns.Add("Trạng thái", typeof(string));

            DataColumn[] primaryKey = new DataColumn[1];
            primaryKey[0] = dataTableResult.Columns[3];
            dataTableResult.PrimaryKey = primaryKey;

            return dataTableResult;
        }
    }

    public struct ClientObject
    {
        public Socket clientSocket;
        public ClientItem clientInformation;
    }
}
