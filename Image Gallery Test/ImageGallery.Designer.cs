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
        private TableLayoutPanel tablePanel1;

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.sc1 = new System.Windows.Forms.SplitContainer();
            this.tablePanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this._searchbox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this._search = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.sc1)).BeginInit();
            this.sc1.Panel1.SuspendLayout();
            this.sc1.SuspendLayout();
            this.tablePanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._search)).BeginInit();
            this.SuspendLayout();
            // 
            // sc1
            // 
            this.sc1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.sc1.IsSplitterFixed = true;
            this.sc1.Location = new System.Drawing.Point(0, 0);
            this.sc1.Margin = new System.Windows.Forms.Padding(2);
            this.sc1.Name = "sc1";
            this.sc1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sc1.Panel1
            // 
            this.sc1.Panel1.Controls.Add(this.tablePanel1);
            this.sc1.Panel1.Margin = new System.Windows.Forms.Padding(2);
            this.sc1.Size = new System.Drawing.Size(780, 749);
            this.sc1.SplitterDistance = 40;
            this.sc1.TabIndex = 0;
            // 
            // tablePanel1
            // 
            this.tablePanel1.ColumnCount = 3;
            this.tablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tablePanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.5F));
            this.tablePanel1.Controls.Add(this.panel1, 2, 0);
            this.tablePanel1.Controls.Add(this.panel2, 1, 0);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.RowCount = 1;
            this.tablePanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablePanel1.Size = new System.Drawing.Size(780, 40);
            this.tablePanel1.TabIndex = 0;
            this.tablePanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tablePanel1_Paint);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._search);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Location = new System.Drawing.Point(490, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 34);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._searchbox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(198, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(286, 34);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // _searchbox
            // 
            this._searchbox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._searchbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this._searchbox.Location = new System.Drawing.Point(28, 9);
            this._searchbox.Name = "_searchbox";
            this._searchbox.Size = new System.Drawing.Size(244, 13);
            this._searchbox.TabIndex = 0;
            this._searchbox.Text = "Search Image";
            // 
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(479, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 12, 45, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(40, 16);
            this.panel3.TabIndex = 1;
            // 
            // _search
            // 
            this._search.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._search.Image = ((System.Drawing.Image)(resources.GetObject("_search.Image")));
            this._search.Location = new System.Drawing.Point(0, 6);
            this._search.Margin = new System.Windows.Forms.Padding(0);
            this._search.Name = "_search";
            this._search.Size = new System.Drawing.Size(36, 20);
            this._search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this._search.TabIndex = 2;
            this._search.TabStop = false;
            this._search.Click += new System.EventHandler(this._search_Click);
            this._search.DoubleClick += new System.EventHandler(this._search_DoubleClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 749);
            this.Controls.Add(this.sc1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(810, 810);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Image Gallery";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.sc1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc1)).EndInit();
            this.sc1.ResumeLayout(false);
            this.tablePanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._search)).EndInit();
            this.ResumeLayout(false);

        }

        private Panel panel1;
        private Panel panel2;
        private TextBox _searchbox;
        private Panel panel3;
        private PictureBox _search;
    }
}

