using System;
using System.Windows.Forms;

namespace Mislete
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.backwardBtn = new System.Windows.Forms.ToolStripButton();
            this.forwardBtn = new System.Windows.Forms.ToolStripButton();
            this.refreshBtn = new System.Windows.Forms.ToolStripButton();
            this.homeBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.comboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.goBtn = new System.Windows.Forms.ToolStripButton();
            this.AddPageBtn = new System.Windows.Forms.ToolStripButton();
            this.removePageBtn = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.backwardBtn,
            this.forwardBtn,
            this.refreshBtn,
            this.homeBtn,
            this.toolStripSeparator1,
            this.toolStripLabel1,
            this.comboBox1,
            this.goBtn,
            this.AddPageBtn,
            this.removePageBtn});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1095, 25);
            this.toolStrip1.Stretch = true;
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.DragDrop += new System.Windows.Forms.DragEventHandler(this.toolStrip1_DragDrop);
            // 
            // backwardBtn
            // 
            this.backwardBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.backwardBtn.Image = ((System.Drawing.Image)(resources.GetObject("backwardBtn.Image")));
            this.backwardBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.backwardBtn.Name = "backwardBtn";
            this.backwardBtn.Size = new System.Drawing.Size(23, 22);
            this.backwardBtn.Text = "backwardBtn";
            this.backwardBtn.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // forwardBtn
            // 
            this.forwardBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.forwardBtn.Image = ((System.Drawing.Image)(resources.GetObject("forwardBtn.Image")));
            this.forwardBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.forwardBtn.Name = "forwardBtn";
            this.forwardBtn.Size = new System.Drawing.Size(23, 22);
            this.forwardBtn.Text = "forwardBtn";
            this.forwardBtn.Click += new System.EventHandler(this.forwardBtn_Click);
            // 
            // refreshBtn
            // 
            this.refreshBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.refreshBtn.Image = ((System.Drawing.Image)(resources.GetObject("refreshBtn.Image")));
            this.refreshBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(23, 22);
            this.refreshBtn.Text = "refreshBtn";
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // homeBtn
            // 
            this.homeBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(23, 22);
            this.homeBtn.Text = "homeBtn";
            this.homeBtn.Click += new System.EventHandler(this.toolStripButton1_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(56, 22);
            this.toolStripLabel1.Text = "Address";
            // 
            // comboBox1
            // 
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(400, 25);
            this.comboBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyDown);
            this.comboBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.comboBox1_MouseDown);
            // 
            // goBtn
            // 
            this.goBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.goBtn.Image = ((System.Drawing.Image)(resources.GetObject("goBtn.Image")));
            this.goBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.goBtn.Name = "goBtn";
            this.goBtn.Size = new System.Drawing.Size(29, 22);
            this.goBtn.Text = "Go";
            this.goBtn.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // AddPageBtn
            // 
            this.AddPageBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.AddPageBtn.Image = ((System.Drawing.Image)(resources.GetObject("AddPageBtn.Image")));
            this.AddPageBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddPageBtn.Name = "AddPageBtn";
            this.AddPageBtn.Size = new System.Drawing.Size(69, 22);
            this.AddPageBtn.Text = "Add Page";
            this.AddPageBtn.Click += new System.EventHandler(this.AddPageBtn_Click_1);
            // 
            // removePageBtn
            // 
            this.removePageBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.removePageBtn.Image = ((System.Drawing.Image)(resources.GetObject("removePageBtn.Image")));
            this.removePageBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removePageBtn.Name = "removePageBtn";
            this.removePageBtn.Size = new System.Drawing.Size(92, 22);
            this.removePageBtn.Text = "Remove Page";
            this.removePageBtn.Click += new System.EventHandler(this.removePageBtn_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 25);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1095, 479);
            this.tabControl1.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1095, 504);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mislete";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Form1_DragEnter);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }









        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton backwardBtn;
        private System.Windows.Forms.ToolStripButton forwardBtn;
        private System.Windows.Forms.ToolStripButton refreshBtn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.ToolStripButton homeBtn;
        private ToolStripLabel toolStripLabel1;
        private ToolStripButton goBtn;
        private ToolStripComboBox comboBox1;
        private ToolStripButton AddPageBtn;
        private ToolStripButton removePageBtn;
    }
}

