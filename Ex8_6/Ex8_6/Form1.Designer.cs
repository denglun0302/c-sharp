namespace Ex8_6
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.maiMenu = new System.Windows.Forms.MenuStrip();
            this.miNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewDir = new System.Windows.Forms.ToolStripMenuItem();
            this.视图ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建NToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miSep = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.新建NToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.miDelDir = new System.Windows.Forms.ToolStripMenuItem();
            this.miLargeIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.miSmallIcon = new System.Windows.Forms.ToolStripMenuItem();
            this.miList = new System.Windows.Forms.ToolStripMenuItem();
            this.miDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tvDir = new System.Windows.Forms.TreeView();
            this.lvFile = new System.Windows.Forms.ListView();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.txtPass = new System.Windows.Forms.ToolStripTextBox();
            this.maiMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // maiMenu
            // 
            this.maiMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.maiMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNewFile,
            this.miNewDir,
            this.视图ToolStripMenuItem});
            this.maiMenu.Location = new System.Drawing.Point(0, 0);
            this.maiMenu.Name = "maiMenu";
            this.maiMenu.Size = new System.Drawing.Size(660, 28);
            this.maiMenu.TabIndex = 0;
            this.maiMenu.Text = "menuStrip1";
            // 
            // miNewFile
            // 
            this.miNewFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建NToolStripMenuItem,
            this.miOpenFile,
            this.miDelFile,
            this.miSep,
            this.miExit});
            this.miNewFile.Name = "miNewFile";
            this.miNewFile.Size = new System.Drawing.Size(51, 24);
            this.miNewFile.Text = "文件";
            // 
            // miNewDir
            // 
            this.miNewDir.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建NToolStripMenuItem1,
            this.miDelDir});
            this.miNewDir.Name = "miNewDir";
            this.miNewDir.Size = new System.Drawing.Size(51, 24);
            this.miNewDir.Text = "目录";
            // 
            // 视图ToolStripMenuItem
            // 
            this.视图ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miLargeIcon,
            this.miSmallIcon,
            this.miList,
            this.miDetail});
            this.视图ToolStripMenuItem.Name = "视图ToolStripMenuItem";
            this.视图ToolStripMenuItem.Size = new System.Drawing.Size(51, 24);
            this.视图ToolStripMenuItem.Text = "视图";
            // 
            // 新建NToolStripMenuItem
            // 
            this.新建NToolStripMenuItem.Name = "新建NToolStripMenuItem";
            this.新建NToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.新建NToolStripMenuItem.Text = "新建（&N）";
            // 
            // miOpenFile
            // 
            this.miOpenFile.Name = "miOpenFile";
            this.miOpenFile.Size = new System.Drawing.Size(181, 26);
            this.miOpenFile.Text = "打开（&O）";
            // 
            // miDelFile
            // 
            this.miDelFile.Name = "miDelFile";
            this.miDelFile.Size = new System.Drawing.Size(181, 26);
            this.miDelFile.Text = "删除（&D)";
            // 
            // miSep
            // 
            this.miSep.Name = "miSep";
            this.miSep.Size = new System.Drawing.Size(181, 26);
            this.miSep.Text = "—";
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(181, 26);
            this.miExit.Text = "退出（&X）";
            // 
            // 新建NToolStripMenuItem1
            // 
            this.新建NToolStripMenuItem1.Name = "新建NToolStripMenuItem1";
            this.新建NToolStripMenuItem1.Size = new System.Drawing.Size(181, 26);
            this.新建NToolStripMenuItem1.Text = "新建（&N）";
            // 
            // miDelDir
            // 
            this.miDelDir.Name = "miDelDir";
            this.miDelDir.Size = new System.Drawing.Size(181, 26);
            this.miDelDir.Text = "删除（&D）";
            // 
            // miLargeIcon
            // 
            this.miLargeIcon.Name = "miLargeIcon";
            this.miLargeIcon.Size = new System.Drawing.Size(181, 26);
            this.miLargeIcon.Text = "大图标（&L)";
            // 
            // miSmallIcon
            // 
            this.miSmallIcon.Name = "miSmallIcon";
            this.miSmallIcon.Size = new System.Drawing.Size(181, 26);
            this.miSmallIcon.Text = "小图标（&S)";
            // 
            // miList
            // 
            this.miList.Name = "miList";
            this.miList.Size = new System.Drawing.Size(181, 26);
            this.miList.Text = "列表（&L）";
            // 
            // miDetail
            // 
            this.miDetail.Name = "miDetail";
            this.miDetail.Size = new System.Drawing.Size(181, 26);
            this.miDetail.Text = "详细资料（&D)";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.txtPass});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(660, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // tvDir
            // 
            this.tvDir.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.tvDir.ImageIndex = 0;
            this.tvDir.ImageList = this.imageList1;
            this.tvDir.Location = new System.Drawing.Point(0, 56);
            this.tvDir.Name = "tvDir";
            this.tvDir.SelectedImageIndex = 0;
            this.tvDir.Size = new System.Drawing.Size(184, 484);
            this.tvDir.TabIndex = 2;
            // 
            // lvFile
            // 
            this.lvFile.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvFile.LargeImageList = this.imageList1;
            this.lvFile.Location = new System.Drawing.Point(190, 58);
            this.lvFile.Name = "lvFile";
            this.lvFile.Size = new System.Drawing.Size(419, 482);
            this.lvFile.TabIndex = 3;
            this.lvFile.UseCompatibleStateImageBehavior = false;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(54, 24);
            this.toolStripLabel1.Text = "路径：";
            // 
            // txtPass
            // 
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(100, 27);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 567);
            this.Controls.Add(this.lvFile);
            this.Controls.Add(this.tvDir);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.maiMenu);
            this.MainMenuStrip = this.maiMenu;
            this.Name = "Form1";
            this.Text = "资源管理器";
            this.maiMenu.ResumeLayout(false);
            this.maiMenu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip maiMenu;
        private System.Windows.Forms.ToolStripMenuItem miNewFile;
        private System.Windows.Forms.ToolStripMenuItem 新建NToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miOpenFile;
        private System.Windows.Forms.ToolStripMenuItem miDelFile;
        private System.Windows.Forms.ToolStripMenuItem miSep;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miNewDir;
        private System.Windows.Forms.ToolStripMenuItem 新建NToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem miDelDir;
        private System.Windows.Forms.ToolStripMenuItem 视图ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miLargeIcon;
        private System.Windows.Forms.ToolStripMenuItem miSmallIcon;
        private System.Windows.Forms.ToolStripMenuItem miList;
        private System.Windows.Forms.ToolStripMenuItem miDetail;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TreeView tvDir;
        private System.Windows.Forms.ListView lvFile;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox txtPass;
    }
}

