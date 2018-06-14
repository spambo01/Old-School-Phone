using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OldSchoolPhone
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            lblErrorMsg.Text = "";
            lblNumberedText.Text = "";
            lblTime.Text = "";
            //assumption: convert to lowercase by default
            string englishSentence = txtSentence.Text.ToLower();
            if (string.IsNullOrEmpty(englishSentence))
            {
                ValidateUserInput();
            }
            else
            {
                lblNumberedText.Text=   new BusinessLogic().ConvertToPhoneKeys(englishSentence, this);
            }
        }

        public void PrintRequiredTime(double minTime)
        {
            lblTime.Text = minTime.ToString() + " seconds";
        }
        



        internal void ValidateUserInput()
        {
            //assumptions: latin alphabet and .#* characters
            lblErrorMsg.Text = "Please add some text using the latin characters a-z . # *";
        }



    }
}
