
namespace demoRPN
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGan = new System.Windows.Forms.Button();
            this.lblPRN = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnEqual = new System.Windows.Forms.Button();
            this.listView2 = new System.Windows.Forms.ListView();
            this.Bien = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.GiaTri = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtInfixExpression = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(178, 115);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(724, 602);
            this.listView1.TabIndex = 39;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Token";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "OpS";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "NodeS";
            // 
            // btnGan
            // 
            this.btnGan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGan.Location = new System.Drawing.Point(848, 7);
            this.btnGan.Margin = new System.Windows.Forms.Padding(4);
            this.btnGan.Name = "btnGan";
            this.btnGan.Size = new System.Drawing.Size(59, 25);
            this.btnGan.TabIndex = 37;
            this.btnGan.Text = "Gán";
            this.btnGan.UseVisualStyleBackColor = true;
            this.btnGan.Click += new System.EventHandler(this.btnGan_Click);
            // 
            // lblPRN
            // 
            this.lblPRN.AutoSize = true;
            this.lblPRN.Location = new System.Drawing.Point(175, 84);
            this.lblPRN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPRN.Name = "lblPRN";
            this.lblPRN.Size = new System.Drawing.Size(16, 17);
            this.lblPRN.TabIndex = 36;
            this.lblPRN.Text = "_";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(175, 57);
            this.lblResult.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(16, 17);
            this.lblResult.TabIndex = 35;
            this.lblResult.Text = "_";
            // 
            // btnEqual
            // 
            this.btnEqual.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEqual.Location = new System.Drawing.Point(848, 40);
            this.btnEqual.Margin = new System.Windows.Forms.Padding(4);
            this.btnEqual.Name = "btnEqual";
            this.btnEqual.Size = new System.Drawing.Size(59, 25);
            this.btnEqual.TabIndex = 34;
            this.btnEqual.Text = "=";
            this.btnEqual.UseVisualStyleBackColor = true;
            this.btnEqual.Click += new System.EventHandler(this.btnEqual_Click);
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Bien,
            this.GiaTri});
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(8, 7);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(160, 710);
            this.listView2.TabIndex = 38;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            // 
            // Bien
            // 
            this.Bien.Text = "Biến";
            // 
            // GiaTri
            // 
            this.GiaTri.Text = "Giá Trị";
            this.GiaTri.Width = 100;
            // 
            // txtInfixExpression
            // 
            this.txtInfixExpression.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtInfixExpression.Location = new System.Drawing.Point(178, 7);
            this.txtInfixExpression.Margin = new System.Windows.Forms.Padding(4);
            this.txtInfixExpression.Multiline = true;
            this.txtInfixExpression.Name = "txtInfixExpression";
            this.txtInfixExpression.Size = new System.Drawing.Size(665, 46);
            this.txtInfixExpression.TabIndex = 33;
            // 
            // btnReset
            // 
            this.btnReset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReset.Location = new System.Drawing.Point(848, 73);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(59, 25);
            this.btnReset.TabIndex = 40;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 725);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnGan);
            this.Controls.Add(this.lblPRN);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnEqual);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.txtInfixExpression);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Button btnGan;
        private System.Windows.Forms.Label lblPRN;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnEqual;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader Bien;
        private System.Windows.Forms.ColumnHeader GiaTri;
        private System.Windows.Forms.TextBox txtInfixExpression;
        private System.Windows.Forms.Button btnReset;
    }
}