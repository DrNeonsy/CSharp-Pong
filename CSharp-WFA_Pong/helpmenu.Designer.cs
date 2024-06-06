namespace CSharp_WFA_Pong
{
    partial class helpmenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(helpmenu));
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Rounded MT Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(974, 340);
            label1.TabIndex = 0;
            label1.Text = resources.GetString("label1.Text");
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveBorder;
            button1.Location = new Point(33, 377);
            button1.Name = "button1";
            button1.Size = new Size(91, 43);
            button1.TabIndex = 1;
            button1.Text = "BACK";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // helpmenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1132, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Name = "helpmenu";
            Text = "helpmenu";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button1;
    }
}