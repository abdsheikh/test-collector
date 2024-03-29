﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Windows.Forms;

namespace FT_Client
{
    class ReadWriteToFile
    {
        private FileStream fStream;
        private StreamReader rdFile;

        public StreamReader RdFile
        {
            get { return rdFile; }
            set { rdFile = value; }
        }
        private StreamWriter wrFile;

        public StreamWriter WrFile
        {
            get { return wrFile; }
            set { wrFile = value; }
        }
        public ReadWriteToFile()
        {
            //  rdFile = new StreamReader;
            //wrFile = new StreamWriter;
        }
        public int CheckPathFile(string pathFile)
        {
            if (!File.Exists(pathFile))
            {
                try
                {
                    FileStream f=File.Create(pathFile);
                    f.Close();
                    return 1;
                }
                catch (System.Exception ex)
                {
                    return 0;
                }
            }
            else
            {
                return 1;
            }
        }
        public bool WriteToFile(string pathFile, string[] a)
        {
            if (CheckPathFile(pathFile) == 1)
            {
                fStream = new FileStream(pathFile, FileMode.Create);
                wrFile = new StreamWriter(fStream);                
            }
            else
            {
                wrFile = File.CreateText(pathFile);
            }
            try
            {
                foreach (string temp in a)
                {
                    wrFile.WriteLine(temp);
                }
            }
            catch (System.Exception ex)
            {

            }
            finally
            {
                wrFile.Close();
            }
            return true;
        }
        public string[] ReadFromFile(string pathFile)
        {
            string[] temp = new string[5];

            fStream = new FileStream(pathFile, FileMode.OpenOrCreate);
            rdFile = new StreamReader(fStream);
            string a;
            int i = 0;
            do
            {
                a = rdFile.ReadLine();
                temp[i] = a;
                i++;
                if (i >= 5) break;
            } while (a != null);
            rdFile.Close();
            return temp;
        }
        public bool CheckPathFolder(string pathFolder)
        {
            if (!Directory.Exists(pathFolder))
            {
                try
                {
                    Directory.CreateDirectory(pathFolder);
                    return true;
                }
                catch (System.Exception ex)
                {
                    return false;
                }
            }
            return true;
        }
    }
    public class ConvertTiengVietKoDau
    {
        public string Convert(string text)
        {
            //Ky tu dac biet

            for (int i = 32; i < 48; i++)
            {
                text = text.Replace(((char)i).ToString(), " ");
            }
            /*
            text = text.Replace(".", "-");
            text = text.Replace(" ", "-");
            text = text.Replace(",", "-");
            text = text.Replace(";", "-");
            text = text.Replace(":", "-");
            */
            //'Dấu Ngang
            text = text.Replace("A", "A");
            text = text.Replace("a", "a");
            text = text.Replace("Ă", "A");
            text = text.Replace("ă", "a");
            text = text.Replace("Â", "A");
            text = text.Replace("â", "a");
            text = text.Replace("E", "E");
            text = text.Replace("e", "e");
            text = text.Replace("Ê", "E");
            text = text.Replace("ê", "e");
            text = text.Replace("I", "I");
            text = text.Replace("i", "i");
            text = text.Replace("O", "O");
            text = text.Replace("o", "o");
            text = text.Replace("Ô", "O");
            text = text.Replace("ô", "o");
            text = text.Replace("Ơ", "O");
            text = text.Replace("ơ", "o");
            text = text.Replace("U", "U");
            text = text.Replace("u", "u");
            text = text.Replace("Ư", "U");
            text = text.Replace("ư", "u");
            text = text.Replace("Y", "Y");
            text = text.Replace("y", "y");

            //    'Dấu Huyền
            text = text.Replace("À", "A");
            text = text.Replace("à", "a");
            text = text.Replace("Ằ", "A");
            text = text.Replace("ằ", "a");
            text = text.Replace("Ầ", "A");
            text = text.Replace("ầ", "a");
            text = text.Replace("È", "E");
            text = text.Replace("è", "e");
            text = text.Replace("Ề", "E");
            text = text.Replace("ề", "e");
            text = text.Replace("Ì", "I");
            text = text.Replace("ì", "i");
            text = text.Replace("Ò", "O");
            text = text.Replace("ò", "o");
            text = text.Replace("Ồ", "O");
            text = text.Replace("ồ", "o");
            text = text.Replace("Ờ", "O");
            text = text.Replace("ờ", "o");
            text = text.Replace("Ù", "U");
            text = text.Replace("ù", "u");
            text = text.Replace("Ừ", "U");
            text = text.Replace("ừ", "u");
            text = text.Replace("Ỳ", "Y");
            text = text.Replace("ỳ", "y");

            //'Dấu Sắc
            text = text.Replace("Á", "A");
            text = text.Replace("á", "a");
            text = text.Replace("Ắ", "A");
            text = text.Replace("ắ", "a");
            text = text.Replace("Ấ", "A");
            text = text.Replace("ấ", "a");
            text = text.Replace("É", "E");
            text = text.Replace("é", "e");
            text = text.Replace("Ế", "E");
            text = text.Replace("ế", "e");
            text = text.Replace("Í", "I");
            text = text.Replace("í", "i");
            text = text.Replace("Ó", "O");
            text = text.Replace("ó", "o");
            text = text.Replace("Ố", "O");
            text = text.Replace("ố", "o");
            text = text.Replace("Ớ", "O");
            text = text.Replace("ớ", "o");
            text = text.Replace("Ú", "U");
            text = text.Replace("ú", "u");
            text = text.Replace("Ứ", "U");
            text = text.Replace("ứ", "u");
            text = text.Replace("Ý", "Y");
            text = text.Replace("ý", "y");

            //'Dấu Hỏi
            text = text.Replace("Ả", "A");
            text = text.Replace("ả", "a");
            text = text.Replace("Ẳ", "A");
            text = text.Replace("ẳ", "a");
            text = text.Replace("Ẩ", "A");
            text = text.Replace("ẩ", "a");
            text = text.Replace("Ẻ", "E");
            text = text.Replace("ẻ", "e");
            text = text.Replace("Ể", "E");
            text = text.Replace("ể", "e");
            text = text.Replace("Ỉ", "I");
            text = text.Replace("ỉ", "i");
            text = text.Replace("Ỏ", "O");
            text = text.Replace("ỏ", "o");
            text = text.Replace("Ổ", "O");
            text = text.Replace("ổ", "o");
            text = text.Replace("Ở", "O");
            text = text.Replace("ở", "o");
            text = text.Replace("Ủ", "U");
            text = text.Replace("ủ", "u");
            text = text.Replace("Ử", "U");
            text = text.Replace("ử", "u");
            text = text.Replace("Ỷ", "Y");
            text = text.Replace("ỷ", "y");

            //'Dấu Ngã    
            text = text.Replace("Ã", "A");
            text = text.Replace("ã", "a");
            text = text.Replace("Ẵ", "A");
            text = text.Replace("ẵ", "a");
            text = text.Replace("Ẫ", "A");
            text = text.Replace("ẫ", "a");
            text = text.Replace("Ẽ", "E");
            text = text.Replace("ẽ", "e");
            text = text.Replace("Ễ", "E");
            text = text.Replace("ễ", "e");
            text = text.Replace("Ĩ", "I");
            text = text.Replace("ĩ", "i");
            text = text.Replace("Õ", "O");
            text = text.Replace("õ", "o");
            text = text.Replace("Ỗ", "O");
            text = text.Replace("ỗ", "o");
            text = text.Replace("Ỡ", "O");
            text = text.Replace("ỡ", "o");
            text = text.Replace("Ũ", "U");
            text = text.Replace("ũ", "u");
            text = text.Replace("Ữ", "U");
            text = text.Replace("ữ", "u");
            text = text.Replace("Ỹ", "Y");
            text = text.Replace("ỹ", "y");

            //'Dẫu Nặng
            text = text.Replace("Ạ", "A");
            text = text.Replace("ạ", "a");
            text = text.Replace("Ặ", "A");
            text = text.Replace("ặ", "a");
            text = text.Replace("Ậ", "A");
            text = text.Replace("ậ", "a");
            text = text.Replace("Ẹ", "E");
            text = text.Replace("ẹ", "e");
            text = text.Replace("Ệ", "E");
            text = text.Replace("ệ", "e");
            text = text.Replace("Ị", "I");
            text = text.Replace("ị", "i");
            text = text.Replace("Ọ", "O");
            text = text.Replace("ọ", "o");
            text = text.Replace("Ộ", "O");
            text = text.Replace("ộ", "o");
            text = text.Replace("Ợ", "O");
            text = text.Replace("ợ", "o");
            text = text.Replace("Ụ", "U");
            text = text.Replace("ụ", "u");
            text = text.Replace("Ự", "U");
            text = text.Replace("ự", "u");
            text = text.Replace("Ỵ", "Y");
            text = text.Replace("ỵ", "y");
            text = text.Replace("Đ", "D");
            text = text.Replace("đ", "d");
            return text;
        }
    }
    class ProcessingIpLan
    {
        public ProcessingIpLan()
        {

        }
        public IPAddress[] GetAllUnicastAddresses_Old()
        {
            // By passing an empty string to GetHostEntry we receive all the IP addresses on the local machine
            // This breaks on Mono
            IPHostEntry LocalEntry = Dns.GetHostEntry("");
            return LocalEntry.AddressList;
        }

        public IPAddress[] GetAllUnicastAddresses_New()
        {
            // This works on both Mono and .NET , but there is a difference: it also
            // includes the LocalLoopBack so we need to filter that one out
            List<IPAddress> Addresses = new List<IPAddress>();
            // Obtain a reference to all network interfaces in the machine
            NetworkInterface[] adapters = NetworkInterface.GetAllNetworkInterfaces();
            foreach (NetworkInterface adapter in adapters)
            {
                IPInterfaceProperties properties = adapter.GetIPProperties();
                foreach (IPAddressInformation uniCast in properties.UnicastAddresses)
                {
                    // Ignore loop-back addresses & IPv6
                    if (!IPAddress.IsLoopback(uniCast.Address) && uniCast.Address.AddressFamily != AddressFamily.InterNetworkV6)
                        Addresses.Add(uniCast.Address);
                }

            }
            return Addresses.ToArray();
        }
        public string GetHostNameFromIpAdress(IPAddress ad)
        {
            string hostname = "UnIdentified";
            try
            {
                IPHostEntry ip = Dns.GetHostByAddress(ad);
                hostname = ip.HostName;
                return hostname;
            }
            catch (System.Exception ex)
            {
                return hostname;
            }
        }
        public string GetIpFromHostName(string hostname)
        {
            try
            {
                return Dns.GetHostByName(hostname).AddressList[0].ToString();
            }
            catch (System.Exception ex)
            {
                return "UnIdentified";
            }
        }        
    }
    class Utilities_CLient
    {
        public Utilities_CLient()
        {

        }
        public int CheckBirthday(DateTimePicker birthday)
        {
            DateTime now = new DateTime();
            DateTime bday = birthday.Value.Date;            
            //DateTime temp=now.date
            return DateTime.Compare(now, bday);            
        }

        public bool checkFileType(string pathfile)
        {
            try
            {
                string e = Path.GetExtension(pathfile);
                if (e == ".docx" || e == ".doc" || e == ".pdf" || e == ".txt" || e == ".rar" || e == ".zip" || e == ".xls" || e == ".xlsx" || e == ".jpg" || e == ".gif" || e == ".png")
                    return true;
                else return false;
            }
            catch (System.Exception ex)
            {
                return false;
            }
        }
        public bool CheckFileSize(string pathfile,long fileSize) //check file size (kb)
        {
            try
            {
                FileInfo f = new FileInfo(pathfile);
                if ((f.Length / 1024) > fileSize) return false;
                else return true;
            }
            catch (System.Exception ex)
            {
            	return false;
            }
        }
    }
}
