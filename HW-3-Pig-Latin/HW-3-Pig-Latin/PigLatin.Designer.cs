namespace HW_3_Pig_Latin
{
    partial class PigLatin
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PigLatin));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.OutText = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.InTextBox = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnPig = new System.Windows.Forms.Button();
            this.PigPassThrough = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Enabled = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(688, 156);
            this.button2.Name = "button2";
            this.button2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button2.Size = new System.Drawing.Size(446, 329);
            this.button2.TabIndex = 7;
            this.button2.TabStop = false;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // OutText
            // 
            this.OutText.BackColor = System.Drawing.Color.White;
            this.OutText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.OutText.Location = new System.Drawing.Point(728, 185);
            this.OutText.Multiline = true;
            this.OutText.Name = "OutText";
            this.OutText.ReadOnly = true;
            this.OutText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.OutText.Size = new System.Drawing.Size(369, 195);
            this.OutText.TabIndex = 6;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.button3.Enabled = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(12, 3);
            this.button3.Name = "button3";
            this.button3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.button3.Size = new System.Drawing.Size(446, 329);
            this.button3.TabIndex = 8;
            this.button3.TabStop = false;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // InTextBox
            // 
            this.InTextBox.BackColor = System.Drawing.Color.White;
            this.InTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.InTextBox.Location = new System.Drawing.Point(52, 31);
            this.InTextBox.Multiline = true;
            this.InTextBox.Name = "InTextBox";
            this.InTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.InTextBox.Size = new System.Drawing.Size(372, 194);
            this.InTextBox.TabIndex = 2;
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.Transparent;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.ForeColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(24, 644);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(108, 34);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "&Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.ForestGreen;
            this.btnHelp.Location = new System.Drawing.Point(162, 644);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(108, 34);
            this.btnHelp.TabIndex = 4;
            this.btnHelp.Text = "&Help";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExit.Location = new System.Drawing.Point(1067, 654);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(108, 34);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnPig
            // 
            this.btnPig.BackColor = System.Drawing.Color.Transparent;
            this.btnPig.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPig.BackgroundImage")));
            this.btnPig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPig.FlatAppearance.BorderSize = 0;
            this.btnPig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnPig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnPig.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPig.Location = new System.Drawing.Point(496, 408);
            this.btnPig.Name = "btnPig";
            this.btnPig.Size = new System.Drawing.Size(203, 258);
            this.btnPig.TabIndex = 1;
            this.btnPig.UseVisualStyleBackColor = false;
            this.btnPig.Click += new System.EventHandler(this.btnPig_Click);
            // 
            // PigPassThrough
            // 
            this.PigPassThrough.BackColor = System.Drawing.Color.Transparent;
            this.PigPassThrough.FlatAppearance.BorderSize = 0;
            this.PigPassThrough.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.PigPassThrough.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.PigPassThrough.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PigPassThrough.Location = new System.Drawing.Point(560, 548);
            this.PigPassThrough.Name = "PigPassThrough";
            this.PigPassThrough.Size = new System.Drawing.Size(75, 23);
            this.PigPassThrough.TabIndex = 9;
            this.PigPassThrough.UseVisualStyleBackColor = false;
            this.PigPassThrough.Click += new System.EventHandler(this.btnPig_Click);
            // 
            // PigLatin
            // 
            this.AcceptButton = this.PigPassThrough;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1187, 700);
            this.Controls.Add(this.btnPig);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.InTextBox);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.OutText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PigPassThrough);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "PigLatin";
            this.Text = "Pig Latin";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.TextBox OutText;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox InTextBox;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPig;
        private System.Windows.Forms.Button PigPassThrough;
    }
}

