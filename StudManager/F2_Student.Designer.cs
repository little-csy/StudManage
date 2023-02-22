
namespace STUManagement
{
    partial class F2_Student
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F2_Student));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人课表查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.个人成绩查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.课程信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.院系信息查询ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选课ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.修改个人信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.信息查询ToolStripMenuItem,
            this.选课ToolStripMenuItem,
            this.修改个人信息ToolStripMenuItem,
            this.退出登录ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(788, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 信息查询ToolStripMenuItem
            // 
            this.信息查询ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.个人信息查询ToolStripMenuItem,
            this.个人课表查询ToolStripMenuItem,
            this.个人成绩查询ToolStripMenuItem,
            this.课程信息查询ToolStripMenuItem,
            this.院系信息查询ToolStripMenuItem});
            this.信息查询ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("信息查询ToolStripMenuItem.Image")));
            this.信息查询ToolStripMenuItem.Name = "信息查询ToolStripMenuItem";
            this.信息查询ToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.信息查询ToolStripMenuItem.Text = "信息查询";
            // 
            // 个人信息查询ToolStripMenuItem
            // 
            this.个人信息查询ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("个人信息查询ToolStripMenuItem.Image")));
            this.个人信息查询ToolStripMenuItem.Name = "个人信息查询ToolStripMenuItem";
            this.个人信息查询ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.个人信息查询ToolStripMenuItem.Text = "个人信息查询";
            this.个人信息查询ToolStripMenuItem.Click += new System.EventHandler(this.个人信息查询ToolStripMenuItem_Click_1);
            // 
            // 个人课表查询ToolStripMenuItem
            // 
            this.个人课表查询ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("个人课表查询ToolStripMenuItem.Image")));
            this.个人课表查询ToolStripMenuItem.Name = "个人课表查询ToolStripMenuItem";
            this.个人课表查询ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.个人课表查询ToolStripMenuItem.Text = "个人课表查询";
            this.个人课表查询ToolStripMenuItem.Click += new System.EventHandler(this.个人课表查询ToolStripMenuItem_Click);
            // 
            // 个人成绩查询ToolStripMenuItem
            // 
            this.个人成绩查询ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("个人成绩查询ToolStripMenuItem.Image")));
            this.个人成绩查询ToolStripMenuItem.Name = "个人成绩查询ToolStripMenuItem";
            this.个人成绩查询ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.个人成绩查询ToolStripMenuItem.Text = "个人成绩查询";
            this.个人成绩查询ToolStripMenuItem.Click += new System.EventHandler(this.个人成绩查询ToolStripMenuItem_Click);
            // 
            // 课程信息查询ToolStripMenuItem
            // 
            this.课程信息查询ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("课程信息查询ToolStripMenuItem.Image")));
            this.课程信息查询ToolStripMenuItem.Name = "课程信息查询ToolStripMenuItem";
            this.课程信息查询ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.课程信息查询ToolStripMenuItem.Text = "课程信息查询";
            this.课程信息查询ToolStripMenuItem.Click += new System.EventHandler(this.课程信息查询ToolStripMenuItem_Click);
            // 
            // 院系信息查询ToolStripMenuItem
            // 
            this.院系信息查询ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("院系信息查询ToolStripMenuItem.Image")));
            this.院系信息查询ToolStripMenuItem.Name = "院系信息查询ToolStripMenuItem";
            this.院系信息查询ToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.院系信息查询ToolStripMenuItem.Text = "院系信息查询";
            this.院系信息查询ToolStripMenuItem.Click += new System.EventHandler(this.院系信息查询ToolStripMenuItem_Click);
            // 
            // 选课ToolStripMenuItem
            // 
            this.选课ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("选课ToolStripMenuItem.Image")));
            this.选课ToolStripMenuItem.Name = "选课ToolStripMenuItem";
            this.选课ToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.选课ToolStripMenuItem.Text = "选课";
            this.选课ToolStripMenuItem.Click += new System.EventHandler(this.选课ToolStripMenuItem_Click);
            // 
            // 修改个人信息ToolStripMenuItem
            // 
            this.修改个人信息ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("修改个人信息ToolStripMenuItem.Image")));
            this.修改个人信息ToolStripMenuItem.Name = "修改个人信息ToolStripMenuItem";
            this.修改个人信息ToolStripMenuItem.Size = new System.Drawing.Size(133, 24);
            this.修改个人信息ToolStripMenuItem.Text = "修改个人信息";
            this.修改个人信息ToolStripMenuItem.Click += new System.EventHandler(this.修改个人信息ToolStripMenuItem_Click);
            // 
            // 退出登录ToolStripMenuItem
            // 
            this.退出登录ToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("退出登录ToolStripMenuItem.Image")));
            this.退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            this.退出登录ToolStripMenuItem.Size = new System.Drawing.Size(103, 24);
            this.退出登录ToolStripMenuItem.Text = "退出登录";
            this.退出登录ToolStripMenuItem.Click += new System.EventHandler(this.退出登录ToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
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
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.RowHeadersWidth = 51;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(788, 490);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // F2_Student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(788, 518);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("宋体", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "F2_Student";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "学生页面";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.F2_Student_FormClosed);
            this.Load += new System.EventHandler(this.F2_Student_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 课程信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人课表查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 院系信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选课ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出登录ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem 个人信息查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 个人成绩查询ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 修改个人信息ToolStripMenuItem;
    }
}