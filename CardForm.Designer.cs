namespace ScopeCards
{
    partial class CardForm
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
            this.uploadBtn = new System.Windows.Forms.Button();
            this.GVCards = new System.Windows.Forms.DataGridView();
            this.gvInterventions = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.gvAlternates = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gvRecipient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.GVCards)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInterventions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAlternates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecipient)).BeginInit();
            this.SuspendLayout();
            // 
            // uploadBtn
            // 
            this.uploadBtn.Location = new System.Drawing.Point(67, 5);
            this.uploadBtn.Name = "uploadBtn";
            this.uploadBtn.Size = new System.Drawing.Size(75, 23);
            this.uploadBtn.TabIndex = 0;
            this.uploadBtn.Text = "Upload Json";
            this.uploadBtn.UseVisualStyleBackColor = true;
            this.uploadBtn.Click += new System.EventHandler(this.upload_Click);
            // 
            // GVCards
            // 
            this.GVCards.AllowUserToAddRows = false;
            this.GVCards.AllowUserToOrderColumns = true;
            this.GVCards.AllowUserToResizeRows = false;
            this.GVCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GVCards.Location = new System.Drawing.Point(12, 34);
            this.GVCards.Name = "GVCards";
            this.GVCards.Size = new System.Drawing.Size(776, 371);
            this.GVCards.TabIndex = 1;
            this.GVCards.SelectionChanged += new System.EventHandler(this.GVCards_SelectionChanged);
            this.GVCards.DoubleClick += new System.EventHandler(this.GVCards_DoubleClick);
            // 
            // gvInterventions
            // 
            this.gvInterventions.AllowUserToAddRows = false;
            this.gvInterventions.AllowUserToDeleteRows = false;
            this.gvInterventions.AllowUserToOrderColumns = true;
            this.gvInterventions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvInterventions.Enabled = false;
            this.gvInterventions.Location = new System.Drawing.Point(9, 432);
            this.gvInterventions.Name = "gvInterventions";
            this.gvInterventions.ReadOnly = true;
            this.gvInterventions.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gvInterventions.Size = new System.Drawing.Size(89, 71);
            this.gvInterventions.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 413);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Interventions";
            // 
            // gvAlternates
            // 
            this.gvAlternates.AllowUserToAddRows = false;
            this.gvAlternates.AllowUserToDeleteRows = false;
            this.gvAlternates.AllowUserToOrderColumns = true;
            this.gvAlternates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvAlternates.Enabled = false;
            this.gvAlternates.Location = new System.Drawing.Point(107, 531);
            this.gvAlternates.Name = "gvAlternates";
            this.gvAlternates.ReadOnly = true;
            this.gvAlternates.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gvAlternates.Size = new System.Drawing.Size(681, 71);
            this.gvAlternates.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Recipient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(107, 511);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Alternates";
            // 
            // gvRecipient
            // 
            this.gvRecipient.AllowUserToAddRows = false;
            this.gvRecipient.AllowUserToDeleteRows = false;
            this.gvRecipient.AllowUserToOrderColumns = true;
            this.gvRecipient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvRecipient.Enabled = false;
            this.gvRecipient.Location = new System.Drawing.Point(107, 432);
            this.gvRecipient.Name = "gvRecipient";
            this.gvRecipient.ReadOnly = true;
            this.gvRecipient.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.gvRecipient.Size = new System.Drawing.Size(681, 71);
            this.gvRecipient.TabIndex = 7;
            // 
            // CardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 609);
            this.Controls.Add(this.gvRecipient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gvAlternates);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gvInterventions);
            this.Controls.Add(this.GVCards);
            this.Controls.Add(this.uploadBtn);
            this.Name = "CardForm";
            this.Text = "Scope Cards";
            ((System.ComponentModel.ISupportInitialize)(this.GVCards)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvInterventions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvAlternates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gvRecipient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button uploadBtn;
        private System.Windows.Forms.DataGridView GVCards;
        private System.Windows.Forms.DataGridView gvInterventions;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView gvAlternates;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gvRecipient;
    }
}

