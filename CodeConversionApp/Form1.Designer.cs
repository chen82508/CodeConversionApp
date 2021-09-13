
namespace CodeConversionApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_go_convert = new System.Windows.Forms.Button();
            this.chk_save_ori_file = new System.Windows.Forms.CheckBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txt_path = new System.Windows.Forms.TextBox();
            this.btn_select_file = new System.Windows.Forms.Button();
            this.btn_select_folder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_go_convert
            // 
            this.btn_go_convert.Location = new System.Drawing.Point(220, 30);
            this.btn_go_convert.Name = "btn_go_convert";
            this.btn_go_convert.Size = new System.Drawing.Size(122, 27);
            this.btn_go_convert.TabIndex = 0;
            this.btn_go_convert.Text = "BIG5轉換UTF-8";
            this.btn_go_convert.UseVisualStyleBackColor = true;
            this.btn_go_convert.Click += new System.EventHandler(this.btn_go_convert_Click);
            // 
            // chk_save_ori_file
            // 
            this.chk_save_ori_file.AutoSize = true;
            this.chk_save_ori_file.Checked = true;
            this.chk_save_ori_file.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_save_ori_file.Location = new System.Drawing.Point(220, 63);
            this.chk_save_ori_file.Name = "chk_save_ori_file";
            this.chk_save_ori_file.Size = new System.Drawing.Size(86, 19);
            this.chk_save_ori_file.TabIndex = 1;
            this.chk_save_ori_file.Text = "保留原始檔";
            this.chk_save_ori_file.UseVisualStyleBackColor = true;
            // 
            // txt_path
            // 
            this.txt_path.Location = new System.Drawing.Point(13, 30);
            this.txt_path.Name = "txt_path";
            this.txt_path.Size = new System.Drawing.Size(201, 23);
            this.txt_path.TabIndex = 2;
            // 
            // btn_select_file
            // 
            this.btn_select_file.Location = new System.Drawing.Point(13, 60);
            this.btn_select_file.Name = "btn_select_file";
            this.btn_select_file.Size = new System.Drawing.Size(75, 23);
            this.btn_select_file.TabIndex = 3;
            this.btn_select_file.Text = "選擇檔案";
            this.btn_select_file.UseVisualStyleBackColor = true;
            this.btn_select_file.Click += new System.EventHandler(this.btn_select_file_Click);
            // 
            // btn_select_folder
            // 
            this.btn_select_folder.Location = new System.Drawing.Point(94, 60);
            this.btn_select_folder.Name = "btn_select_folder";
            this.btn_select_folder.Size = new System.Drawing.Size(75, 23);
            this.btn_select_folder.TabIndex = 4;
            this.btn_select_folder.Text = "選擇目錄";
            this.btn_select_folder.UseVisualStyleBackColor = true;
            this.btn_select_folder.Click += new System.EventHandler(this.btn_select_folder_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_select_folder);
            this.Controls.Add(this.btn_select_file);
            this.Controls.Add(this.txt_path);
            this.Controls.Add(this.chk_save_ori_file);
            this.Controls.Add(this.btn_go_convert);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_go_convert;
        private System.Windows.Forms.CheckBox chk_save_ori_file;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txt_path;
        private System.Windows.Forms.Button btn_select_file;
        private System.Windows.Forms.Button btn_select_folder;
    }
}

