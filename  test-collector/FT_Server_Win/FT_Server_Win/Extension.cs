using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace FT_Server_Win
{
    public static class Extension
    {
        public static DataTable CreateDataTableWithHeader()
        {
            DataTable dataTableResult = new DataTable();
            dataTableResult.Columns.Add("STT", typeof(int));
            dataTableResult.Columns.Add("Tên máy", typeof(string));
            dataTableResult.Columns.Add("Địa chỉ IP", typeof(string));
            dataTableResult.Columns.Add("Mã số sinh viên", typeof(string));
            dataTableResult.Columns.Add("Họ tên sinh viên", typeof(string));
            dataTableResult.Columns.Add("Trạng thái", typeof(string));

            return dataTableResult;
        }
    }
}
