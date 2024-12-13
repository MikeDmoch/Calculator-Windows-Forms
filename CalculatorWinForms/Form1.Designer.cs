namespace CalculatorWinForms
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
            Screen = new TextBox();
            buttonBackspace = new Button();
            buttonCE = new Button();
            buttonC = new Button();
            buttonNine = new Button();
            buttonEight = new Button();
            buttonSeven = new Button();
            buttonSix = new Button();
            buttonFive = new Button();
            buttonFour = new Button();
            buttonThree = new Button();
            buttonTwo = new Button();
            buttonOne = new Button();
            buttonComma = new Button();
            buttonZero = new Button();
            button15 = new Button();
            buttonAdd = new Button();
            buttonSubstract = new Button();
            buttonMultiply = new Button();
            buttonDevide = new Button();
            buttonSign = new Button();
            buttonEquals = new Button();
            SuspendLayout();
            // 
            // Screen
            // 
            Screen.Font = new Font("Segoe UI Emoji", 20F);
            Screen.Location = new Point(10, 10);
            Screen.MaxLength = 14;
            Screen.Multiline = true;
            Screen.Name = "Screen";
            Screen.ReadOnly = true;
            Screen.RightToLeft = RightToLeft.No;
            Screen.Size = new Size(280, 65);
            Screen.TabIndex = 0;
            Screen.TextAlign = HorizontalAlignment.Right;
            Screen.TextChanged += Screen_TextChanged;
            // 
            // buttonBackspace
            // 
            buttonBackspace.Location = new Point(10, 369);
            buttonBackspace.Name = "buttonBackspace";
            buttonBackspace.Size = new Size(65, 65);
            buttonBackspace.TabIndex = 1;
            buttonBackspace.Text = "⌫";
            buttonBackspace.UseVisualStyleBackColor = true;
            buttonBackspace.Click += buttonBackspace_Click;
            // 
            // buttonCE
            // 
            buttonCE.Location = new Point(10, 85);
            buttonCE.Name = "buttonCE";
            buttonCE.Size = new Size(65, 65);
            buttonCE.TabIndex = 2;
            buttonCE.Text = "CE";
            buttonCE.UseVisualStyleBackColor = true;
            buttonCE.Click += buttonCE_Click_1;
            // 
            // buttonC
            // 
            buttonC.Location = new Point(81, 85);
            buttonC.Name = "buttonC";
            buttonC.Size = new Size(65, 65);
            buttonC.TabIndex = 3;
            buttonC.Text = "C";
            buttonC.UseVisualStyleBackColor = true;
            buttonC.Click += buttonC_Click;
            // 
            // buttonNine
            // 
            buttonNine.Location = new Point(154, 156);
            buttonNine.Name = "buttonNine";
            buttonNine.Size = new Size(65, 65);
            buttonNine.TabIndex = 6;
            buttonNine.Text = "9";
            buttonNine.UseVisualStyleBackColor = true;
            buttonNine.Click += buttonNine_Click;
            // 
            // buttonEight
            // 
            buttonEight.Location = new Point(81, 156);
            buttonEight.Name = "buttonEight";
            buttonEight.Size = new Size(65, 65);
            buttonEight.TabIndex = 5;
            buttonEight.Text = "8";
            buttonEight.UseVisualStyleBackColor = true;
            buttonEight.Click += buttonEight_Click;
            // 
            // buttonSeven
            // 
            buttonSeven.Location = new Point(10, 156);
            buttonSeven.Name = "buttonSeven";
            buttonSeven.Size = new Size(65, 65);
            buttonSeven.TabIndex = 4;
            buttonSeven.Text = "7";
            buttonSeven.UseVisualStyleBackColor = true;
            buttonSeven.Click += buttonSeven_Click;
            // 
            // buttonSix
            // 
            buttonSix.Location = new Point(154, 227);
            buttonSix.Name = "buttonSix";
            buttonSix.Size = new Size(65, 65);
            buttonSix.TabIndex = 9;
            buttonSix.Text = "6";
            buttonSix.UseVisualStyleBackColor = true;
            buttonSix.Click += buttonSix_Click;
            // 
            // buttonFive
            // 
            buttonFive.Location = new Point(81, 227);
            buttonFive.Name = "buttonFive";
            buttonFive.Size = new Size(65, 65);
            buttonFive.TabIndex = 8;
            buttonFive.Text = "5";
            buttonFive.UseVisualStyleBackColor = true;
            buttonFive.Click += buttonFive_Click;
            // 
            // buttonFour
            // 
            buttonFour.Location = new Point(10, 227);
            buttonFour.Name = "buttonFour";
            buttonFour.Size = new Size(65, 65);
            buttonFour.TabIndex = 7;
            buttonFour.Text = "4";
            buttonFour.UseVisualStyleBackColor = true;
            buttonFour.Click += buttonFour_Click;
            // 
            // buttonThree
            // 
            buttonThree.Location = new Point(154, 298);
            buttonThree.Name = "buttonThree";
            buttonThree.Size = new Size(65, 65);
            buttonThree.TabIndex = 12;
            buttonThree.Text = "3";
            buttonThree.UseVisualStyleBackColor = true;
            buttonThree.Click += buttonThree_Click;
            // 
            // buttonTwo
            // 
            buttonTwo.Location = new Point(81, 298);
            buttonTwo.Name = "buttonTwo";
            buttonTwo.Size = new Size(65, 65);
            buttonTwo.TabIndex = 11;
            buttonTwo.Text = "2";
            buttonTwo.UseVisualStyleBackColor = true;
            buttonTwo.Click += buttonTwo_Click;
            // 
            // buttonOne
            // 
            buttonOne.Location = new Point(10, 298);
            buttonOne.Name = "buttonOne";
            buttonOne.Size = new Size(65, 65);
            buttonOne.TabIndex = 10;
            buttonOne.Text = "1";
            buttonOne.UseVisualStyleBackColor = true;
            buttonOne.Click += buttonOne_Click;
            // 
            // buttonComma
            // 
            buttonComma.Location = new Point(154, 369);
            buttonComma.Name = "buttonComma";
            buttonComma.Size = new Size(65, 65);
            buttonComma.TabIndex = 15;
            buttonComma.Text = ",";
            buttonComma.UseVisualStyleBackColor = true;
            buttonComma.Click += buttonComma_Click;
            // 
            // buttonZero
            // 
            buttonZero.Location = new Point(81, 369);
            buttonZero.Name = "buttonZero";
            buttonZero.Size = new Size(65, 65);
            buttonZero.TabIndex = 14;
            buttonZero.Text = "0";
            buttonZero.UseVisualStyleBackColor = true;
            buttonZero.Click += buttonZero_Click;
            // 
            // button15
            // 
            button15.Location = new Point(154, 85);
            button15.Name = "button15";
            button15.Size = new Size(65, 65);
            button15.TabIndex = 13;
            button15.Text = "mod";
            button15.UseVisualStyleBackColor = true;
            button15.Click += button15_Click;
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(225, 369);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(65, 65);
            buttonAdd.TabIndex = 20;
            buttonAdd.Text = "+";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonSubstract
            // 
            buttonSubstract.Location = new Point(225, 298);
            buttonSubstract.Name = "buttonSubstract";
            buttonSubstract.Size = new Size(65, 65);
            buttonSubstract.TabIndex = 19;
            buttonSubstract.Text = "-";
            buttonSubstract.UseVisualStyleBackColor = true;
            buttonSubstract.Click += buttonSubstract_Click;
            // 
            // buttonMultiply
            // 
            buttonMultiply.Location = new Point(225, 227);
            buttonMultiply.Name = "buttonMultiply";
            buttonMultiply.Size = new Size(65, 65);
            buttonMultiply.TabIndex = 18;
            buttonMultiply.Text = "*";
            buttonMultiply.UseVisualStyleBackColor = true;
            buttonMultiply.Click += buttonMultiply_Click;
            // 
            // buttonDevide
            // 
            buttonDevide.Location = new Point(225, 156);
            buttonDevide.Name = "buttonDevide";
            buttonDevide.Size = new Size(65, 65);
            buttonDevide.TabIndex = 17;
            buttonDevide.Text = "/";
            buttonDevide.UseVisualStyleBackColor = true;
            buttonDevide.Click += buttonDevide_Click;
            // 
            // buttonSign
            // 
            buttonSign.Location = new Point(225, 85);
            buttonSign.Name = "buttonSign";
            buttonSign.Size = new Size(65, 65);
            buttonSign.TabIndex = 16;
            buttonSign.Text = "±";
            buttonSign.UseVisualStyleBackColor = true;
            buttonSign.Click += buttonSign_Click;
            // 
            // buttonEquals
            // 
            buttonEquals.Location = new Point(10, 440);
            buttonEquals.Name = "buttonEquals";
            buttonEquals.Size = new Size(280, 65);
            buttonEquals.TabIndex = 21;
            buttonEquals.Text = "=";
            buttonEquals.UseVisualStyleBackColor = true;
            buttonEquals.Click += buttonEquals_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 512);
            Controls.Add(buttonEquals);
            Controls.Add(buttonAdd);
            Controls.Add(buttonSubstract);
            Controls.Add(buttonMultiply);
            Controls.Add(buttonDevide);
            Controls.Add(buttonSign);
            Controls.Add(buttonComma);
            Controls.Add(buttonZero);
            Controls.Add(button15);
            Controls.Add(buttonThree);
            Controls.Add(buttonTwo);
            Controls.Add(buttonOne);
            Controls.Add(buttonSix);
            Controls.Add(buttonFive);
            Controls.Add(buttonFour);
            Controls.Add(buttonNine);
            Controls.Add(buttonEight);
            Controls.Add(buttonSeven);
            Controls.Add(buttonC);
            Controls.Add(buttonCE);
            Controls.Add(buttonBackspace);
            Controls.Add(Screen);
            Name = "Form1";
            Text = "Calc";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox Screen;
        private Button buttonBackspace;
        private Button buttonCE;
        private Button buttonC;
        private Button buttonNine;
        private Button buttonEight;
        private Button buttonSeven;
        private Button buttonSix;
        private Button buttonFive;
        private Button buttonFour;
        private Button buttonThree;
        private Button buttonTwo;
        private Button buttonOne;
        private Button buttonComma;
        private Button buttonZero;
        private Button button15;
        private Button buttonAdd;
        private Button buttonSubstract;
        private Button buttonMultiply;
        private Button buttonDevide;
        private Button buttonSign;
        private Button buttonEquals;
    }
}
