﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mislete
{
    public partial class Form1 : Form
    {
        string homePage="";
        
        public Form1()
        {
            ComboBox text = new ComboBox();
           text.Text ="https://github.com/gubomirgeorgiev/CSharpProjects";
            comboBox1.Items.Add(text);
            InitializeComponent();
            this.AllowDrop = true;
            this.DragDrop += new DragEventHandler(this.Form1_DragDrop);
            this.DragEnter += new DragEventHandler(this.Form1_DragEnter);
        }
        
        // Backward button setup
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (webApp.CanGoBack)
            {
                webApp.GoBack();
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            toolStrip1.AllowDrop = true;
        }
        // Forward button setup
        private void forwardBtn_Click(object sender, EventArgs e)
        {
            if (webApp.CanGoForward)
            {
                webApp.GoForward();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        WebBrowser webApp = new WebBrowser();
        int i = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            webApp = new WebBrowser();
            webApp.ScriptErrorsSuppressed = true;
            webApp.Dock = DockStyle.Fill;
            webApp.Visible = true;
            //webApp.DocumentCompleted += ;
            tabControl1.TabPages.Add("New Tab");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(webApp);
            i += i;
        }

        private void toolStripButton1_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Equals(""))
            { 
                webApp.Navigate(homePage);
                }
            
        }
        //SETTING UP REFRESH BUTTON
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            if (webApp.Url != null && comboBox1.Text != null)
            {
                if (webApp.Url.Equals(comboBox1.Text))
                {
                    webApp.Refresh();
                }
            }
        }
        //defininf mouse drop action to make copy or move action
        private void comboBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ComboBox tb = (ComboBox)sender;
            tb.SelectAll();
            tb.DoDragDrop(tb.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }
        // See if this is a copy and the data includes text.
        private void comboBox1_DragEnter (object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                // Allow this.
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                // Don't allow any other drop.
                e.Effect = DragDropEffects.None;
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //comboBox1.DoDragDrop(comboBox1.Text, DragDropEffects.Copy | DragDropEffects.Move);
            comboBox1.Text = "google.com";
        }

        private void goBtn_Click(object sender, EventArgs e)
        {
            webApp.Navigate(comboBox1.Text);
        }

        private void comboBox1_DragDrop(object sender, DragEventArgs e)
        {
            ComboBox tb = (ComboBox)sender;
            tb.Text = (string)e.Data.GetData(DataFormats.Text);
            homeBtn.Text = tb.Text;
            homePage = comboBox1.Text;
        }
        private void homeBtn_Drag_Drop_Text_Load (object sender, EventArgs e)
        {
            homeBtn.DragEnter += new DragEventHandler(comboBox1_DragEnter);
            homeBtn.MouseDown += new MouseEventHandler(comboBox1_MouseDown);
            homeBtn.DragDrop += new DragEventHandler(comboBox1_DragDrop);

            comboBox1.DragEnter += new DragEventHandler(comboBox1_DragEnter);
            comboBox1.MouseDown += new MouseEventHandler(comboBox1_MouseDown);
            comboBox1.DragDrop += new DragEventHandler(comboBox1_DragDrop);
        }

        //Opening web page by pressing enter key
        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                webApp.Navigate(comboBox1.Text);
            }
        }
        // Accept the drop.
        private void Form1_DragDrop(object sender, DragEventArgs e)
        {
            //Drop target.
            homeBtn.Text = (string)e.Data.GetData(DataFormats.Text);
            homePage = (string)e.Data.GetData(DataFormats.Text);
        }
        // Start a drag that copies text.
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            // Start the drag if it's the right mouse button.
            if (e.Button == MouseButtons.Left)
            {
                //Drag Source
                comboBox1.DoDragDrop(comboBox1.Text,
                    DragDropEffects.Copy);
            }
        }
        // Indicate that we can accept a copy of text.
        private void Form1_DragEnter(object sender, DragEventArgs e)
        {
            // See if this is a copy and the data includes text.
            if ((e.Data.GetDataPresent(DataFormats.Text)) && (e.AllowedEffect & DragDropEffects.Copy) != 0)
            {
                // Allow this.
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                // Don't allow any other drop.
                e.Effect = DragDropEffects.None;
            }
        }
    }
}
