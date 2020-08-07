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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            C1.Win.C1Tile.PanelElement panelElement1 = new C1.Win.C1Tile.PanelElement();
            C1.Win.C1Tile.ImageElement imageElement1 = new C1.Win.C1Tile.ImageElement();
            C1.Win.C1Tile.TextElement textElement1 = new C1.Win.C1Tile.TextElement();
            this.sc1 = new System.Windows.Forms.SplitContainer();
            this.tablePanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this._search = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this._searchbox = new System.Windows.Forms.TextBox();
            this._exportImage = new System.Windows.Forms.PictureBox();
            this._imageTileControl = new C1.Win.C1Tile.C1TileControl();
            this.group1 = new C1.Win.C1Tile.Group();
            this.tile1 = new C1.Win.C1Tile.Tile();
            this.tile2 = new C1.Win.C1Tile.Tile();
            this.tile3 = new C1.Win.C1Tile.Tile();
            this.c1PdfDocumentSource1 = new C1.Win.C1Document.C1PdfDocumentSource(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.sc1)).BeginInit();
            this.sc1.Panel1.SuspendLayout();
            this.sc1.Panel2.SuspendLayout();
            this.sc1.SuspendLayout();
            this.tablePanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._search)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._exportImage)).BeginInit();
            this.statusStrip1.SuspendLayout();
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
            // 
            // sc1.Panel2
            // 
            this.sc1.Panel2.Controls.Add(this.statusStrip1);
            this.sc1.Panel2.Controls.Add(this._imageTileControl);
            this.sc1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            this.sc1.Panel2.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sc1_Panel2_MouseClick);
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
            this.tablePanel1.Controls.Add(this._exportImage, 0, 0);
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
            // panel3
            // 
            this.panel3.Location = new System.Drawing.Point(479, 12);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 12, 45, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(40, 16);
            this.panel3.TabIndex = 1;
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
            // _exportImage
            // 
            this._exportImage.Image = ((System.Drawing.Image)(resources.GetObject("_exportImage.Image")));
            this._exportImage.Location = new System.Drawing.Point(3, 3);
            this._exportImage.Name = "_exportImage";
            this._exportImage.Size = new System.Drawing.Size(47, 34);
            this._exportImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this._exportImage.TabIndex = 3;
            this._exportImage.TabStop = false;
            this._exportImage.Visible = false;
            this._exportImage.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // _imageTileControl
            // 
            this._imageTileControl.AllowChecking = true;
            this._imageTileControl.AllowRearranging = true;
            this._imageTileControl.CellHeight = 78;
            this._imageTileControl.CellSpacing = 11;
            this._imageTileControl.CellWidth = 78;
            // 
            // 
            // 
            panelElement1.Alignment = System.Drawing.ContentAlignment.BottomLeft;
            panelElement1.Children.Add(imageElement1);
            panelElement1.Children.Add(textElement1);
            panelElement1.Margin = new System.Windows.Forms.Padding(10, 6, 10, 6);
            this._imageTileControl.DefaultTemplate.Elements.Add(panelElement1);
            this._imageTileControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._imageTileControl.Groups.Add(this.group1);
            this._imageTileControl.Location = new System.Drawing.Point(0, 0);
            this._imageTileControl.Name = "_imageTileControl";
            this._imageTileControl.Size = new System.Drawing.Size(780, 705);
            this._imageTileControl.SurfacePadding = new System.Windows.Forms.Padding(12, 4, 12, 4);
            this._imageTileControl.SwipeDistance = 20;
            this._imageTileControl.SwipeRearrangeDistance = 98;
            this._imageTileControl.TabIndex = 0;
            this._imageTileControl.Text = "c1TileControl1";
            this._imageTileControl.TileChecked += new System.EventHandler<C1.Win.C1Tile.TileEventArgs>(this._imageTileControl_TileChecked);
            this._imageTileControl.TileUnchecked += new System.EventHandler<C1.Win.C1Tile.TileEventArgs>(this._imageTileControl_TileUnchecked);
            this._imageTileControl.Paint += new System.Windows.Forms.PaintEventHandler(this._imageTileControl_Paint);
            // 
            // group1
            // 
            this.group1.Name = "group1";
            this.group1.Text = "Group 1";
            this.group1.Tiles.Add(this.tile1);
            this.group1.Tiles.Add(this.tile2);
            this.group1.Tiles.Add(this.tile3);
            // 
            // tile1
            // 
            this.tile1.BackColor = System.Drawing.Color.LightCoral;
            this.tile1.Name = "tile1";
            this.tile1.Text = "Tile 1";
            // 
            // tile2
            // 
            this.tile2.BackColor = System.Drawing.Color.Teal;
            this.tile2.Name = "tile2";
            this.tile2.Text = "Tile 2";
            // 
            // tile3
            // 
            this.tile3.BackColor = System.Drawing.Color.SteelBlue;
            this.tile3.Name = "tile3";
            this.tile3.Text = "Tile 3";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 683);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(780, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.Visible = false;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
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
            this.sc1.Panel2.ResumeLayout(false);
            this.sc1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc1)).EndInit();
            this.sc1.ResumeLayout(false);
            this.tablePanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this._search)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._exportImage)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        private Panel panel1;
        private Panel panel2;
        private TextBox _searchbox;
        private Panel panel3;
        private PictureBox _search;
        private PictureBox _exportImage;
        private C1.Win.C1Tile.C1TileControl _imageTileControl;
        private C1.Win.C1Tile.Group group1;
        private C1.Win.C1Tile.Tile tile1;
        private C1.Win.C1Tile.Tile tile2;
        private C1.Win.C1Tile.Tile tile3;
        private C1.Win.C1Document.C1PdfDocumentSource c1PdfDocumentSource1;
        private IContainer components;
        private StatusStrip statusStrip1;
        private ToolStripProgressBar toolStripProgressBar1;
    }
}

