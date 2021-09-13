using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeConversionApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            // 初始化BIG5語系編碼
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);

            InitializeComponent();
        }

        private void btn_go_convert_Click(object sender, EventArgs e)
        {
            if (this.txt_path.Text == "")
            {
                MessageBox.Show("請選擇檔案/目錄");
            }
            else
            {
                string this_path = this.txt_path.Text;
                if (System.IO.File.Exists(this_path) == true)
                {
                    //MessageBox.Show("檔案");
                    var result = EncodeConvert.Convert_BIG5_to_UTF8(this_path, this.chk_save_ori_file.Checked);
                    if (result != "")
                    {
                        MessageBox.Show($"轉換失敗!{result}");
                    }
                }
                else if (System.IO.Directory.Exists(this_path) == true)
                {
                    //MessageBox.Show("目錄");
                    List<string> file_list = General.GetFileList(this_path);
                    foreach (var item in file_list)
                    {
                        var result = EncodeConvert.Convert_BIG5_to_UTF8(item, this.chk_save_ori_file.Checked);
                        if (result != "")
                        {
                            MessageBox.Show($"轉換失敗!{result}");
                            return;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("路徑錯誤");
                }
                MessageBox.Show($"轉換完畢!");
            }
        }

        private void btn_select_file_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            file.ShowDialog();
            this.txt_path.Text = file.FileName;
        }

        private void btn_select_folder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog path = new FolderBrowserDialog();
            path.ShowDialog();
            this.txt_path.Text = path.SelectedPath;
        }
    }
}
