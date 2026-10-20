namespace Tugas_pak_okta_lagi.Views
{
    partial class PetView
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
            panel1 = new Panel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            label7 = new Label();
            txtSearch = new TextBox();
            btnSearch = new Button();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            tabPagePetDetail = new TabPage();
            txtPetName = new TextBox();
            txtPetId = new TextBox();
            button2 = new Button();
            button1 = new Button();
            txtPetColour = new TextBox();
            label6 = new Label();
            txtPetType = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            panel1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tabPagePetDetail.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold);
            label1.Location = new Point(76, 14);
            label1.Name = "label1";
            label1.Size = new Size(56, 28);
            label1.TabIndex = 0;
            label1.Text = "PETS";
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 57);
            panel1.TabIndex = 1;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPagePetDetail);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 57);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 393);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(label7);
            tabPage1.Controls.Add(txtSearch);
            tabPage1.Controls.Add(btnSearch);
            tabPage1.Controls.Add(button5);
            tabPage1.Controls.Add(button4);
            tabPage1.Controls.Add(button3);
            tabPage1.Controls.Add(dataGridView1);
            tabPage1.Controls.Add(label2);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 360);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Pet List";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(26, 27);
            label7.Name = "label7";
            label7.Size = new Size(77, 20);
            label7.TabIndex = 7;
            label7.Text = "Search Pet";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(22, 47);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(553, 27);
            txtSearch.TabIndex = 6;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(581, 46);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 5;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Location = new Point(681, 179);
            button5.Name = "button5";
            button5.Size = new Size(94, 29);
            button5.TabIndex = 4;
            button5.Text = "Delete";
            button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            button4.Location = new Point(681, 132);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 3;
            button4.Text = "Edit";
            button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(681, 86);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 2;
            button3.Text = "Add New";
            button3.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 82);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(653, 275);
            dataGridView1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 59);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 0;
            // 
            // tabPagePetDetail
            // 
            tabPagePetDetail.Controls.Add(txtPetName);
            tabPagePetDetail.Controls.Add(txtPetId);
            tabPagePetDetail.Controls.Add(button2);
            tabPagePetDetail.Controls.Add(button1);
            tabPagePetDetail.Controls.Add(txtPetColour);
            tabPagePetDetail.Controls.Add(label6);
            tabPagePetDetail.Controls.Add(txtPetType);
            tabPagePetDetail.Controls.Add(label5);
            tabPagePetDetail.Controls.Add(label4);
            tabPagePetDetail.Controls.Add(label3);
            tabPagePetDetail.Location = new Point(4, 29);
            tabPagePetDetail.Name = "tabPagePetDetail";
            tabPagePetDetail.Padding = new Padding(3);
            tabPagePetDetail.Size = new Size(792, 360);
            tabPagePetDetail.TabIndex = 1;
            tabPagePetDetail.Text = "Pet Details";
            tabPagePetDetail.UseVisualStyleBackColor = true;
            // 
            // txtPetName
            // 
            txtPetName.Location = new Point(77, 159);
            txtPetName.Name = "txtPetName";
            txtPetName.Size = new Size(125, 27);
            txtPetName.TabIndex = 11;
            // 
            // txtPetId
            // 
            txtPetId.Location = new Point(77, 71);
            txtPetId.Name = "txtPetId";
            txtPetId.Size = new Size(125, 27);
            txtPetId.TabIndex = 10;
            // 
            // button2
            // 
            button2.Location = new Point(258, 271);
            button2.Name = "button2";
            button2.Size = new Size(130, 29);
            button2.TabIndex = 9;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(77, 271);
            button1.Name = "button1";
            button1.Size = new Size(125, 29);
            button1.TabIndex = 8;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // txtPetColour
            // 
            txtPetColour.Location = new Point(77, 238);
            txtPetColour.Name = "txtPetColour";
            txtPetColour.Size = new Size(311, 27);
            txtPetColour.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.Location = new Point(72, 213);
            label6.Name = "label6";
            label6.Size = new Size(94, 23);
            label6.TabIndex = 6;
            label6.Text = "Pet Colour:";
            // 
            // txtPetType
            // 
            txtPetType.Location = new Point(263, 158);
            txtPetType.Name = "txtPetType";
            txtPetType.Size = new Size(125, 27);
            txtPetType.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.Location = new Point(258, 133);
            label5.Name = "label5";
            label5.Size = new Size(78, 23);
            label5.TabIndex = 4;
            label5.Text = "Pet Type:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.Location = new Point(72, 133);
            label4.Name = "label4";
            label4.Size = new Size(89, 23);
            label4.TabIndex = 2;
            label4.Text = "Pet Name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.Location = new Point(72, 45);
            label3.Name = "label3";
            label3.Size = new Size(60, 23);
            label3.TabIndex = 0;
            label3.Text = "Pet ID:";
            // 
            // PetView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Controls.Add(panel1);
            Name = "PetView";
            Text = "PetView";
            Load += PetView_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tabPagePetDetail.ResumeLayout(false);
            tabPagePetDetail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPagePetDetail;
        private Label label2;
        private TextBox txtPetType;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button2;
        private Button button1;
        private TextBox txtPetColour;
        private Label label6;
        private TextBox txtSearch;
        private Button btnSearch;
        private Button button5;
        private Button button4;
        private Button button3;
        private DataGridView dataGridView1;
        private Label label7;
        private TextBox txtPetId;
        private TextBox txtPetName;
    }
}