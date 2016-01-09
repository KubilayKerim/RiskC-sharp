namespace riskcsharp
{
    partial class drmAtak
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
            this.Iptal_btn = new System.Windows.Forms.Button();
            this.Saldır_Btn = new System.Windows.Forms.Button();
            this.atak_label = new System.Windows.Forms.Label();
            this.SyO_btn = new System.Windows.Forms.Button();
 
            this.def_label = new System.Windows.Forms.Label();
            this.Asker_Atak = new System.Windows.Forms.Label();
            this.Asker_def = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Iptal_btn
            // 
            this.Iptal_btn.Location = new System.Drawing.Point(351, 153);
            this.Iptal_btn.Name = "Iptal_btn";
            this.Iptal_btn.Size = new System.Drawing.Size(90, 29);
            this.Iptal_btn.TabIndex = 0;
            this.Iptal_btn.Text = "İptal";
            this.Iptal_btn.UseVisualStyleBackColor = true;
            this.Iptal_btn.Click += new System.EventHandler(this.Iptal_btn_Click);
            // 
            // Saldır_Btn
            // 
            this.Saldır_Btn.Location = new System.Drawing.Point(54, 153);
            this.Saldır_Btn.Name = "Saldır_Btn";
            this.Saldır_Btn.Size = new System.Drawing.Size(90, 29);
            this.Saldır_Btn.TabIndex = 0;
            this.Saldır_Btn.Text = "Saldır";
            this.Saldır_Btn.UseVisualStyleBackColor = true;
            this.Saldır_Btn.Click += new System.EventHandler(this.Saldır_Btn_Click);
            // 
            // atak_label
            // 
            this.atak_label.AutoSize = true;
            this.atak_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.atak_label.Location = new System.Drawing.Point(65, 61);
            this.atak_label.Name = "atak_label";
            this.atak_label.Size = new System.Drawing.Size(50, 13);
            this.atak_label.TabIndex = 1;
            this.atak_label.Text = "Ulke İsmi";
            // 
            // SyO_btn
            // 
            this.SyO_btn.Location = new System.Drawing.Point(199, 153);
            this.SyO_btn.Name = "SyO_btn";
            this.SyO_btn.Size = new System.Drawing.Size(90, 29);
            this.SyO_btn.TabIndex = 0;
            this.SyO_btn.Text = "Saldır yada Öl";
            this.SyO_btn.UseVisualStyleBackColor = true;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.def_Rec,
            this.ulkerec2,
            this.Atak_rec2,
            this.atak_ulkerec1});
            this.shapeContainer1.Size = new System.Drawing.Size(496, 194);
            this.shapeContainer1.TabIndex = 2;
            this.shapeContainer1.TabStop = false;
            // 
            // def_Rec
            // 
            this.def_Rec.BackColor = System.Drawing.SystemColors.Control;
            this.def_Rec.Cursor = System.Windows.Forms.Cursors.Default;
            this.def_Rec.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.def_Rec.Location = new System.Drawing.Point(334, 53);
            this.def_Rec.Name = "def_Rec";
            this.def_Rec.Size = new System.Drawing.Size(132, 25);
            // 
            // ulkerec2
            // 
            this.ulkerec2.BackColor = System.Drawing.SystemColors.Control;
            this.ulkerec2.Cursor = System.Windows.Forms.Cursors.Default;
            this.ulkerec2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.ulkerec2.Location = new System.Drawing.Point(333, 32);
            this.ulkerec2.Name = "ulkerec2";
            this.ulkerec2.Size = new System.Drawing.Size(135, 100);
            // 
            // Atak_rec2
            // 
            this.Atak_rec2.FillGradientColor = System.Drawing.Color.Black;
            this.Atak_rec2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.Atak_rec2.Location = new System.Drawing.Point(38, 53);
            this.Atak_rec2.Name = "Atak_rec2";
            this.Atak_rec2.Size = new System.Drawing.Size(131, 25);
            // 
            // atak_ulkerec1
            // 
            this.atak_ulkerec1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.atak_ulkerec1.Location = new System.Drawing.Point(38, 32);
            this.atak_ulkerec1.Name = "atak_ulkerec1";
            this.atak_ulkerec1.Size = new System.Drawing.Size(136, 100);
            // 
            // def_label
            // 
            this.def_label.AutoSize = true;
            this.def_label.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.def_label.Location = new System.Drawing.Point(372, 61);
            this.def_label.Name = "def_label";
            this.def_label.Size = new System.Drawing.Size(50, 13);
            this.def_label.TabIndex = 1;
            this.def_label.Text = "Ulke İsmi";
            // 
            // Asker_Atak
            // 
            this.Asker_Atak.AutoSize = true;
            this.Asker_Atak.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Asker_Atak.Location = new System.Drawing.Point(103, 101);
            this.Asker_Atak.Name = "Asker_Atak";
            this.Asker_Atak.Size = new System.Drawing.Size(59, 13);
            this.Asker_Atak.TabIndex = 1;
            this.Asker_Atak.Text = "Asker Adet";
            // 
            // Asker_def
            // 
            this.Asker_def.AutoSize = true;
            this.Asker_def.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Asker_def.Location = new System.Drawing.Point(395, 101);
            this.Asker_def.Name = "Asker_def";
            this.Asker_def.Size = new System.Drawing.Size(59, 13);
            this.Asker_def.TabIndex = 1;
            this.Asker_def.Text = "Asker Adet";
            // 
            // drmAtak
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 194);
            this.Controls.Add(this.Asker_def);
            this.Controls.Add(this.Asker_Atak);
            this.Controls.Add(this.def_label);
            this.Controls.Add(this.atak_label);
            this.Controls.Add(this.Saldır_Btn);
            this.Controls.Add(this.SyO_btn);
            this.Controls.Add(this.Iptal_btn);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "drmAtak";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "drmAtak";
            this.Load += new System.EventHandler(this.drmAtak_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Iptal_btn;
        private System.Windows.Forms.Button Saldır_Btn;
        private System.Windows.Forms.Label atak_label;
        private System.Windows.Forms.Button SyO_btn;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape atak_ulkerec1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape def_Rec;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape ulkerec2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape Atak_rec2;
        private System.Windows.Forms.Label def_label;
        private System.Windows.Forms.Label Asker_Atak;
        private System.Windows.Forms.Label Asker_def;
    }
}