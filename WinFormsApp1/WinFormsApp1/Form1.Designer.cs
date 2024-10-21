namespace WinFormsApp1
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
            label5 = new Label();
            addtxbx = new TextBox();
            label4 = new Label();
            emailtxbx = new TextBox();
            label3 = new Label();
            usertxbx = new TextBox();
            label2 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(174, 85);
            label5.Name = "label5";
            label5.Size = new Size(143, 40);
            label5.TabIndex = 24;
            label5.Text = "Add User";
            // 
            // addtxbx
            // 
            addtxbx.Location = new Point(192, 200);
            addtxbx.Name = "addtxbx";
            addtxbx.Size = new Size(195, 23);
            addtxbx.TabIndex = 22;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(117, 203);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 21;
            label4.Text = "Address:";
            // 
            // emailtxbx
            // 
            emailtxbx.Location = new Point(192, 170);
            emailtxbx.Name = "emailtxbx";
            emailtxbx.Size = new Size(195, 23);
            emailtxbx.TabIndex = 20;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(133, 173);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 19;
            label3.Text = "Email:";
            // 
            // usertxbx
            // 
            usertxbx.Location = new Point(192, 140);
            usertxbx.Name = "usertxbx";
            usertxbx.Size = new Size(195, 23);
            usertxbx.TabIndex = 18;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(104, 143);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.TabIndex = 17;
            label2.Text = "Username:";
            // 
            // button1
            // 
            button1.Location = new Point(169, 238);
            button1.Name = "button1";
            button1.Size = new Size(106, 23);
            button1.TabIndex = 25;
            button1.Text = "Add User";
            button1.UseVisualStyleBackColor = true;
            button1.Click += submit_Click;
            // 
            // button2
            // 
            button2.Location = new Point(281, 238);
            button2.Name = "button2";
            button2.Size = new Size(106, 23);
            button2.TabIndex = 26;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(491, 347);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(addtxbx);
            Controls.Add(label4);
            Controls.Add(emailtxbx);
            Controls.Add(label3);
            Controls.Add(usertxbx);
            Controls.Add(label2);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label5;
        private TextBox addtxbx;
        private Label label4;
        private TextBox emailtxbx;
        private Label label3;
        private TextBox usertxbx;
        private Label label2;
        private Button button1;
        private Button button2;
    }
}
