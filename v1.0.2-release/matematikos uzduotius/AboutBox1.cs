using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace matematikos_uzduotius
{
    partial class AboutBox1 : Form
    {
        public AboutBox1()
        {
            InitializeComponent();
            this.Text = String.Format("About");
            this.labelProductName.Text = String.Format("Math exercises");
            this.labelVersion.Text = String.Format("Version v1.0.2");
            this.labelCopyright.Text = String.Format("Developer: PMdevelopltu");
          //  this.labelCompanyName.Text = String.Format("Programos atnaujinimai:");
            this.textBoxDescription.Text = String.Format("About program: This app is designed to test your math skills. You can choose from three difficulty levels: easy (subtraction and addition up to 20), medium (addition, subtraction, multiplication, division), and  hard(addition, subtraction, multiplication, division)");
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            this.Controls.AddRange(new System.Windows.Forms.Control[] { this.linkLabel1 });
        }

        #region Assembly Attribute Accessors

        public string AssemblyTitle
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyTitleAttribute), false);
                if (attributes.Length > 0)
                {
                    AssemblyTitleAttribute titleAttribute = (AssemblyTitleAttribute)attributes[0];
                    if (titleAttribute.Title != "")
                    {
                        return titleAttribute.Title;
                    }
                }
                return System.IO.Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
            }
        }

        public string AssemblyVersion
        {
            get
            {
                return Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
        }

        public string AssemblyDescription
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyDescriptionAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyDescriptionAttribute)attributes[0]).Description;
            }
        }

        public string AssemblyProduct
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyProductAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyProductAttribute)attributes[0]).Product;
            }
        }

        public string AssemblyCopyright
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCopyrightAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCopyrightAttribute)attributes[0]).Copyright;
            }
        }

        public string AssemblyCompany
        {
            get
            {
                object[] attributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof(AssemblyCompanyAttribute), false);
                if (attributes.Length == 0)
                {
                    return "";
                }
                return ((AssemblyCompanyAttribute)attributes[0]).Company;
            }
        }
        #endregion

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                VisitLink();
            }
            finally
            {

            }

        }
        private void VisitLink()
        {
            this.linkLabel1.LinkVisited = true;
            ProcessStartInfo psInfo = new ProcessStartInfo
            {
                FileName = "https://github.com/PMdevelopltu/mathexercises",
                UseShellExecute = true
            };
            Process.Start(psInfo);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
