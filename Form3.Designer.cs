
namespace Task1OOP
{
    partial class Form3
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
            this.label1Task = new System.Windows.Forms.Label();
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelBinary = new System.Windows.Forms.Label();
            this.buttonGetBinary = new System.Windows.Forms.Button();
            this.buttonTo2Task = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1Task
            // 
            this.label1Task.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1Task.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1Task.Location = new System.Drawing.Point(0, 0);
            this.label1Task.Name = "label1Task";
            this.label1Task.Size = new System.Drawing.Size(807, 76);
            this.label1Task.TabIndex = 2;
            this.label1Task.Text = "3rd task";
            this.label1Task.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxInput
            // 
            this.textBoxInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInput.Location = new System.Drawing.Point(197, 84);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(146, 30);
            this.textBoxInput.TabIndex = 11;
            this.textBoxInput.TextChanged += new System.EventHandler(this.textBoxInput_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 33);
            this.label1.TabIndex = 14;
            this.label1.Text = "Введите число:";
            // 
            // labelBinary
            // 
            this.labelBinary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelBinary.Location = new System.Drawing.Point(192, 139);
            this.labelBinary.Name = "labelBinary";
            this.labelBinary.Size = new System.Drawing.Size(414, 33);
            this.labelBinary.TabIndex = 16;
            this.labelBinary.Text = "0";
            // 
            // buttonGetBinary
            // 
            this.buttonGetBinary.Location = new System.Drawing.Point(374, 83);
            this.buttonGetBinary.Name = "buttonGetBinary";
            this.buttonGetBinary.Size = new System.Drawing.Size(192, 31);
            this.buttonGetBinary.TabIndex = 17;
            this.buttonGetBinary.Text = "Вычислить";
            this.buttonGetBinary.UseVisualStyleBackColor = true;
            this.buttonGetBinary.Click += new System.EventHandler(this.buttonGetBinary_Click);
            // 
            // buttonTo2Task
            // 
            this.buttonTo2Task.Location = new System.Drawing.Point(333, 268);
            this.buttonTo2Task.Name = "buttonTo2Task";
            this.buttonTo2Task.Size = new System.Drawing.Size(172, 76);
            this.buttonTo2Task.TabIndex = 18;
            this.buttonTo2Task.Text = "Перейти к 2 заданию";
            this.buttonTo2Task.UseVisualStyleBackColor = true;
            this.buttonTo2Task.Click += new System.EventHandler(this.buttonTo2Task_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 76);
            this.button1.TabIndex = 19;
            this.button1.Text = "Перейти к 1 заданию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 374);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonTo2Task);
            this.Controls.Add(this.buttonGetBinary);
            this.Controls.Add(this.labelBinary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxInput);
            this.Controls.Add(this.label1Task);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1Task;
        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelBinary;
        private System.Windows.Forms.Button buttonGetBinary;
        private System.Windows.Forms.Button buttonTo2Task;
        private System.Windows.Forms.Button button1;
    }
}