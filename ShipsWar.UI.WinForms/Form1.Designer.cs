﻿using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;
using System;
using ShipsWar.Model;
using BLL;

namespace ShipsWar.UI.WinForms
{
    partial class Form1
    {       

        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1318, 554);
            this.Name = "Form1";
            this.ResumeLayout(false);        
        }
        #endregion
    }
    
}