namespace Hex_Color
{
    partial class Main
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
            this.btnFromHex = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.R = new System.Windows.Forms.TextBox();
            this.G = new System.Windows.Forms.TextBox();
            this.B = new System.Windows.Forms.TextBox();
            this.btnFromRGB = new System.Windows.Forms.Button();
            this.boxColor = new System.Windows.Forms.PictureBox();
            this.C = new System.Windows.Forms.TextBox();
            this.Y = new System.Windows.Forms.TextBox();
            this.M = new System.Windows.Forms.TextBox();
            this.K = new System.Windows.Forms.TextBox();
            this.btnFromCMYK = new System.Windows.Forms.Button();
            this.lblHexa = new System.Windows.Forms.Label();
            this.lblRGB = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblCMYK = new System.Windows.Forms.Label();
            this.lblCyan = new System.Windows.Forms.Label();
            this.lblMagent = new System.Windows.Forms.Label();
            this.lblYellow = new System.Windows.Forms.Label();
            this.lblBlack = new System.Windows.Forms.Label();
            this.lblSampleColor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.boxColor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnFromHex
            // 
            this.btnFromHex.Location = new System.Drawing.Point(23, 140);
            this.btnFromHex.Name = "btnFromHex";
            this.btnFromHex.Size = new System.Drawing.Size(75, 23);
            this.btnFromHex.TabIndex = 0;
            this.btnFromHex.Text = "from Hex";
            this.btnFromHex.UseVisualStyleBackColor = true;
            this.btnFromHex.Click += new System.EventHandler(this.btnFromHex_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(23, 40);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(100, 20);
            this.txtNumber.TabIndex = 2;
            this.txtNumber.Text = "#000000";
            // 
            // R
            // 
            this.R.Location = new System.Drawing.Point(176, 40);
            this.R.Name = "R";
            this.R.Size = new System.Drawing.Size(100, 20);
            this.R.TabIndex = 3;
            this.R.Text = "0";
            // 
            // G
            // 
            this.G.Location = new System.Drawing.Point(176, 67);
            this.G.Name = "G";
            this.G.Size = new System.Drawing.Size(100, 20);
            this.G.TabIndex = 4;
            this.G.Text = "0";
            // 
            // B
            // 
            this.B.Location = new System.Drawing.Point(176, 94);
            this.B.Name = "B";
            this.B.Size = new System.Drawing.Size(100, 20);
            this.B.TabIndex = 5;
            this.B.Text = "0";
            // 
            // btnFromRGB
            // 
            this.btnFromRGB.Location = new System.Drawing.Point(176, 140);
            this.btnFromRGB.Name = "btnFromRGB";
            this.btnFromRGB.Size = new System.Drawing.Size(75, 23);
            this.btnFromRGB.TabIndex = 6;
            this.btnFromRGB.Text = "from RGB";
            this.btnFromRGB.UseVisualStyleBackColor = true;
            this.btnFromRGB.Click += new System.EventHandler(this.btnFromRGB_Click);
            // 
            // boxColor
            // 
            this.boxColor.Location = new System.Drawing.Point(23, 344);
            this.boxColor.Name = "boxColor";
            this.boxColor.Size = new System.Drawing.Size(253, 50);
            this.boxColor.TabIndex = 7;
            this.boxColor.TabStop = false;
            // 
            // C
            // 
            this.C.Location = new System.Drawing.Point(23, 252);
            this.C.Name = "C";
            this.C.Size = new System.Drawing.Size(100, 20);
            this.C.TabIndex = 8;
            // 
            // Y
            // 
            this.Y.Location = new System.Drawing.Point(23, 297);
            this.Y.Name = "Y";
            this.Y.Size = new System.Drawing.Size(100, 20);
            this.Y.TabIndex = 9;
            // 
            // M
            // 
            this.M.Location = new System.Drawing.Point(176, 251);
            this.M.Name = "M";
            this.M.Size = new System.Drawing.Size(100, 20);
            this.M.TabIndex = 10;
            // 
            // K
            // 
            this.K.Location = new System.Drawing.Point(176, 297);
            this.K.Name = "K";
            this.K.Size = new System.Drawing.Size(100, 20);
            this.K.TabIndex = 11;
            // 
            // btnFromCMYK
            // 
            this.btnFromCMYK.Location = new System.Drawing.Point(23, 179);
            this.btnFromCMYK.Name = "btnFromCMYK";
            this.btnFromCMYK.Size = new System.Drawing.Size(75, 23);
            this.btnFromCMYK.TabIndex = 12;
            this.btnFromCMYK.Text = "from CMYK";
            this.btnFromCMYK.UseVisualStyleBackColor = true;
            this.btnFromCMYK.Click += new System.EventHandler(this.btnFromCMYK_Click);
            // 
            // lblHexa
            // 
            this.lblHexa.AutoSize = true;
            this.lblHexa.Location = new System.Drawing.Point(23, 21);
            this.lblHexa.Name = "lblHexa";
            this.lblHexa.Size = new System.Drawing.Size(32, 13);
            this.lblHexa.TabIndex = 13;
            this.lblHexa.Text = "Hexa";
            // 
            // lblRGB
            // 
            this.lblRGB.AutoSize = true;
            this.lblRGB.Location = new System.Drawing.Point(176, 21);
            this.lblRGB.Name = "lblRGB";
            this.lblRGB.Size = new System.Drawing.Size(30, 13);
            this.lblRGB.TabIndex = 14;
            this.lblRGB.Text = "RGB";
            // 
            // lblRed
            // 
            this.lblRed.AutoSize = true;
            this.lblRed.Location = new System.Drawing.Point(135, 46);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(27, 13);
            this.lblRed.TabIndex = 15;
            this.lblRed.Text = "Red";
            // 
            // lblGreen
            // 
            this.lblGreen.AutoSize = true;
            this.lblGreen.Location = new System.Drawing.Point(135, 73);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(36, 13);
            this.lblGreen.TabIndex = 16;
            this.lblGreen.Text = "Green";
            // 
            // lblBlue
            // 
            this.lblBlue.AutoSize = true;
            this.lblBlue.Location = new System.Drawing.Point(135, 100);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(28, 13);
            this.lblBlue.TabIndex = 17;
            this.lblBlue.Text = "Blue";
            // 
            // lblCMYK
            // 
            this.lblCMYK.AutoSize = true;
            this.lblCMYK.Location = new System.Drawing.Point(23, 213);
            this.lblCMYK.Name = "lblCMYK";
            this.lblCMYK.Size = new System.Drawing.Size(37, 13);
            this.lblCMYK.TabIndex = 18;
            this.lblCMYK.Text = "CMYK";
            // 
            // lblCyan
            // 
            this.lblCyan.AutoSize = true;
            this.lblCyan.Location = new System.Drawing.Point(23, 235);
            this.lblCyan.Name = "lblCyan";
            this.lblCyan.Size = new System.Drawing.Size(31, 13);
            this.lblCyan.TabIndex = 19;
            this.lblCyan.Text = "Cyan";
            // 
            // lblMagent
            // 
            this.lblMagent.AutoSize = true;
            this.lblMagent.Location = new System.Drawing.Point(179, 234);
            this.lblMagent.Name = "lblMagent";
            this.lblMagent.Size = new System.Drawing.Size(43, 13);
            this.lblMagent.TabIndex = 20;
            this.lblMagent.Text = "Magent";
            // 
            // lblYellow
            // 
            this.lblYellow.AutoSize = true;
            this.lblYellow.Location = new System.Drawing.Point(23, 280);
            this.lblYellow.Name = "lblYellow";
            this.lblYellow.Size = new System.Drawing.Size(38, 13);
            this.lblYellow.TabIndex = 21;
            this.lblYellow.Text = "Yellow";
            // 
            // lblBlack
            // 
            this.lblBlack.AutoSize = true;
            this.lblBlack.Location = new System.Drawing.Point(179, 281);
            this.lblBlack.Name = "lblBlack";
            this.lblBlack.Size = new System.Drawing.Size(34, 13);
            this.lblBlack.TabIndex = 22;
            this.lblBlack.Text = "Black";
            // 
            // lblSampleColor
            // 
            this.lblSampleColor.AutoSize = true;
            this.lblSampleColor.Location = new System.Drawing.Point(23, 324);
            this.lblSampleColor.Name = "lblSampleColor";
            this.lblSampleColor.Size = new System.Drawing.Size(69, 13);
            this.lblSampleColor.TabIndex = 23;
            this.lblSampleColor.Text = "Sample Color";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 407);
            this.Controls.Add(this.lblSampleColor);
            this.Controls.Add(this.lblBlack);
            this.Controls.Add(this.lblYellow);
            this.Controls.Add(this.lblMagent);
            this.Controls.Add(this.lblCyan);
            this.Controls.Add(this.lblCMYK);
            this.Controls.Add(this.lblBlue);
            this.Controls.Add(this.lblGreen);
            this.Controls.Add(this.lblRed);
            this.Controls.Add(this.lblRGB);
            this.Controls.Add(this.lblHexa);
            this.Controls.Add(this.btnFromCMYK);
            this.Controls.Add(this.K);
            this.Controls.Add(this.M);
            this.Controls.Add(this.Y);
            this.Controls.Add(this.C);
            this.Controls.Add(this.boxColor);
            this.Controls.Add(this.btnFromRGB);
            this.Controls.Add(this.B);
            this.Controls.Add(this.G);
            this.Controls.Add(this.R);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnFromHex);
            this.Name = "Main";
            this.Text = "Hex Color";
            ((System.ComponentModel.ISupportInitialize)(this.boxColor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFromHex;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.TextBox R;
        private System.Windows.Forms.TextBox G;
        private System.Windows.Forms.TextBox B;
        private System.Windows.Forms.Button btnFromRGB;
        private System.Windows.Forms.PictureBox boxColor;
        private System.Windows.Forms.TextBox C;
        private System.Windows.Forms.TextBox Y;
        private System.Windows.Forms.TextBox M;
        private System.Windows.Forms.TextBox K;
        private System.Windows.Forms.Button btnFromCMYK;
        private System.Windows.Forms.Label lblHexa;
        private System.Windows.Forms.Label lblRGB;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblCMYK;
        private System.Windows.Forms.Label lblCyan;
        private System.Windows.Forms.Label lblMagent;
        private System.Windows.Forms.Label lblYellow;
        private System.Windows.Forms.Label lblBlack;
        private System.Windows.Forms.Label lblSampleColor;
    }
}

