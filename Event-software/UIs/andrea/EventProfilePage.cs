﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace itHappens.UIs.andrea
{
    public partial class EventProfilePage : UserControl
    {
        public EventProfilePage()
        {
            InitializeComponent();

            for (int i = 0; i < 5; i++)
            {
                friendsFlowPanel.Controls.Add(new UIs.Common.FriendsAttending());
            }
            
        }

        private void EventProfilePage_Load(object sender, EventArgs e)
        {

        }

        private void descriptionLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
