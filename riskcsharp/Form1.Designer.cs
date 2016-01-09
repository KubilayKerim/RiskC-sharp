namespace riskcsharp
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
            this.startbtn = new System.Windows.Forms.Button();
            this.renk2 = new System.Windows.Forms.LinkLabel();
            this.textBoxp2 = new System.Windows.Forms.TextBox();
            this.renk1 = new System.Windows.Forms.LinkLabel();
            this.txtbxp1 = new System.Windows.Forms.TextBox();
            this.oyncuismi1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.colorDialog2 = new System.Windows.Forms.ColorDialog();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.rectangleShape2 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.oyncuismi2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // startbtn
            // 
            this.startbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.startbtn.Location = new System.Drawing.Point(412, 225);
            this.startbtn.Name = "startbtn";
            this.startbtn.Size = new System.Drawing.Size(239, 103);
            this.startbtn.TabIndex = 11;
            this.startbtn.Text = "Başla ";
            this.startbtn.UseVisualStyleBackColor = true;
            this.startbtn.Click += new System.EventHandler(this.startbtn_Click);
            // 
            // renk2
            // 
            this.renk2.AutoSize = true;
            this.renk2.BackColor = System.Drawing.Color.Blue;
            this.renk2.DisabledLinkColor = System.Drawing.Color.White;
            this.renk2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.renk2.LinkColor = System.Drawing.Color.White;
            this.renk2.Location = new System.Drawing.Point(892, 258);
            this.renk2.Name = "renk2";
            this.renk2.Size = new System.Drawing.Size(85, 18);
            this.renk2.TabIndex = 10;
            this.renk2.TabStop = true;
            this.renk2.Text = "Renk Seç...";
            this.renk2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.renk2_LinkClicked);
            // 
            // textBoxp2
            // 
            this.textBoxp2.BackColor = System.Drawing.Color.Blue;
            this.textBoxp2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBoxp2.ForeColor = System.Drawing.SystemColors.Info;
            this.textBoxp2.Location = new System.Drawing.Point(855, 163);
            this.textBoxp2.Name = "textBoxp2";
            this.textBoxp2.Size = new System.Drawing.Size(139, 24);
            this.textBoxp2.TabIndex = 9;
            this.textBoxp2.Text = "Player2";
            // 
            // renk1
            // 
            this.renk1.AutoSize = true;
            this.renk1.BackColor = System.Drawing.Color.Red;
            this.renk1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.renk1.LinkColor = System.Drawing.Color.White;
            this.renk1.Location = new System.Drawing.Point(82, 267);
            this.renk1.Name = "renk1";
            this.renk1.Size = new System.Drawing.Size(85, 18);
            this.renk1.TabIndex = 8;
            this.renk1.TabStop = true;
            this.renk1.Text = "Renk Seç...";
            this.renk1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.renk1_LinkClicked);
            // 
            // txtbxp1
            // 
            this.txtbxp1.BackColor = System.Drawing.Color.Red;
            this.txtbxp1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtbxp1.ForeColor = System.Drawing.SystemColors.Info;
            this.txtbxp1.Location = new System.Drawing.Point(64, 163);
            this.txtbxp1.Name = "txtbxp1";
            this.txtbxp1.Size = new System.Drawing.Size(139, 24);
            this.txtbxp1.TabIndex = 7;
            this.txtbxp1.Text = "Player1";
            // 
            // oyncuismi1
            // 
            this.oyncuismi1.AutoSize = true;
            this.oyncuismi1.BackColor = System.Drawing.Color.Red;
            this.oyncuismi1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyncuismi1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.oyncuismi1.Location = new System.Drawing.Point(82, 122);
            this.oyncuismi1.Name = "oyncuismi1";
            this.oyncuismi1.Size = new System.Drawing.Size(90, 18);
            this.oyncuismi1.TabIndex = 6;
            this.oyncuismi1.Text = "Oyuncu İsmi";
            // 
            // colorDialog1
            // 
            this.colorDialog1.AllowFullOpen = false;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape2,
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1058, 400);
            this.shapeContainer1.TabIndex = 13;
            this.shapeContainer1.TabStop = false;
            // 
            // rectangleShape2
            // 
            this.rectangleShape2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rectangleShape2.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape2.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.rectangleShape2.Cursor = System.Windows.Forms.Cursors.Default;
            this.rectangleShape2.FillColor = System.Drawing.Color.Blue;
            this.rectangleShape2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape2.Location = new System.Drawing.Point(776, 0);
            this.rectangleShape2.Name = "rectangleShape1";
            this.rectangleShape2.SelectionColor = System.Drawing.Color.Maroon;
            this.rectangleShape2.Size = new System.Drawing.Size(283, 397);
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rectangleShape1.BackStyle = Microsoft.VisualBasic.PowerPacks.BackStyle.Opaque;
            this.rectangleShape1.BorderStyle = System.Drawing.Drawing2D.DashStyle.DashDotDot;
            this.rectangleShape1.FillColor = System.Drawing.Color.Red;
            this.rectangleShape1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.rectangleShape1.Location = new System.Drawing.Point(-1, 1);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.SelectionColor = System.Drawing.Color.Maroon;
            this.rectangleShape1.Size = new System.Drawing.Size(283, 401);
            // 
            // oyncuismi2
            // 
            this.oyncuismi2.AutoSize = true;
            this.oyncuismi2.BackColor = System.Drawing.Color.Blue;
            this.oyncuismi2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.oyncuismi2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.oyncuismi2.Location = new System.Drawing.Point(874, 122);
            this.oyncuismi2.Name = "oyncuismi2";
            this.oyncuismi2.Size = new System.Drawing.Size(90, 18);
            this.oyncuismi2.TabIndex = 6;
            this.oyncuismi2.Text = "Oyuncu İsmi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poor Richard", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SeaGreen;
            this.label1.Location = new System.Drawing.Point(430, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 108);
            this.label1.TabIndex = 14;
            this.label1.Text = "Risk";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1058, 400);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.oyncuismi2);
            this.Controls.Add(this.startbtn);
            this.Controls.Add(this.renk2);
            this.Controls.Add(this.textBoxp2);
            this.Controls.Add(this.renk1);
            this.Controls.Add(this.txtbxp1);
            this.Controls.Add(this.oyncuismi1);
            this.Controls.Add(this.shapeContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startbtn;
        private System.Windows.Forms.LinkLabel renk2;
        private System.Windows.Forms.TextBox textBoxp2;
        private System.Windows.Forms.LinkLabel renk1;
        private System.Windows.Forms.TextBox txtbxp1;
        private System.Windows.Forms.Label oyncuismi1;
        private System.Windows.Forms.ColorDialog colorDialog2;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape2;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
        private System.Windows.Forms.Label oyncuismi2;
        private System.Windows.Forms.Label label1;
    }
}

