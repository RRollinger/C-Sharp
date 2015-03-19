﻿/*! 
@author Terence Slot. <Tryan18@gmail.com>
		<http://github.com/tryan18/C#>
@date March 19, 2015
@version 1.0
@section LICENSE

The MIT License (MIT)

Copyright (c) 2013 Terence Slot

Permission is hereby granted, free of charge, to any person obtaining a copy
of this software and associated documentation files (the "Software"), to deal
in the Software without restriction, including without limitation the rights
to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
copies of the Software, and to permit persons to whom the Software is
furnished to do so, subject to the following conditions:
The above copyright notice and this permission notice shall be included in
all copies or substantial portions of the Software.
THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
THE SOFTWARE.
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace exclusive_story
{
    public partial class Form1 : Form
    {
        private List<object> storys = new List<object>();
        private Story1 yoshi;
        public Story_Log log;

        public Form1()
        {
            InitializeComponent();
            Application.ApplicationExit += new EventHandler(Application_ApplicationExit);
            log = new Story_Log(100, this);
        }

        void Application_ApplicationExit(object sender, EventArgs e)
        {
            File.Delete(Application.StartupPath + "//yoshi_island.mp3");
        }

        private void B_about_Click(object sender, EventArgs e)
        {
            new AboutMe().Show();
        }

        private void B_start_Click(object sender, EventArgs e)
        {
            B_start.Visible = false;
            B_stop.Visible = true;
            //storys.Add(new Story1(this));
            yoshi = new Story1(this);
            yoshi.Start();
        }

        private void B_stop_Click(object sender, EventArgs e)
        {
            P_story.Controls.Clear();
            T_log.Clear();
            B_start.Visible = true;
            yoshi.Stop();
            B_stop.Visible = false;
        }
    }
}
