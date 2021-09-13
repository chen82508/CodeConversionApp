using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConversionApp
{
    public static class General
    {
        public static List<string> GetFileList(string path)
        {
            List<string> file_list = new List<string>();
            if (System.IO.Directory.Exists(path) == false)
            {
                throw new Exception("找不到目錄，請重新確認傳入參數");
            }
            System.IO.DirectoryInfo folder = new System.IO.DirectoryInfo(path);
            foreach (var item in folder.GetDirectories())
            {
                file_list.AddRange(GetFileList(item.FullName));
            }
            foreach (var item in folder.GetFiles())
            {
                file_list.Add(item.FullName);
            }
            return file_list;
        }
    }
}
