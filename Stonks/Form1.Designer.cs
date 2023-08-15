namespace Stonks
{
    partial class Home
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
            label1 = new Label();
            searchbox = new TextBox();
            credit = new Label();
            errmsg = new Label();
            datalabel = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            flowLayoutPanel2 = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            homelabel = new Label();
            reccomp = new Button();
            button1 = new Button();
            newexitbtn = new Button();
            newsearchbtn = new Button();
            minimize = new Button();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 26.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(436, 6);
            label1.Name = "label1";
            label1.Size = new Size(152, 42);
            label1.TabIndex = 2;
            label1.Text = "Stonks";
            // 
            // searchbox
            // 
            searchbox.Location = new Point(424, 79);
            searchbox.Name = "searchbox";
            searchbox.PlaceholderText = "     Enter Company Name";
            searchbox.Size = new Size(173, 23);
            searchbox.TabIndex = 4;
            // 
            // credit
            // 
            credit.AutoSize = true;
            credit.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point);
            credit.Location = new Point(589, 427);
            credit.Name = "credit";
            credit.Size = new Size(198, 14);
            credit.TabIndex = 8;
            credit.Text = "Created by Ben (PCP PUSHER)";
            // 
            // errmsg
            // 
            errmsg.AutoSize = true;
            errmsg.Location = new Point(395, 66);
            errmsg.Name = "errmsg";
            errmsg.Size = new Size(0, 15);
            errmsg.TabIndex = 9;
            // 
            // datalabel
            // 
            datalabel.AutoSize = true;
            datalabel.Location = new Point(268, 149);
            datalabel.Name = "datalabel";
            datalabel.Size = new Size(0, 15);
            datalabel.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = Color.LightCoral;
            flowLayoutPanel1.Controls.Add(flowLayoutPanel2);
            flowLayoutPanel1.Controls.Add(reccomp);
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(250, 452);
            flowLayoutPanel1.TabIndex = 12;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(pictureBox1);
            flowLayoutPanel2.Controls.Add(homelabel);
            flowLayoutPanel2.Location = new Point(3, 3);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(243, 70);
            flowLayoutPanel2.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.home;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(69, 62);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // homelabel
            // 
            homelabel.Font = new Font("Malgun Gothic", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            homelabel.ForeColor = SystemColors.ControlLightLight;
            homelabel.Location = new Point(78, 0);
            homelabel.Name = "homelabel";
            homelabel.Size = new Size(131, 65);
            homelabel.TabIndex = 18;
            homelabel.Text = "Home";
            homelabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // reccomp
            // 
            reccomp.BackColor = Color.RosyBrown;
            reccomp.BackgroundImageLayout = ImageLayout.None;
            reccomp.FlatStyle = FlatStyle.Flat;
            reccomp.Font = new Font("Lucida Console", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            reccomp.ForeColor = Color.Snow;
            reccomp.Location = new Point(3, 79);
            reccomp.Name = "reccomp";
            reccomp.Size = new Size(243, 34);
            reccomp.TabIndex = 1;
            reccomp.Text = "Recommended Companies";
            reccomp.UseVisualStyleBackColor = false;
            reccomp.Click += reccommended_OnClick;
            // 
            // button1
            // 
            button1.BackColor = Color.RosyBrown;
            button1.BackgroundImageLayout = ImageLayout.None;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Lucida Console", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Snow;
            button1.Location = new Point(3, 119);
            button1.Name = "button1";
            button1.Size = new Size(243, 34);
            button1.TabIndex = 3;
            button1.Text = "Top Companies";
            button1.UseVisualStyleBackColor = false;
            // 
            // newexitbtn
            // 
            newexitbtn.BackgroundImageLayout = ImageLayout.None;
            newexitbtn.FlatAppearance.BorderSize = 0;
            newexitbtn.FlatStyle = FlatStyle.Flat;
            newexitbtn.Image = Properties.Resources.exit2;
            newexitbtn.Location = new Point(771, 0);
            newexitbtn.Name = "newexitbtn";
            newexitbtn.Size = new Size(30, 20);
            newexitbtn.TabIndex = 15;
            newexitbtn.UseVisualStyleBackColor = true;
            newexitbtn.Click += exitbtn_Click;
            newexitbtn.MouseEnter += onHoverEnter_Exitbtn;
            newexitbtn.MouseLeave += onHoverExit_Exitbtn;
            // 
            // newsearchbtn
            // 
            newsearchbtn.FlatAppearance.BorderSize = 0;
            newsearchbtn.FlatStyle = FlatStyle.Flat;
            newsearchbtn.Image = Properties.Resources.search4;
            newsearchbtn.Location = new Point(607, 73);
            newsearchbtn.Name = "newsearchbtn";
            newsearchbtn.Size = new Size(30, 33);
            newsearchbtn.TabIndex = 16;
            newsearchbtn.UseVisualStyleBackColor = true;
            newsearchbtn.Click += searchbtn_Click;
            // 
            // minimize
            // 
            minimize.FlatAppearance.BorderSize = 0;
            minimize.FlatStyle = FlatStyle.Flat;
            minimize.Image = Properties.Resources.minimize6;
            minimize.Location = new Point(744, 0);
            minimize.Name = "minimize";
            minimize.Size = new Size(30, 20);
            minimize.TabIndex = 17;
            minimize.UseVisualStyleBackColor = true;
            minimize.Click += onMinimize;
            // 
            // Home
            // 
            AccessibleRole = AccessibleRole.None;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(minimize);
            Controls.Add(newsearchbtn);
            Controls.Add(newexitbtn);
            Controls.Add(credit);
            Controls.Add(label1);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(datalabel);
            Controls.Add(errmsg);
            Controls.Add(searchbox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Home";
            StartPosition = FormStartPosition.CenterScreen;
            Text = " ";
            Load += Form1_Load;
            MouseDown += moveApplication;
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private TextBox searchbox;
        private Label label3;
        private Label credit;
        private Label errmsg;
        public Label datalabel;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button newexitbtn;
        private Button newsearchbtn;
        private Button minimize;
        private Button reccomp;
        private FlowLayoutPanel flowLayoutPanel2;
        private PictureBox pictureBox1;
        private Label homelabel;
        private Button button1;
    }
}