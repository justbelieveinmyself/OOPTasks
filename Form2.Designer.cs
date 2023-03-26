
namespace Task1OOP
{
    partial class Form2
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
            this.buttonTo3Task = new System.Windows.Forms.Button();
            this.label2Task = new System.Windows.Forms.Label();
            this.textBoxInputSquare = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxInitValue = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.buttonGetMathSquare = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxOutputMathSqrt = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.buttonIteration = new System.Windows.Forms.Button();
            this.buttonGetNewtonSquare = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxOutputNewton = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelFault = new System.Windows.Forms.Label();
            this.labelChanges = new System.Windows.Forms.Label();
            this.labelIteration = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonTo3Task
            // 
            this.buttonTo3Task.Location = new System.Drawing.Point(609, 314);
            this.buttonTo3Task.Name = "buttonTo3Task";
            this.buttonTo3Task.Size = new System.Drawing.Size(198, 57);
            this.buttonTo3Task.TabIndex = 0;
            this.buttonTo3Task.Text = "Перейти к следующему заданию";
            this.buttonTo3Task.UseVisualStyleBackColor = true;
            this.buttonTo3Task.Click += new System.EventHandler(this.buttonTo3Task_Click);
            // 
            // label2Task
            // 
            this.label2Task.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2Task.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2Task.Location = new System.Drawing.Point(0, 0);
            this.label2Task.Name = "label2Task";
            this.label2Task.Size = new System.Drawing.Size(807, 44);
            this.label2Task.TabIndex = 2;
            this.label2Task.Text = "2nd task";
            this.label2Task.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxInputSquare
            // 
            this.textBoxInputSquare.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInputSquare.Location = new System.Drawing.Point(11, 62);
            this.textBoxInputSquare.Name = "textBoxInputSquare";
            this.textBoxInputSquare.Size = new System.Drawing.Size(146, 30);
            this.textBoxInputSquare.TabIndex = 10;
            this.textBoxInputSquare.TextChanged += new System.EventHandler(this.textBoxInputSquare_TextChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(6, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 33);
            this.label1.TabIndex = 13;
            this.label1.Text = "Введите число:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.textBoxInputSquare);
            this.panel1.Location = new System.Drawing.Point(22, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 106);
            this.panel1.TabIndex = 14;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBoxInitValue);
            this.panel2.Location = new System.Drawing.Point(22, 172);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 132);
            this.panel2.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(4, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 60);
            this.label2.TabIndex = 13;
            this.label2.Text = "Введите начальное приближение:";
            // 
            // textBoxInitValue
            // 
            this.textBoxInitValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxInitValue.Location = new System.Drawing.Point(9, 77);
            this.textBoxInitValue.Name = "textBoxInitValue";
            this.textBoxInitValue.Size = new System.Drawing.Size(146, 30);
            this.textBoxInitValue.TabIndex = 10;
            this.textBoxInitValue.Text = "1";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.buttonGetMathSquare);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.textBoxOutputMathSqrt);
            this.panel3.Location = new System.Drawing.Point(242, 47);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(553, 106);
            this.panel3.TabIndex = 15;
            // 
            // buttonGetMathSquare
            // 
            this.buttonGetMathSquare.Location = new System.Drawing.Point(239, 62);
            this.buttonGetMathSquare.Name = "buttonGetMathSquare";
            this.buttonGetMathSquare.Size = new System.Drawing.Size(192, 31);
            this.buttonGetMathSquare.TabIndex = 16;
            this.buttonGetMathSquare.Text = "Вычислить";
            this.buttonGetMathSquare.UseVisualStyleBackColor = true;
            this.buttonGetMathSquare.Click += new System.EventHandler(this.buttonGetMathSquare_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(45, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(503, 33);
            this.label3.TabIndex = 13;
            this.label3.Text = "Вычисление с помощью Math.Sqrt:";
            // 
            // textBoxOutputMathSqrt
            // 
            this.textBoxOutputMathSqrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOutputMathSqrt.Location = new System.Drawing.Point(50, 62);
            this.textBoxOutputMathSqrt.Name = "textBoxOutputMathSqrt";
            this.textBoxOutputMathSqrt.Size = new System.Drawing.Size(146, 30);
            this.textBoxOutputMathSqrt.TabIndex = 10;
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.buttonIteration);
            this.panel4.Controls.Add(this.buttonGetNewtonSquare);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.textBoxOutputNewton);
            this.panel4.Location = new System.Drawing.Point(242, 174);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(553, 130);
            this.panel4.TabIndex = 17;
            // 
            // buttonIteration
            // 
            this.buttonIteration.Location = new System.Drawing.Point(317, 88);
            this.buttonIteration.Name = "buttonIteration";
            this.buttonIteration.Size = new System.Drawing.Size(192, 31);
            this.buttonIteration.TabIndex = 17;
            this.buttonIteration.Text = "Итерация";
            this.buttonIteration.UseVisualStyleBackColor = true;
            this.buttonIteration.Click += new System.EventHandler(this.buttonIteration_Click);
            // 
            // buttonGetNewtonSquare
            // 
            this.buttonGetNewtonSquare.Location = new System.Drawing.Point(50, 88);
            this.buttonGetNewtonSquare.Name = "buttonGetNewtonSquare";
            this.buttonGetNewtonSquare.Size = new System.Drawing.Size(192, 31);
            this.buttonGetNewtonSquare.TabIndex = 16;
            this.buttonGetNewtonSquare.Text = "Вычислить";
            this.buttonGetNewtonSquare.UseVisualStyleBackColor = true;
            this.buttonGetNewtonSquare.Click += new System.EventHandler(this.buttonGetNewtonSquare_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(45, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(503, 33);
            this.label4.TabIndex = 13;
            this.label4.Text = "Вычисление с помощью метода Ньютона:";
            // 
            // textBoxOutputNewton
            // 
            this.textBoxOutputNewton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOutputNewton.Location = new System.Drawing.Point(50, 49);
            this.textBoxOutputNewton.Name = "textBoxOutputNewton";
            this.textBoxOutputNewton.Size = new System.Drawing.Size(459, 30);
            this.textBoxOutputNewton.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.labelFault);
            this.panel5.Controls.Add(this.labelChanges);
            this.panel5.Controls.Add(this.labelIteration);
            this.panel5.Location = new System.Drawing.Point(22, 310);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(581, 122);
            this.panel5.TabIndex = 18;
            // 
            // labelFault
            // 
            this.labelFault.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFault.Location = new System.Drawing.Point(6, 81);
            this.labelFault.Name = "labelFault";
            this.labelFault.Size = new System.Drawing.Size(414, 33);
            this.labelFault.TabIndex = 15;
            this.labelFault.Text = "Погрешность: ";
            // 
            // labelChanges
            // 
            this.labelChanges.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelChanges.Location = new System.Drawing.Point(6, 48);
            this.labelChanges.Name = "labelChanges";
            this.labelChanges.Size = new System.Drawing.Size(414, 33);
            this.labelChanges.TabIndex = 14;
            this.labelChanges.Text = "Изменения:";
            // 
            // labelIteration
            // 
            this.labelIteration.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIteration.Location = new System.Drawing.Point(6, 16);
            this.labelIteration.Name = "labelIteration";
            this.labelIteration.Size = new System.Drawing.Size(414, 33);
            this.labelIteration.TabIndex = 13;
            this.labelIteration.Text = "Итерация: ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(609, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 57);
            this.button1.TabIndex = 19;
            this.button1.Text = "Перейти к 1 заданию";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(807, 444);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2Task);
            this.Controls.Add(this.buttonTo3Task);
            this.Name = "Form2";
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonTo3Task;
        private System.Windows.Forms.Label label2Task;
        private System.Windows.Forms.TextBox textBoxInputSquare;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxInitValue;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button buttonGetMathSquare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxOutputMathSqrt;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button buttonIteration;
        private System.Windows.Forms.Button buttonGetNewtonSquare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxOutputNewton;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelFault;
        private System.Windows.Forms.Label labelChanges;
        private System.Windows.Forms.Label labelIteration;
        private System.Windows.Forms.Button button1;
    }
}