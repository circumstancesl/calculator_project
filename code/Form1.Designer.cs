namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnDelete = new Button();
            textBoxResult = new TextBox();
            btnCE = new Button();
            btnC = new Button();
            btnMod = new Button();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnMultiplication = new Button();
            btn4 = new Button();
            btn1 = new Button();
            btn0 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMinus = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnPlus = new Button();
            btnDot = new Button();
            btnEquals = new Button();
            btnDivision = new Button();
            lblShopOp = new Label();
            btnSave = new Button();
            btnRestore = new Button();
            SuspendLayout();
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDelete.Location = new Point(15, 64);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(60, 55);
            btnDelete.TabIndex = 0;
            btnDelete.Text = "⌫";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(15, 13);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(258, 45);
            textBoxResult.TabIndex = 1;
            textBoxResult.Text = "0";
            textBoxResult.TextAlign = HorizontalAlignment.Right;
            // 
            // btnCE
            // 
            btnCE.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnCE.Location = new Point(81, 64);
            btnCE.Name = "btnCE";
            btnCE.Size = new Size(60, 55);
            btnCE.TabIndex = 2;
            btnCE.Text = "CE";
            btnCE.UseVisualStyleBackColor = true;
            btnCE.Click += btnCE_Click;
            // 
            // btnC
            // 
            btnC.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnC.Location = new Point(147, 64);
            btnC.Name = "btnC";
            btnC.Size = new Size(60, 55);
            btnC.TabIndex = 3;
            btnC.Text = "C";
            btnC.UseVisualStyleBackColor = true;
            btnC.Click += btnC_Click;
            // 
            // btnMod
            // 
            btnMod.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnMod.Location = new Point(213, 64);
            btnMod.Name = "btnMod";
            btnMod.Size = new Size(60, 55);
            btnMod.TabIndex = 4;
            btnMod.Text = "Mod";
            btnMod.UseVisualStyleBackColor = true;
            btnMod.Click += operator_Click;
            // 
            // btn7
            // 
            btn7.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn7.Location = new Point(15, 125);
            btn7.Name = "btn7";
            btn7.Size = new Size(60, 55);
            btn7.TabIndex = 5;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += button_Click;
            // 
            // btn8
            // 
            btn8.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn8.Location = new Point(81, 125);
            btn8.Name = "btn8";
            btn8.Size = new Size(60, 55);
            btn8.TabIndex = 6;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += button_Click;
            // 
            // btn9
            // 
            btn9.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn9.Location = new Point(147, 125);
            btn9.Name = "btn9";
            btn9.Size = new Size(60, 55);
            btn9.TabIndex = 7;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += button_Click;
            // 
            // btnMultiplication
            // 
            btnMultiplication.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnMultiplication.Location = new Point(213, 125);
            btnMultiplication.Name = "btnMultiplication";
            btnMultiplication.Size = new Size(60, 55);
            btnMultiplication.TabIndex = 8;
            btnMultiplication.Text = "*";
            btnMultiplication.UseVisualStyleBackColor = true;
            btnMultiplication.Click += operator_Click;
            // 
            // btn4
            // 
            btn4.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn4.Location = new Point(15, 186);
            btn4.Name = "btn4";
            btn4.Size = new Size(60, 55);
            btn4.TabIndex = 9;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += button_Click;
            // 
            // btn1
            // 
            btn1.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn1.Location = new Point(15, 247);
            btn1.Name = "btn1";
            btn1.Size = new Size(60, 55);
            btn1.TabIndex = 10;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += button_Click;
            // 
            // btn0
            // 
            btn0.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn0.Location = new Point(15, 308);
            btn0.Name = "btn0";
            btn0.Size = new Size(60, 55);
            btn0.TabIndex = 11;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += button_Click;
            // 
            // btn5
            // 
            btn5.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn5.Location = new Point(81, 186);
            btn5.Name = "btn5";
            btn5.Size = new Size(60, 55);
            btn5.TabIndex = 12;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += button_Click;
            // 
            // btn6
            // 
            btn6.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn6.Location = new Point(147, 186);
            btn6.Name = "btn6";
            btn6.Size = new Size(60, 55);
            btn6.TabIndex = 13;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += button_Click;
            // 
            // btnMinus
            // 
            btnMinus.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnMinus.Location = new Point(213, 186);
            btnMinus.Name = "btnMinus";
            btnMinus.Size = new Size(60, 55);
            btnMinus.TabIndex = 14;
            btnMinus.Text = "-";
            btnMinus.UseVisualStyleBackColor = true;
            btnMinus.Click += operator_Click;
            // 
            // btn2
            // 
            btn2.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn2.Location = new Point(81, 247);
            btn2.Name = "btn2";
            btn2.Size = new Size(60, 55);
            btn2.TabIndex = 15;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += button_Click;
            // 
            // btn3
            // 
            btn3.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btn3.Location = new Point(147, 247);
            btn3.Name = "btn3";
            btn3.Size = new Size(60, 55);
            btn3.TabIndex = 16;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += button_Click;
            // 
            // btnPlus
            // 
            btnPlus.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnPlus.Location = new Point(213, 247);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(60, 55);
            btnPlus.TabIndex = 17;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += operator_Click;
            // 
            // btnDot
            // 
            btnDot.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDot.Location = new Point(81, 308);
            btnDot.Name = "btnDot";
            btnDot.Size = new Size(60, 55);
            btnDot.TabIndex = 18;
            btnDot.Text = ",";
            btnDot.UseVisualStyleBackColor = true;
            btnDot.Click += button_Click;
            // 
            // btnEquals
            // 
            btnEquals.BackColor = SystemColors.ControlLight;
            btnEquals.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnEquals.Location = new Point(147, 308);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(60, 55);
            btnEquals.TabIndex = 19;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = false;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnDivision
            // 
            btnDivision.Font = new Font("Arial", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 204);
            btnDivision.Location = new Point(213, 308);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(60, 55);
            btnDivision.TabIndex = 20;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += operator_Click;
            // 
            // lblShopOp
            // 
            lblShopOp.AutoSize = true;
            lblShopOp.Location = new Point(24, 23);
            lblShopOp.Name = "lblShopOp";
            lblShopOp.Size = new Size(0, 15);
            lblShopOp.TabIndex = 24;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 369);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(129, 23);
            btnSave.TabIndex = 25;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnRestore
            // 
            btnRestore.Location = new Point(144, 369);
            btnRestore.Name = "btnRestore";
            btnRestore.Size = new Size(129, 23);
            btnRestore.TabIndex = 26;
            btnRestore.Text = "Восстановить";
            btnRestore.UseVisualStyleBackColor = true;
            btnRestore.Click += btnRestore_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(285, 400);
            Controls.Add(btnRestore);
            Controls.Add(btnSave);
            Controls.Add(lblShopOp);
            Controls.Add(btnDivision);
            Controls.Add(btnEquals);
            Controls.Add(btnDot);
            Controls.Add(btnPlus);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btnMinus);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn0);
            Controls.Add(btn1);
            Controls.Add(btn4);
            Controls.Add(btnMultiplication);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnMod);
            Controls.Add(btnC);
            Controls.Add(btnCE);
            Controls.Add(textBoxResult);
            Controls.Add(btnDelete);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnDelete;
        private TextBox textBoxResult;
        private Button btnCE;
        private Button btnC;
        private Button btnMod;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnMultiplication;
        private Button btn4;
        private Button btn1;
        private Button btn0;
        private Button btn5;
        private Button btn6;
        private Button btnMinus;
        private Button btn2;
        private Button btn3;
        private Button btnPlus;
        private Button btnDot;
        private Button btnEquals;
        private Button btnDivision;
        private Label lblShopOp;
        private Button btnSave;
        private Button btnRestore;
    }
}
