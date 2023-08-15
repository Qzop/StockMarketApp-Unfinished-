namespace Stonks
{
    partial class Recommended
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
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            reccomp = new Button();
            button1 = new Button();
            datalabel = new Label();
            minimize = new Button();
            newexitbtn = new Button();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 21.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(300, 24);
            label1.Name = "label1";
            label1.Size = new Size(443, 35);
            label1.TabIndex = 0;
            label1.Text = "Recommended Companies";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.LightCoral;
            flowLayoutPanel1.Controls.Add(reccomp);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 450);
            flowLayoutPanel1.TabIndex = 14;
            // 
            // reccomp
            // 
            reccomp.BackColor = Color.RosyBrown;
            reccomp.BackgroundImageLayout = ImageLayout.None;
            reccomp.FlatStyle = FlatStyle.Flat;
            reccomp.Font = new Font("Lucida Console", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            reccomp.ForeColor = Color.Snow;
            reccomp.Location = new Point(3, 3);
            reccomp.Name = "reccomp";
            reccomp.Size = new Size(243, 34);
            reccomp.TabIndex = 1;
            reccomp.Text = "Home";
            reccomp.UseVisualStyleBackColor = false;
            reccomp.Click += homebtn_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lucida Console", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(3, 43);
            button1.Name = "button1";
            button1.Size = new Size(243, 34);
            button1.TabIndex = 3;
            button1.Text = "Top Companies";
            button1.UseVisualStyleBackColor = false;
            // 
            // datalabel
            // 
            datalabel.AutoSize = true;
            datalabel.Location = new Point(268, 149);
            datalabel.Name = "datalabel";
            datalabel.Size = new Size(0, 15);
            datalabel.TabIndex = 13;
            // 
            // minimize
            // 
            minimize.FlatAppearance.BorderSize = 0;
            minimize.FlatStyle = FlatStyle.Flat;
            minimize.Image = Properties.Resources.minimize6;
            minimize.Location = new Point(745, 0);
            minimize.Name = "minimize";
            minimize.Size = new Size(30, 20);
            minimize.TabIndex = 19;
            minimize.UseVisualStyleBackColor = true;
            minimize.Click += onMinimize;
            // 
            // newexitbtn
            // 
            newexitbtn.BackgroundImageLayout = ImageLayout.None;
            newexitbtn.FlatAppearance.BorderSize = 0;
            newexitbtn.FlatStyle = FlatStyle.Flat;
            newexitbtn.Image = Properties.Resources.exit2;
            newexitbtn.Location = new Point(772, 0);
            newexitbtn.Name = "newexitbtn";
            newexitbtn.Size = new Size(30, 20);
            newexitbtn.TabIndex = 18;
            newexitbtn.UseVisualStyleBackColor = true;
            newexitbtn.Click += exitbtn_Click;
            newexitbtn.MouseEnter += onHoverEnter_Exitbtn;
            newexitbtn.MouseLeave += onHoverExit_Exitbtn;
            // 
            // Recommended
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(minimize);
            Controls.Add(newexitbtn);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(datalabel);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Recommended";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Stonks";
            MouseDown += moveApplication;
            flowLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Label homelabel;
        private Button reccomp;
        private Button button1;
        public Label datalabel;
        private Button minimize;
        private Button newexitbtn;
    }
}