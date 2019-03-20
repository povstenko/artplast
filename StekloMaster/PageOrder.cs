﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StekloMaster
{
    public partial class PageOrder : UserControl
    {
        const int OFFSET = 10;
        Image IMG_COLLAPSE = global::StekloMaster.Properties.Resources.collapse_arrow_24;
        Image IMG_EXPAND = global::StekloMaster.Properties.Resources.expand_arrow_24;
    
        public PageOrder()
        {
            InitializeComponent();
            InitializeExpandMenu();
        }

        private void CheckExpandMenuSpace()
        {
            if (((int)b1.Tag + (int)b2.Tag + (int)b3.Tag) >= 2)
            {
                pSize.Visible = false;
            }
            else
                pSize.Visible = true;
        }

        // ExpandMenu
        private void InitializeExpandMenu()
        {
            b1.Tag = 0;
            b2.Tag = 0;
            b3.Tag = 0;

            b2.Width = b1.Width;
            b3.Width = b1.Width;

            b2.Height = b1.Height;
            b3.Height = b1.Height;

            p1.Width = b1.Width;
            p2.Width = b2.Width;
            p3.Width = b3.Width;

            //b1.Top = OFFSET;
            b2.Top = b1.Bottom + OFFSET;
            b3.Top = b2.Bottom + OFFSET;

            CheckExpandMenuSpace();
        }
        private void ExpandMenu1_Click(object sender, EventArgs e)
        {
            if ((int)b1.Tag == 0)
            {
                // expand
                b1.Image = IMG_COLLAPSE;
                p1.Top = b1.Bottom;
                p1.Visible = true;

                b2.Top = p1.Bottom + OFFSET;
                p2.Top = b2.Bottom;

                if ((int)b2.Tag == 0)
                    b3.Top = b2.Bottom + OFFSET;
                else
                    b3.Top = p2.Bottom + OFFSET;

                p3.Top = b3.Bottom;

                b1.Tag = 1;
            }
            else
            {
                // hide
                b1.Image = IMG_EXPAND;
                p1.Visible = false;

                b2.Top = b1.Bottom + OFFSET;
                p2.Top = b2.Bottom;

                if ((int)b2.Tag == 0)
                    b3.Top = b2.Bottom + OFFSET;
                else
                    b3.Top = p2.Bottom + OFFSET;

                p3.Top = b3.Bottom;

                b1.Tag = 0;
            }
            CheckExpandMenuSpace();
        }
        private void ExpandMenu2_Click(object sender, EventArgs e)
        {
            if ((int)b2.Tag == 0)
            {
                // expand
                b2.Image = IMG_COLLAPSE;
                p2.Top = b2.Bottom;
                p2.Visible = true;

                b3.Top = p2.Bottom + OFFSET;
                p3.Top = b3.Bottom;

                b2.Tag = 1;
            }
            else
            {
                // hide
                b2.Image = IMG_EXPAND;
                p2.Visible = false;

                b3.Top = b2.Bottom + OFFSET;
                p3.Top = b3.Bottom;

                b2.Tag = 0;
            }
            CheckExpandMenuSpace();
        }
        private void ExpandMenu3_Click(object sender, EventArgs e)
        {
            if ((int)b3.Tag == 0)
            {
                // expand
                b3.Image = IMG_COLLAPSE;
                p3.Top = b3.Bottom;
                p3.Visible = true;

                b3.Tag = 1;
            }
            else
            {
                // hide
                b3.Image = IMG_EXPAND;
                p3.Visible = false;

                b3.Tag = 0;
            }
            CheckExpandMenuSpace();
        }
    }
}
