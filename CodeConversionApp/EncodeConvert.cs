using System;
using System.Collections.Generic;
using System.Text;

namespace CodeConversionApp
{
    public static class EncodeConvert
    {
        public static string Convert_BIG5_to_UTF8(string path, bool is_save_ori_file)
        {
            try
            {
                if (System.IO.File.Exists(path) == false)
                {
                    return "找不到檔案！";
                }
                System.IO.FileInfo this_file = new System.IO.FileInfo(path);
                if (is_save_ori_file == true)
                {
                    string parent_path = this_file.Directory.FullName;
                    string save_path = parent_path + @"\orifile";
                    if (System.IO.Directory.Exists(save_path) == false)
                    {
                        System.IO.Directory.CreateDirectory(save_path);
                    }
                    System.IO.File.Copy(this_file.FullName, save_path + @"\" + this_file.Name);
                }

                var tmp_str = System.IO.File.ReadAllText(path, Encoding.GetEncoding("BIG5"));
                System.IO.File.WriteAllText(path, tmp_str, Encoding.UTF8);

            }
            catch (Exception e)
            {
                return e.Message;
            }

            return "";
        }
    }
}
