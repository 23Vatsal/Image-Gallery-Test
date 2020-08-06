using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

namespace Image_Gallery_Test
{
    partial class Form1 
    {
        private System.Windows.Forms.SplitContainer sc1;

        private void InitializeComponent()
        {
            sc1 = new System.Windows.Forms.SplitContainer();
            sc1.SuspendLayout();
            SuspendLayout();

            this.sc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.sc1.IsSplitterFixed = true;
            this.sc1.Location = new System.Drawing.Point(0, 0);
            this.sc1.Margin = new System.Windows.Forms.Padding(2);
            this.sc1.Name = "sc1";
            this.sc1.Orientation = System.Windows.Forms.Orientation.Horizontal;

            this.sc1.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.sc1.Size = new System.Drawing.Size(764, 749);
            this.sc1.SplitterDistance = 40;
            this.sc1.TabIndex = 0;

            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 800);
            this.Controls.Add(this.sc1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(810, 810);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Image Gallery";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.sc1)).EndInit();
            this.sc1.ResumeLayout(false);
            this.ResumeLayout(false);


        }

     

    }
}

