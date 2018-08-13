namespace cityNameGenerator
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
            this.italianButton = new System.Windows.Forms.RadioButton();
            this.germanButton = new System.Windows.Forms.RadioButton();
            this.menButton = new System.Windows.Forms.RadioButton();
            this.evilButton = new System.Windows.Forms.RadioButton();
            this.elvenButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.genButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.displayBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // italianButton
            // 
            this.italianButton.AutoSize = true;
            this.italianButton.Font = new System.Drawing.Font("Caviar Dreams", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.italianButton.Location = new System.Drawing.Point(59, 104);
            this.italianButton.Name = "italianButton";
            this.italianButton.Size = new System.Drawing.Size(88, 29);
            this.italianButton.TabIndex = 0;
            this.italianButton.TabStop = true;
            this.italianButton.Text = "Italian";
            this.italianButton.UseVisualStyleBackColor = true;
            // 
            // germanButton
            // 
            this.germanButton.AutoSize = true;
            this.germanButton.Font = new System.Drawing.Font("Caviar Dreams", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.germanButton.Location = new System.Drawing.Point(250, 104);
            this.germanButton.Name = "germanButton";
            this.germanButton.Size = new System.Drawing.Size(104, 29);
            this.germanButton.TabIndex = 1;
            this.germanButton.TabStop = true;
            this.germanButton.Text = "German";
            this.germanButton.UseVisualStyleBackColor = true;
            // 
            // menButton
            // 
            this.menButton.AutoSize = true;
            this.menButton.Font = new System.Drawing.Font("Caviar Dreams", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menButton.Location = new System.Drawing.Point(388, 104);
            this.menButton.Name = "menButton";
            this.menButton.Size = new System.Drawing.Size(154, 29);
            this.menButton.TabIndex = 2;
            this.menButton.TabStop = true;
            this.menButton.Text = "Realm of men";
            this.menButton.UseVisualStyleBackColor = true;
            // 
            // evilButton
            // 
            this.evilButton.AutoSize = true;
            this.evilButton.Font = new System.Drawing.Font("Caviar Dreams", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evilButton.Location = new System.Drawing.Point(59, 154);
            this.evilButton.Name = "evilButton";
            this.evilButton.Size = new System.Drawing.Size(60, 29);
            this.evilButton.TabIndex = 3;
            this.evilButton.TabStop = true;
            this.evilButton.Text = "Evil";
            this.evilButton.UseVisualStyleBackColor = true;
            // 
            // elvenButton
            // 
            this.elvenButton.AutoSize = true;
            this.elvenButton.Font = new System.Drawing.Font("Caviar Dreams", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.elvenButton.Location = new System.Drawing.Point(250, 154);
            this.elvenButton.Name = "elvenButton";
            this.elvenButton.Size = new System.Drawing.Size(79, 29);
            this.elvenButton.TabIndex = 4;
            this.elvenButton.TabStop = true;
            this.elvenButton.Text = "Elven";
            this.elvenButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Caviar Dreams", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(493, 56);
            this.label1.TabIndex = 5;
            this.label1.Text = "City Name Generator";
            // 
            // genButton
            // 
            this.genButton.Font = new System.Drawing.Font("Caviar Dreams", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genButton.Location = new System.Drawing.Point(180, 401);
            this.genButton.Name = "genButton";
            this.genButton.Size = new System.Drawing.Size(220, 88);
            this.genButton.TabIndex = 6;
            this.genButton.Text = "Generate";
            this.genButton.UseVisualStyleBackColor = true;
            this.genButton.Click += new System.EventHandler(this.genButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Caviar Dreams", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(263, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "Names";
            // 
            // displayBox
            // 
            this.displayBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.displayBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.displayBox.Font = new System.Drawing.Font("Caviar Dreams", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayBox.Location = new System.Drawing.Point(79, 231);
            this.displayBox.Multiline = true;
            this.displayBox.Name = "displayBox";
            this.displayBox.Size = new System.Drawing.Size(437, 164);
            this.displayBox.TabIndex = 8;
            this.displayBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 531);
            this.Controls.Add(this.displayBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.genButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.elvenButton);
            this.Controls.Add(this.evilButton);
            this.Controls.Add(this.menButton);
            this.Controls.Add(this.germanButton);
            this.Controls.Add(this.italianButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton italianButton;
        private System.Windows.Forms.RadioButton germanButton;
        private System.Windows.Forms.RadioButton menButton;
        private System.Windows.Forms.RadioButton evilButton;
        private System.Windows.Forms.RadioButton elvenButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button genButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox displayBox;
    }
}

