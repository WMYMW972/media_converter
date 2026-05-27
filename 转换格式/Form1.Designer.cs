namespace 转换格式
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.image = new System.Windows.Forms.Button();
            this.redio = new System.Windows.Forms.Button();
            this.video = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.index = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ima_1 = new System.Windows.Forms.Button();
            this.del_ima = new System.Windows.Forms.Button();
            this.ima_2 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.OpenFile = new System.Windows.Forms.Button();
            this.label_ima = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panel2 = new System.Windows.Forms.Panel();
            this.del_ra = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.ra_1 = new System.Windows.Forms.Button();
            this.ra_2 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.OF_ra = new System.Windows.Forms.Button();
            this.label_ra = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.del_vid = new System.Windows.Forms.Button();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.vid_label = new System.Windows.Forms.Label();
            this.vid_bu2 = new System.Windows.Forms.Button();
            this.vid_bu1 = new System.Windows.Forms.Button();
            this.vid_bu = new System.Windows.Forms.Button();
            this.index.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.image.Location = new System.Drawing.Point(140, 243);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(80, 34);
            this.image.TabIndex = 0;
            this.image.TabStop = false;
            this.image.Text = "图片";
            this.image.UseVisualStyleBackColor = true;
            this.image.Click += new System.EventHandler(this.image_Click);
            // 
            // redio
            // 
            this.redio.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.redio.Location = new System.Drawing.Point(280, 243);
            this.redio.Name = "redio";
            this.redio.Size = new System.Drawing.Size(80, 34);
            this.redio.TabIndex = 1;
            this.redio.TabStop = false;
            this.redio.Text = "音频";
            this.redio.UseVisualStyleBackColor = true;
            this.redio.Click += new System.EventHandler(this.redio_Click);
            // 
            // video
            // 
            this.video.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.video.Location = new System.Drawing.Point(420, 243);
            this.video.Name = "video";
            this.video.Size = new System.Drawing.Size(80, 34);
            this.video.TabIndex = 2;
            this.video.TabStop = false;
            this.video.Text = "视频";
            this.video.UseVisualStyleBackColor = true;
            this.video.Click += new System.EventHandler(this.video_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(167, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "选择待转换文件类型";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // index
            // 
            this.index.Controls.Add(this.image);
            this.index.Controls.Add(this.redio);
            this.index.Controls.Add(this.video);
            this.index.Controls.Add(this.label1);
            this.index.Location = new System.Drawing.Point(3, 3);
            this.index.Name = "index";
            this.index.Size = new System.Drawing.Size(617, 439);
            this.index.TabIndex = 4;
            this.index.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ima_1);
            this.panel1.Controls.Add(this.del_ima);
            this.panel1.Controls.Add(this.ima_2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.listBox2);
            this.panel1.Controls.Add(this.OpenFile);
            this.panel1.Controls.Add(this.label_ima);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(623, 439);
            this.panel1.TabIndex = 4;
            this.panel1.Visible = false;
            // 
            // ima_1
            // 
            this.ima_1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ima_1.Location = new System.Drawing.Point(75, 79);
            this.ima_1.Name = "ima_1";
            this.ima_1.Size = new System.Drawing.Size(75, 38);
            this.ima_1.TabIndex = 7;
            this.ima_1.TabStop = false;
            this.ima_1.Text = "返回";
            this.ima_1.UseVisualStyleBackColor = true;
            this.ima_1.Click += new System.EventHandler(this.button2_Click);
            // 
            // del_ima
            // 
            this.del_ima.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.del_ima.Location = new System.Drawing.Point(75, 257);
            this.del_ima.Name = "del_ima";
            this.del_ima.Size = new System.Drawing.Size(96, 34);
            this.del_ima.TabIndex = 10;
            this.del_ima.Text = "取消选择";
            this.del_ima.UseVisualStyleBackColor = true;
            this.del_ima.Click += new System.EventHandler(this.del_ima_Click);
            // 
            // ima_2
            // 
            this.ima_2.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ima_2.Location = new System.Drawing.Point(466, 254);
            this.ima_2.Name = "ima_2";
            this.ima_2.Size = new System.Drawing.Size(90, 37);
            this.ima_2.TabIndex = 6;
            this.ima_2.TabStop = false;
            this.ima_2.Text = "转换";
            this.ima_2.UseVisualStyleBackColor = true;
            this.ima_2.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "JPG",
            "PNG",
            "BMP",
            "GIF",
            "TIFF",
            "WEBP"});
            this.comboBox1.Location = new System.Drawing.Point(466, 189);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(90, 29);
            this.comboBox1.TabIndex = 5;
            // 
            // listBox2
            // 
            this.listBox2.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox2.FormattingEnabled = true;
            this.listBox2.HorizontalScrollbar = true;
            this.listBox2.ItemHeight = 19;
            this.listBox2.Location = new System.Drawing.Point(214, 189);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(207, 194);
            this.listBox2.TabIndex = 3;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // OpenFile
            // 
            this.OpenFile.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OpenFile.Location = new System.Drawing.Point(75, 189);
            this.OpenFile.Name = "OpenFile";
            this.OpenFile.Size = new System.Drawing.Size(96, 34);
            this.OpenFile.TabIndex = 2;
            this.OpenFile.TabStop = false;
            this.OpenFile.Text = "选择文件";
            this.OpenFile.UseVisualStyleBackColor = true;
            this.OpenFile.Click += new System.EventHandler(this.OpenFile_Click);
            // 
            // label_ima
            // 
            this.label_ima.AutoSize = true;
            this.label_ima.Font = new System.Drawing.Font("宋体", 26F);
            this.label_ima.Location = new System.Drawing.Point(208, 62);
            this.label_ima.Name = "label_ima";
            this.label_ima.Size = new System.Drawing.Size(225, 35);
            this.label_ima.TabIndex = 0;
            this.label_ima.Text = "图片格式转换";
            this.label_ima.Click += new System.EventHandler(this.label2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.del_ra);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.ra_1);
            this.panel2.Controls.Add(this.ra_2);
            this.panel2.Controls.Add(this.comboBox2);
            this.panel2.Controls.Add(this.listBox1);
            this.panel2.Controls.Add(this.OF_ra);
            this.panel2.Controls.Add(this.label_ra);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(623, 439);
            this.panel2.TabIndex = 4;
            this.panel2.Visible = false;
            // 
            // del_ra
            // 
            this.del_ra.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.del_ra.Location = new System.Drawing.Point(75, 257);
            this.del_ra.Name = "del_ra";
            this.del_ra.Size = new System.Drawing.Size(96, 34);
            this.del_ra.TabIndex = 11;
            this.del_ra.Text = "取消选择";
            this.del_ra.UseVisualStyleBackColor = true;
            this.del_ra.Click += new System.EventHandler(this.del_ra_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(201, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "(NCM可转为其他格式，不能互转)";
            // 
            // ra_1
            // 
            this.ra_1.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ra_1.Location = new System.Drawing.Point(466, 254);
            this.ra_1.Name = "ra_1";
            this.ra_1.Size = new System.Drawing.Size(90, 37);
            this.ra_1.TabIndex = 8;
            this.ra_1.TabStop = false;
            this.ra_1.Text = "转换";
            this.ra_1.UseVisualStyleBackColor = true;
            this.ra_1.Click += new System.EventHandler(this.ra_1_Click);
            // 
            // ra_2
            // 
            this.ra_2.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ra_2.Location = new System.Drawing.Point(75, 79);
            this.ra_2.Name = "ra_2";
            this.ra_2.Size = new System.Drawing.Size(75, 38);
            this.ra_2.TabIndex = 8;
            this.ra_2.TabStop = false;
            this.ra_2.Text = "返回";
            this.ra_2.UseVisualStyleBackColor = true;
            this.ra_2.Click += new System.EventHandler(this.ra_2_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "MP3",
            "AAC",
            "FLAC",
            "WAV",
            "M4A",
            "OGG",
            "WMA",
            "Opus",
            "AMR",
            "AC3",
            "DTS"});
            this.comboBox2.Location = new System.Drawing.Point(466, 189);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(90, 29);
            this.comboBox2.TabIndex = 8;
            this.comboBox2.TabStop = false;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged_1);
            // 
            // listBox1
            // 
            this.listBox1.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.ItemHeight = 19;
            this.listBox1.Location = new System.Drawing.Point(214, 189);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(207, 194);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged_2);
            // 
            // OF_ra
            // 
            this.OF_ra.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.OF_ra.Location = new System.Drawing.Point(75, 189);
            this.OF_ra.Name = "OF_ra";
            this.OF_ra.Size = new System.Drawing.Size(96, 34);
            this.OF_ra.TabIndex = 8;
            this.OF_ra.TabStop = false;
            this.OF_ra.Text = "选择文件";
            this.OF_ra.UseVisualStyleBackColor = true;
            this.OF_ra.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // label_ra
            // 
            this.label_ra.AutoSize = true;
            this.label_ra.Font = new System.Drawing.Font("宋体", 26F);
            this.label_ra.Location = new System.Drawing.Point(208, 56);
            this.label_ra.Name = "label_ra";
            this.label_ra.Size = new System.Drawing.Size(225, 35);
            this.label_ra.TabIndex = 8;
            this.label_ra.Text = "音频格式转换";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.del_vid);
            this.panel3.Controls.Add(this.listBox3);
            this.panel3.Controls.Add(this.comboBox3);
            this.panel3.Controls.Add(this.vid_label);
            this.panel3.Controls.Add(this.vid_bu2);
            this.panel3.Controls.Add(this.vid_bu1);
            this.panel3.Controls.Add(this.vid_bu);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(626, 442);
            this.panel3.TabIndex = 4;
            this.panel3.Visible = false;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // del_vid
            // 
            this.del_vid.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.del_vid.Location = new System.Drawing.Point(75, 257);
            this.del_vid.Name = "del_vid";
            this.del_vid.Size = new System.Drawing.Size(96, 34);
            this.del_vid.TabIndex = 9;
            this.del_vid.Text = "取消选择";
            this.del_vid.UseVisualStyleBackColor = true;
            this.del_vid.Click += new System.EventHandler(this.del_vid_Click);
            // 
            // listBox3
            // 
            this.listBox3.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.listBox3.FormattingEnabled = true;
            this.listBox3.HorizontalScrollbar = true;
            this.listBox3.ItemHeight = 19;
            this.listBox3.Location = new System.Drawing.Point(214, 189);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(207, 194);
            this.listBox3.TabIndex = 8;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "MP4",
            "AVI",
            "MKV",
            "MOV",
            "WebM",
            "FLV",
            "WMV",
            "M4V",
            "TS",
            "MTS",
            "3GP",
            "OGV"});
            this.comboBox3.Location = new System.Drawing.Point(466, 189);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(90, 29);
            this.comboBox3.TabIndex = 8;
            // 
            // vid_label
            // 
            this.vid_label.AutoSize = true;
            this.vid_label.Font = new System.Drawing.Font("宋体", 26F);
            this.vid_label.Location = new System.Drawing.Point(208, 62);
            this.vid_label.Name = "vid_label";
            this.vid_label.Size = new System.Drawing.Size(225, 35);
            this.vid_label.TabIndex = 8;
            this.vid_label.Text = "视频格式转换";
            // 
            // vid_bu2
            // 
            this.vid_bu2.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.vid_bu2.Location = new System.Drawing.Point(466, 254);
            this.vid_bu2.Name = "vid_bu2";
            this.vid_bu2.Size = new System.Drawing.Size(90, 37);
            this.vid_bu2.TabIndex = 2;
            this.vid_bu2.Text = "转换";
            this.vid_bu2.UseVisualStyleBackColor = true;
            this.vid_bu2.Click += new System.EventHandler(this.vid_bu2_Click);
            // 
            // vid_bu1
            // 
            this.vid_bu1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.vid_bu1.Location = new System.Drawing.Point(75, 189);
            this.vid_bu1.Name = "vid_bu1";
            this.vid_bu1.Size = new System.Drawing.Size(96, 34);
            this.vid_bu1.TabIndex = 1;
            this.vid_bu1.Text = "选择文件";
            this.vid_bu1.UseVisualStyleBackColor = true;
            this.vid_bu1.Click += new System.EventHandler(this.vid_bu1_Click);
            // 
            // vid_bu
            // 
            this.vid_bu.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.vid_bu.Location = new System.Drawing.Point(75, 79);
            this.vid_bu.Name = "vid_bu";
            this.vid_bu.Size = new System.Drawing.Size(75, 38);
            this.vid_bu.TabIndex = 0;
            this.vid_bu.Text = "返回";
            this.vid_bu.UseVisualStyleBackColor = true;
            this.vid_bu.Click += new System.EventHandler(this.vid_bu_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.index);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(640, 480);
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "格式转换";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.index.ResumeLayout(false);
            this.index.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button image;
        private System.Windows.Forms.Button redio;
        private System.Windows.Forms.Button video;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel index;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label_ima;
        private System.Windows.Forms.Button OpenFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button ima_2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button ima_1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button ra_1;
        private System.Windows.Forms.Button ra_2;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label_ra;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button OF_ra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button vid_bu1;
        private System.Windows.Forms.Button vid_bu;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label vid_label;
        private System.Windows.Forms.Button vid_bu2;
        private System.Windows.Forms.Button del_ima;
        private System.Windows.Forms.Button del_ra;
        private System.Windows.Forms.Button del_vid;
    }
}

