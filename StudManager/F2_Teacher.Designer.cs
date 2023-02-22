
namespace STUManagement
{
    partial class F2_Teacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F2_Teacher));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.信息管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询个人信息ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.修改个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询学生信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.查询课表信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.成绩录入ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出系统ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.信息管理ToolStripMenuItem,
            this.成绩录入ToolStripMenuItem,
            this.退出系统ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(886, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 信息管理ToolStripMenuItem
            // 
            this.信息管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询个人信息ToolStripMenuItem,
            this.查询学生信息ToolStripMenuItem,
            this.查询课表信息ToolStripMenuItem});
            this.信息管理ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("信息管理ToolStripMenuItem.Image")));
            this.信息管理ToolStripMenuItem.Name = "信息管理ToolStripMenuItem";
            this.信息管理ToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.信息管理ToolStripMenuItem.Text = "信息管理";
            // 
            // 查询个人信息ToolStripMenuItem
            // 
            this.查询个人信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查询个人信息ToolStripMenuItem1,
            this.修改个人信息ToolStripMenuItem});
            this.查询个人信息ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("查询个人信息ToolStripMenuItem.Image")));
            this.查询个人信息ToolStripMenuItem.Name = "查询个人信息ToolStripMenuItem";
            this.查询个人信息ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.查询个人信息ToolStripMenuItem.Text = "个人信息管理";
            this.查询个人信息ToolStripMenuItem.Click += new System.EventHandler(this.查询个人信息ToolStripMenuItem_Click);
            // 
            // 查询个人信息ToolStripMenuItem1
            // 
            this.查询个人信息ToolStripMenuItem1.Name = "查询个人信息ToolStripMenuItem1";
            this.查询个人信息ToolStripMenuItem1.Size = new System.Drawing.Size(182, 26);
            this.查询个人信息ToolStripMenuItem1.Text = "查询个人信息";
            this.查询个人信息ToolStripMenuItem1.Click += new System.EventHandler(this.查询个人信息ToolStripMenuItem1_Click);
            // 
            // 修改个人信息ToolStripMenuItem
            // 
            this.修改个人信息ToolStripMenuItem.Name = "修改个人信息ToolStripMenuItem";
            this.修改个人信息ToolStripMenuItem.Size = new System.Drawing.Size(182, 26);
            this.修改个人信息ToolStripMenuItem.Text = "修改个人信息";
            this.修改个人信息ToolStripMenuItem.Click += new System.EventHandler(this.修改个人信息ToolStripMenuItem_Click);
            // 
            // 查询学生信息ToolStripMenuItem
            // 
            this.查询学生信息ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("查询学生信息ToolStripMenuItem.Image")));
            this.查询学生信息ToolStripMenuItem.Name = "查询学生信息ToolStripMenuItem";
            this.查询学生信息ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.查询学生信息ToolStripMenuItem.Text = "查询学生信息";
            this.查询学生信息ToolStripMenuItem.Click += new System.EventHandler(this.查询学生信息ToolStripMenuItem_Click);
            // 
            // 查询课表信息ToolStripMenuItem
            // 
            this.查询课表信息ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("查询课表信息ToolStripMenuItem.Image")));
            this.查询课表信息ToolStripMenuItem.Name = "查询课表信息ToolStripMenuItem";
            this.查询课表信息ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.查询课表信息ToolStripMenuItem.Text = "查询课表信息";
            this.查询课表信息ToolStripMenuItem.Click += new System.EventHandler(this.查询课表信息ToolStripMenuItem_Click);
            // 
            // 成绩录入ToolStripMenuItem
            // 
            this.成绩录入ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("成绩录入ToolStripMenuItem.Image")));
            this.成绩录入ToolStripMenuItem.Name = "成绩录入ToolStripMenuItem";
            this.成绩录入ToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.成绩录入ToolStripMenuItem.Text = "成绩录入";
            this.成绩录入ToolStripMenuItem.Click += new System.EventHandler(this.成绩录入ToolStripMenuItem_Click);
            // 
            // 退出系统ToolStripMenuItem
            // 
            this.退出系统ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("退出系统ToolStripMenuItem.Image")));
            this.退出系统ToolStripMenuItem.Name = "退出系统ToolStripMenuItem";
            this.退出系统ToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.退出系统ToolStripMenuItem.Text = "退出系统";
            this.退出系统ToolStripMenuItem.Click += new System.EventHandler(this.退出系统ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.Color.CornflowerBlue;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(886, 501);
            this.dataGridView1.TabIndex = 3;
            // 
            // F2_Teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(886, 529);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F2_Teacher";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "教师页面";
            this.Load += new System.EventHandler(this.F2_Teacher_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 信息管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询个人信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询学生信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询课表信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 成绩录入ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 查询个人信息ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 修改个人信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出系统ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}