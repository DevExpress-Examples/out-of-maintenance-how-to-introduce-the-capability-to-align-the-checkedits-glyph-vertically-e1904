using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Q240157 {
    public partial class Form1 : XtraForm {
        public Form1() {
            InitializeComponent();
            for (int i = 0; i < 10; i++)
                dataTable1.Rows.Add(i % 2 == 0, i % 2 == 1);
        }
    }
}