using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;
using Renci.SshNet.Common;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        //Connection information
        public string user = "khanh";
        string pass = "khanh2019";
        string host = "192.168.1.8";
        bool connect_status;
        //int port = 22;
        public SshClient client;
        private ShellStream shell;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "khanh";
            textBox5.Text = "khanh2019";
            textBox4.Text = "192.168.1.8";
            textBox3.Enabled = false;
            textBox3.ReadOnly = true;
            button1.Enabled = false;
            connect_status = false;
        }

        private void Button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                richTextBox1.AppendText(client.RunCommand(textBox3.Text).Result);
                richTextBox1.AppendText(">\n");
                textBox3.Clear();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                try
                {
                    client.Connect();
                }
                catch { }
            }

        }

        private void Button2_Click_1(object sender, EventArgs e)
        {
            if(!connect_status)
            {
                connect_status = true;
                user = textBox1.Text;
                pass = textBox5.Text;
                host = textBox4.Text;
                client = new SshClient(host, user, pass);
                try
                {
                    client.Connect();// SshAuthenticationException
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                textBox1.Enabled = false;
                textBox1.ReadOnly = true;
                textBox5.Enabled = false;
                textBox5.ReadOnly = true;
                textBox4.Enabled = false;
                textBox4.ReadOnly = true;
                textBox3.Enabled = true;
                textBox3.ReadOnly = false;
                button1.Enabled = true;
                button2.Text = "Ngắt kết nối";
                
            }else
            if(connect_status)
            {
                connect_status = false;
                try
                {
                    client.Disconnect();
                }
                catch(Exception a)
                {
                    return;
                }
                textBox1.Enabled = true;
                textBox1.ReadOnly = false;
                textBox5.Enabled = true;
                textBox5.ReadOnly = false;
                textBox4.Enabled = true;
                textBox4.ReadOnly = false;
                textBox3.Enabled = false;
                textBox3.ReadOnly = true;
                button1.Enabled = false;
                button2.Text = "Kết nối";
           
            }       
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Enter))
            {
                try
                {
                    richTextBox1.AppendText(client.RunCommand(textBox3.Text).Result);
                    richTextBox1.AppendText(">\n");
                    textBox3.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    try
                    {
                        client.Connect();
                    }
                    catch { }
                }
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}