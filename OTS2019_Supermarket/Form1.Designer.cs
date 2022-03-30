namespace OTS_Supermarket
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
            this.lblAdd = new System.Windows.Forms.Label();
            this.gboxButtons = new System.Windows.Forms.GroupBox();
            this.btnComputer = new System.Windows.Forms.Button();
            this.btnLaptop = new System.Windows.Forms.Button();
            this.btnMonitor = new System.Windows.Forms.Button();
            this.btnKeyboard = new System.Windows.Forms.Button();
            this.btnChair = new System.Windows.Forms.Button();
            this.gboxActions = new System.Windows.Forms.GroupBox();
            this.tbxDate = new System.Windows.Forms.TextBox();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            rtbOutput = new System.Windows.Forms.RichTextBox();
            this.tbxBudget = new System.Windows.Forms.TextBox();
            this.lblBudget = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.gboxButtons.SuspendLayout();
            this.gboxActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(15, 102);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(60, 13);
            this.lblAdd.TabIndex = 0;
            this.lblAdd.Text = "Add to Cart";
            // 
            // gboxButtons
            // 
            this.gboxButtons.Controls.Add(this.btnComputer);
            this.gboxButtons.Controls.Add(this.btnLaptop);
            this.gboxButtons.Controls.Add(this.btnChair);
            this.gboxButtons.Controls.Add(this.btnMonitor);
            this.gboxButtons.Controls.Add(this.btnKeyboard);
            this.gboxButtons.Location = new System.Drawing.Point(12, 118);
            this.gboxButtons.Name = "gboxButtons";
            this.gboxButtons.Size = new System.Drawing.Size(102, 274);
            this.gboxButtons.TabIndex = 1;
            this.gboxButtons.TabStop = false;
            this.gboxButtons.Text = "Items:";
            // 
            // btnComputer
            // 
            this.btnComputer.Location = new System.Drawing.Point(6, 122);
            this.btnComputer.Name = "btnComputer";
            this.btnComputer.Size = new System.Drawing.Size(75, 40);
            this.btnComputer.TabIndex = 3;
            this.btnComputer.Text = "Computer";
            this.btnComputer.UseVisualStyleBackColor = true;
            this.btnComputer.Click += new System.EventHandler(this.btnComputer_Click);
            // 
            // btnLaptop
            // 
            this.btnLaptop.Location = new System.Drawing.Point(6, 168);
            this.btnLaptop.Name = "btnLaptop";
            this.btnLaptop.Size = new System.Drawing.Size(75, 40);
            this.btnLaptop.TabIndex = 2;
            this.btnLaptop.Text = "Lap top";
            this.btnLaptop.UseVisualStyleBackColor = true;
            this.btnLaptop.Click += new System.EventHandler(this.btnLaptop_Click);
            // 
            // btnMonitor
            // 
            this.btnMonitor.Location = new System.Drawing.Point(6, 30);
            this.btnMonitor.Name = "btnMonitor";
            this.btnMonitor.Size = new System.Drawing.Size(75, 40);
            this.btnMonitor.TabIndex = 1;
            this.btnMonitor.Text = "Monitor";
            this.btnMonitor.UseVisualStyleBackColor = true;
            this.btnMonitor.Click += new System.EventHandler(this.btnMonitor_Click);
            // 
            // btnKeyboard
            // 
            this.btnKeyboard.Location = new System.Drawing.Point(6, 76);
            this.btnKeyboard.Name = "btnKeyboard";
            this.btnKeyboard.Size = new System.Drawing.Size(75, 40);
            this.btnKeyboard.TabIndex = 0;
            this.btnKeyboard.Text = "Keyboard";
            this.btnKeyboard.UseVisualStyleBackColor = true;
            this.btnKeyboard.Click += new System.EventHandler(this.btnKeyboard_Click);
            // 
            // btnChair
            // 
            this.btnChair.Location = new System.Drawing.Point(6, 214);
            this.btnChair.Name = "btnChair";
            this.btnChair.Size = new System.Drawing.Size(75, 40);
            this.btnChair.TabIndex = 4;
            this.btnChair.Text = "Computer chair";
            this.btnChair.UseVisualStyleBackColor = true;
            this.btnChair.Click += new System.EventHandler(this.btnChair_Click);
            // 
            // gboxActions
            // 
            this.gboxActions.Controls.Add(this.tbxDate);
            this.gboxActions.Controls.Add(this.lblDelivery);
            this.gboxActions.Controls.Add(this.btnCalculate);
            this.gboxActions.Controls.Add(this.btnPrint);
            this.gboxActions.Controls.Add(this.btnRestore);
            this.gboxActions.Location = new System.Drawing.Point(149, 118);
            this.gboxActions.Name = "gboxActions";
            this.gboxActions.Size = new System.Drawing.Size(250, 128);
            this.gboxActions.TabIndex = 5;
            this.gboxActions.TabStop = false;
            this.gboxActions.Text = "Actions:";
            // 
            // tbxDate
            // 
            this.tbxDate.Location = new System.Drawing.Point(6, 102);
            this.tbxDate.Name = "tbxDate";
            this.tbxDate.Size = new System.Drawing.Size(222, 20);
            this.tbxDate.TabIndex = 7;
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Location = new System.Drawing.Point(6, 77);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.Size = new System.Drawing.Size(112, 13);
            this.lblDelivery.TabIndex = 6;
            this.lblDelivery.Text = "Pick date for  delivery ";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(6, 19);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(70, 40);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate price";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(82, 19);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(70, 40);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "Print items";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(158, 19);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(70, 40);
            this.btnRestore.TabIndex = 2;
            this.btnRestore.Text = "Restore cart";
            this.btnRestore.UseVisualStyleBackColor = true;
            // 
            // rtbOutput
            // 
            rtbOutput.Location = new System.Drawing.Point(133, 252);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.Size = new System.Drawing.Size(266, 140);
            rtbOutput.TabIndex = 6;
            rtbOutput.Text = "";
            // 
            // tbxBudget
            // 
            this.tbxBudget.Location = new System.Drawing.Point(18, 53);
            this.tbxBudget.Name = "tbxBudget";
            this.tbxBudget.Size = new System.Drawing.Size(249, 20);
            this.tbxBudget.TabIndex = 7;
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Location = new System.Drawing.Point(18, 34);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(134, 13);
            this.lblBudget.TabIndex = 8;
            this.lblBudget.Text = "Enter your shoping budget:";
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(288, 51);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 9;
            this.btnEnter.Text = "Enter";
            this.btnEnter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 404);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.lblBudget);
            this.Controls.Add(this.tbxBudget);
            this.Controls.Add(rtbOutput);
            this.Controls.Add(this.gboxActions);
            this.Controls.Add(this.gboxButtons);
            this.Controls.Add(this.lblAdd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gboxButtons.ResumeLayout(false);
            this.gboxActions.ResumeLayout(false);
            this.gboxActions.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.GroupBox gboxButtons;
        private System.Windows.Forms.Button btnChair;
        private System.Windows.Forms.Button btnComputer;
        private System.Windows.Forms.Button btnLaptop;
        private System.Windows.Forms.Button btnMonitor;
        private System.Windows.Forms.Button btnKeyboard;
        private System.Windows.Forms.GroupBox gboxActions;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Label lblDelivery;
        private System.Windows.Forms.TextBox tbxDate;
        private System.Windows.Forms.TextBox tbxBudget;
        private System.Windows.Forms.Label lblBudget;
        public static System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.Button btnEnter;
    }
}

