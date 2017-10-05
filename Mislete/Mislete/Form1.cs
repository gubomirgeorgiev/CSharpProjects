using System;
using System.Windows.Forms;

namespace Mislete
{
    public partial class Form1 : Form
    {
        string homePage = "www.google.com";
        int i = 0; //Tab counter
        WebBrowser webBrowser1 = new WebBrowser();
        public Form1()
        {
            InitializeComponent();
            comboBox1.MouseDown += comboBox1_MouseDown;
            homeBtn.DragEnter += homeBtn_DragEnte;
            homeBtn.DragEnter += homeBtn_DragDrop;
        }
        // Backward button setup
        private void goBtn_Click(object sender, EventArgs e)
        {         
            //If combobox contais texts add the text to combobox "history"
            if (!comboBox1.Items.Contains(comboBox1.Text))
            {
                comboBox1.Items.Add(comboBox1.Text);
            }
            //Navigate webbrowse1 to the text in combobox
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(comboBox1.Text);
        }
        // Forward button setup
        private void forwardBtn_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoForward)
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoForward();
            }
        }
        // Here loads the first page
        private void Form1_Load(object sender, EventArgs e)
        {
            webBrowser1 = new WebBrowser();
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Dock = DockStyle.Fill;
            webBrowser1.Visible = true;
            webBrowser1.DocumentCompleted += webBrowser1_DocumentCompleted;
            tabControl1.TabPages.Add("New Tab");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(webBrowser1);
            ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(homePage);
            i += 1;
        }
        //REFRESH BUTTON
        private void refreshBtn_Click(object sender, EventArgs e)
        {
            if (tabControl1.SelectedTab.Text != null)
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Refresh();

            }
        }
        //defininf mouse drop action to make copy or move action
        private void comboBox1_MouseDown(object sender, MouseEventArgs e)
        {
            ToolStripComboBox tb = (ToolStripComboBox)sender;
            tb.SelectAll();
            //Drag Source
            tb.DoDragDrop(tb.Text, DragDropEffects.Copy | DragDropEffects.Move);
        }
        // See if this is a copy and the data includes text.
        private void homeBtn_DragEnte(object sender, DragEventArgs e)
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
        // Accept the drop.
        private void homeBtn_DragDrop(object sender, DragEventArgs e)
        {
            //Drop target.
            homePage = (string)e.Data.GetData(DataFormats.Text);
        }
        // go back btn
        private void goBackBtn_Click(object sender, EventArgs e)
        {
            if (webBrowser1.CanGoBack)
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).GoBack();
            }
        }
        //Tabcontrols tab takes website name
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            tabControl1.SelectedTab.Text = ((WebBrowser)tabControl1.SelectedTab.Controls[0]).DocumentTitle;
        }
        //open page by pressing enter key
        private void comboBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                //If combobox contais texts add the text to combobox "history"
                if (!comboBox1.Items.Contains(comboBox1.Text))
                {
                    comboBox1.Items.Add(comboBox1.Text);
                }
                //Navigates to text in combobox
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(comboBox1.Text);
            }
        }
        //add page button action
        private void AddPageBtn_Click_1(object sender, EventArgs e)
        {
            webBrowser1 = new WebBrowser();
            webBrowser1.ScriptErrorsSuppressed = true;
            webBrowser1.Dock = DockStyle.Fill;
            webBrowser1.Visible = true;
            webBrowser1.DocumentCompleted += webBrowser1_DocumentCompleted;
            tabControl1.TabPages.Add("New Tab");
            tabControl1.SelectTab(i);
            tabControl1.SelectedTab.Controls.Add(webBrowser1);
            i += 1;
        }
        // Remove pages
        private void removePageBtn_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabPages.Count - 1 > 0)
            {
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
                tabControl1.SelectTab(tabControl1.TabPages.Count - 1);
                i -= 1;
            }
        }
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        //homebutton action
        private void toolStrip1_DragDrop(object sender, DragEventArgs e)
        {
            ToolStripButton tb = (ToolStripButton)sender;
            homePage = (string)e.Data.GetData(DataFormats.Text);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            if (webBrowser1.AllowNavigation)
            {
                ((WebBrowser)tabControl1.SelectedTab.Controls[0]).Navigate(homePage);
            }
            }
        }
    }

