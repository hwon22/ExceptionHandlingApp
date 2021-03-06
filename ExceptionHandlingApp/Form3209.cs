﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExceptionHandlingApp
{
    public partial class Form3209 : Form
    {
        public Form3209()
        {
            InitializeComponent();
        }

        private void btnResult_Click(object sender, EventArgs e)
        {
            try
            {
                string input = txtInput.Text;
                int result = int.Parse(input) * 100;
                txtResult.Text = result.ToString();
            }
            catch(FormatException exception)
            {
                MessageBox.Show("제대로 숫자를 입력해주세요!\n" + exception.Message);
                txtInput.Text = "";
                txtResult.Text = "";
            }
            catch (Exception exception)
            {
                MessageBox.Show("에러가 발생했습니다!\n" + exception.Message);
                txtInput.Text = "";
                txtResult.Text = "";
            }
            finally
            {
                txtInput.Focus();
            }
        }
    }
}
