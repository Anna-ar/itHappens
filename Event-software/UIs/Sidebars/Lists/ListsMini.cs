﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itHappens.UIs.Sidebars.Lists
{
    public partial class ListsMini : UserControl
    {
        public ListsMini()
        {
            InitializeComponent();
        }

        public ListsMini(string listTitle)
        {
            InitializeComponent();

            title.Text = listTitle;
        }

        private void title_Click(object sender, EventArgs e)
        {

        }
    }
}
