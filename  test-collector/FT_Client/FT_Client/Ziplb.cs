using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ICSharpCode.SharpZipLib.Checksums;
using ICSharpCode.SharpZipLib.Zip;

namespace FT_Client
{
    class Ziplb
    {
        /*
        public List<ZipEntry> GetZipFiles(ZipFile zipfil)
        {            
            List<ZipEntry> lstZip = new List<ZipEntry>();
            Enumeration zipEnum = zipfil.entries();
            while (zipEnum.hasMoreElements())
            {
                ZipEntry zip = (ZipEntry)zipEnum.nextElement();
                lstZip.Add(zip);
            }
            return lstZip;
        }
        */

        public bool Zip(string zipFileName, string[] sourceFile)
        {
            if(System.IO.File.Exists(zipFileName))
            {
                System.IO.File.Delete(zipFileName);
            }
            /*
             try
            {
                FileOutputStream filOpStrm = new FileOutputStream(zipFileName);
                ZipOutputStream zipOpStrm = new ZipOutputStream(filOpStrm);
                FileInputStream filIpStrm = null;

                foreach (string strFilName in sourceFile)
                {
                    filIpStrm = new FileInputStream(strFilName);
                    ZipEntry ze = new ZipEntry(Path.GetFileName(strFilName));
                    zipOpStrm.putNextEntry(ze);
                    sbyte[] buffer = new sbyte[1024];
                    int len = 0;

                    while ((len = filIpStrm.read(buffer)) >= 0)
                    {
                        zipOpStrm.write(buffer, 0, len);
                    }
                }

                zipOpStrm.closeEntry();
                filIpStrm.close();
                zipOpStrm.close();
                filOpStrm.close();
            }
            catch (System.Exception ex)
            {
                return false;
            }
            return true;
             * */
            Crc32 crc32 = new Crc32();
            ZipOutputStream stream = new ZipOutputStream(File.Create(zipFileName));
            stream.SetLevel(7);

            try
            {
                for (int i = 0; i < sourceFile.Length; i++)
                {
                    ZipEntry entry = new ZipEntry(Path.GetFileName(sourceFile[i]));
                    entry.DateTime = DateTime.Now;

                    using (FileStream fs = File.OpenRead(sourceFile[i]))
                    {
                        byte[] buffer = new byte[fs.Length];
                        fs.Read(buffer, 0, buffer.Length);
                        entry.Size = fs.Length;
                        fs.Close();
                        crc32.Reset();
                        crc32.Update(buffer);
                        entry.Crc = crc32.Value;
                        stream.PutNextEntry(entry);
                        stream.Write(buffer, 0, buffer.Length);
                    }
                }
                stream.Finish();
                stream.Close();
            }
            catch (System.Exception ex)
            {
                return false;
            }
            return true;
        }
    }
}
