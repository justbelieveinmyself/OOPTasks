
namespace Task1OOP
{
    partial class Form4
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.buttonGetNumMyType = new System.Windows.Forms.Button();
            this.labelRes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxIn = new System.Windows.Forms.ComboBox();
            this.comboBoxOut = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(130, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 34);
            this.label1.TabIndex = 15;
            this.label1.Text = "Из:";
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInput.Location = new System.Drawing.Point(309, 200);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(146, 30);
            this.textBoxInput.TabIndex = 16;
            // 
            // buttonGetNumMyType
            // 
            this.buttonGetNumMyType.Location = new System.Drawing.Point(292, 143);
            this.buttonGetNumMyType.Name = "buttonGetNumMyType";
            this.buttonGetNumMyType.Size = new System.Drawing.Size(192, 31);
            this.buttonGetNumMyType.TabIndex = 18;
            this.buttonGetNumMyType.Text = "Вычислить";
            this.buttonGetNumMyType.UseVisualStyleBackColor = true;
            this.buttonGetNumMyType.Click += new System.EventHandler(this.buttonGetNumMyType_Click);
            // 
            // labelRes
            // 
            this.labelRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRes.Location = new System.Drawing.Point(304, 279);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(242, 35);
            this.labelRes.TabIndex = 19;
            this.labelRes.Text = "0";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(607, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 34);
            this.label4.TabIndex = 21;
            this.label4.Text = "В:";
            // 
            // comboBoxIn
            // 
            this.comboBoxIn.FormattingEnabled = true;
            this.comboBoxIn.Items.AddRange(new object[] {
            "char ",
            "string",
            "byte",
            "int",
            "float",
            "double",
            "decimal",
            "bool",
            "object"});
            this.comboBoxIn.Location = new System.Drawing.Point(90, 150);
            this.comboBoxIn.Name = "comboBoxIn";
            this.comboBoxIn.Size = new System.Drawing.Size(121, 24);
            this.comboBoxIn.TabIndex = 22;
            // 
            // comboBoxOut
            // 
            this.comboBoxOut.FormattingEnabled = true;
            this.comboBoxOut.Items.AddRange(new object[] {
            "char ",
            "string",
            "byte",
            "int",
            "float",
            "double",
            "decimal",
            "bool",
            "object"});
            this.comboBoxOut.Location = new System.Drawing.Point(566, 150);
            this.comboBoxOut.Name = "comboBoxOut";
            this.comboBoxOut.Size = new System.Drawing.Size(121, 24);
            this.comboBoxOut.TabIndex = 23;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBoxOut);
            this.Controls.Add(this.comboBoxIn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.buttonGetNumMyType);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.label1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Button buttonGetNumMyType;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxIn;
        private System.Windows.Forms.ComboBox comboBoxOut;
    }
}