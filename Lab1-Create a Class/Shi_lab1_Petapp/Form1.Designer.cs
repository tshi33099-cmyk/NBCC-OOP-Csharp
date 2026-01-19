namespace Shi_lab1_Petapp
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPetName = new System.Windows.Forms.TextBox();
            this.nudAge = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoCat = new System.Windows.Forms.RadioButton();
            this.rdoBird = new System.Windows.Forms.RadioButton();
            this.rdoDog = new System.Windows.Forms.RadioButton();
            this.lstOutput = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(173, 121);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 39);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(173, 197);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(114, 38);
            this.btnClear.TabIndex = 1;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pet Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Age:";
            // 
            // txtPetName
            // 
            this.txtPetName.Location = new System.Drawing.Point(127, 22);
            this.txtPetName.Name = "txtPetName";
            this.txtPetName.Size = new System.Drawing.Size(148, 26);
            this.txtPetName.TabIndex = 4;
            // 
            // nudAge
            // 
            this.nudAge.Location = new System.Drawing.Point(127, 58);
            this.nudAge.Name = "nudAge";
            this.nudAge.Size = new System.Drawing.Size(85, 26);
            this.nudAge.TabIndex = 5;
            this.nudAge.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoCat);
            this.groupBox1.Controls.Add(this.rdoBird);
            this.groupBox1.Controls.Add(this.rdoDog);
            this.groupBox1.Location = new System.Drawing.Point(30, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(125, 151);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Type";
            // 
            // rdoCat
            // 
            this.rdoCat.AutoSize = true;
            this.rdoCat.Location = new System.Drawing.Point(20, 58);
            this.rdoCat.Name = "rdoCat";
            this.rdoCat.Size = new System.Drawing.Size(51, 23);
            this.rdoCat.TabIndex = 9;
            this.rdoCat.TabStop = true;
            this.rdoCat.Text = "Cat";
            this.rdoCat.UseVisualStyleBackColor = true;
            // 
            // rdoBird
            // 
            this.rdoBird.AutoSize = true;
            this.rdoBird.Location = new System.Drawing.Point(20, 29);
            this.rdoBird.Name = "rdoBird";
            this.rdoBird.Size = new System.Drawing.Size(59, 23);
            this.rdoBird.TabIndex = 7;
            this.rdoBird.TabStop = true;
            this.rdoBird.Text = "Bird";
            this.rdoBird.UseVisualStyleBackColor = true;
       
            // 
            // rdoDog
            // 
            this.rdoDog.AutoSize = true;
            this.rdoDog.Location = new System.Drawing.Point(20, 89);
            this.rdoDog.Name = "rdoDog";
            this.rdoDog.Size = new System.Drawing.Size(55, 23);
            this.rdoDog.TabIndex = 8;
            this.rdoDog.TabStop = true;
            this.rdoDog.Text = "Dog";
            this.rdoDog.UseVisualStyleBackColor = true;
            // 
            // lstOutput
            // 
            this.lstOutput.FormattingEnabled = true;
            this.lstOutput.ItemHeight = 19;
            this.lstOutput.Location = new System.Drawing.Point(313, 34);
            this.lstOutput.Name = "lstOutput";
            this.lstOutput.Size = new System.Drawing.Size(284, 194);
            this.lstOutput.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 271);
            this.Controls.Add(this.lstOutput);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.nudAge);
            this.Controls.Add(this.txtPetName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSave);
            this.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "lab1 by tiantianshi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudAge)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPetName;
        private System.Windows.Forms.NumericUpDown nudAge;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoBird;
        private System.Windows.Forms.RadioButton rdoDog;
        private System.Windows.Forms.RadioButton rdoCat;
        private System.Windows.Forms.ListBox lstOutput;
    }
}

