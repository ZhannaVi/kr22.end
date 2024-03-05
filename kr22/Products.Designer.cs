
namespace kr22
{
    partial class Products
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnhome2 = new System.Windows.Forms.Button();
            this.btncheck = new System.Windows.Forms.Button();
            this.prod_table = new System.Windows.Forms.DataGridView();
            this.exp_btn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prod_table)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(556, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sims4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Font = new System.Drawing.Font("Parchment", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(557, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 39);
            this.label2.TabIndex = 1;
            this.label2.Text = "LeageOfLegends";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tw Cen MT Condensed Extra Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(557, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 44);
            this.label3.TabIndex = 1;
            this.label3.Text = "WorldOfThanks";
            // 
            // btnhome2
            // 
            this.btnhome2.Font = new System.Drawing.Font("Mistral", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnhome2.Location = new System.Drawing.Point(555, 88);
            this.btnhome2.Margin = new System.Windows.Forms.Padding(2);
            this.btnhome2.Name = "btnhome2";
            this.btnhome2.Size = new System.Drawing.Size(169, 27);
            this.btnhome2.TabIndex = 2;
            this.btnhome2.Text = "посмотрели и хватит";
            this.btnhome2.UseVisualStyleBackColor = true;
            this.btnhome2.Click += new System.EventHandler(this.btnhome2_Click);
            // 
            // btncheck
            // 
            this.btncheck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btncheck.Location = new System.Drawing.Point(555, 12);
            this.btncheck.Margin = new System.Windows.Forms.Padding(2);
            this.btncheck.Name = "btncheck";
            this.btncheck.Size = new System.Drawing.Size(169, 50);
            this.btncheck.TabIndex = 3;
            this.btncheck.Text = "Ну, посмотри раз хочешь";
            this.btncheck.UseVisualStyleBackColor = true;
            this.btncheck.Click += new System.EventHandler(this.btncheck_Click);
            // 
            // prod_table
            // 
            this.prod_table.BackgroundColor = System.Drawing.Color.LightSlateGray;
            this.prod_table.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.prod_table.Location = new System.Drawing.Point(12, 12);
            this.prod_table.Name = "prod_table";
            this.prod_table.Size = new System.Drawing.Size(529, 323);
            this.prod_table.TabIndex = 4;
            // 
            // exp_btn
            // 
            this.exp_btn.Location = new System.Drawing.Point(555, 357);
            this.exp_btn.Name = "exp_btn";
            this.exp_btn.Size = new System.Drawing.Size(127, 23);
            this.exp_btn.TabIndex = 5;
            this.exp_btn.Text = "Выгрузка данных";
            this.exp_btn.UseVisualStyleBackColor = true;
            this.exp_btn.Visible = false;
            this.exp_btn.Click += new System.EventHandler(this.exp_btn_Click);
            // 
            // Products
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::kr22.Properties.Resources.images;
            this.ClientSize = new System.Drawing.Size(1100, 545);
            this.Controls.Add(this.exp_btn);
            this.Controls.Add(this.prod_table);
            this.Controls.Add(this.btncheck);
            this.Controls.Add(this.btnhome2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "Products";
            this.Text = "Products";
            ((System.ComponentModel.ISupportInitialize)(this.prod_table)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnhome2;
        private System.Windows.Forms.Button btncheck;
        private System.Windows.Forms.DataGridView prod_table;
        private System.Windows.Forms.Button exp_btn;
    }
}