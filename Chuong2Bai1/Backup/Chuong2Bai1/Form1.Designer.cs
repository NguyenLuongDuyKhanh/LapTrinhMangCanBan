namespace Chuong2Bai1
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
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.tbResults = new System.Windows.Forms.TextBox();
            this.btnReadAsync = new System.Windows.Forms.Button();
            this.btnReadSync = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // tbResults
            // 
            this.tbResults.Location = new System.Drawing.Point(30, 12);
            this.tbResults.Multiline = true;
            this.tbResults.Name = "tbResults";
            this.tbResults.Size = new System.Drawing.Size(381, 341);
            this.tbResults.TabIndex = 0;
            // 
            // btnReadAsync
            // 
            this.btnReadAsync.Location = new System.Drawing.Point(114, 359);
            this.btnReadAsync.Name = "btnReadAsync";
            this.btnReadAsync.Size = new System.Drawing.Size(75, 23);
            this.btnReadAsync.TabIndex = 1;
            this.btnReadAsync.Text = "ReadAsync";
            this.btnReadAsync.UseVisualStyleBackColor = true;
            this.btnReadAsync.Click += new System.EventHandler(this.btnReadAsync_Click);
            // 
            // btnReadSync
            // 
            this.btnReadSync.Location = new System.Drawing.Point(224, 359);
            this.btnReadSync.Name = "btnReadSync";
            this.btnReadSync.Size = new System.Drawing.Size(75, 23);
            this.btnReadSync.TabIndex = 2;
            this.btnReadSync.Text = "ReadSync";
            this.btnReadSync.UseVisualStyleBackColor = true;
            this.btnReadSync.Click += new System.EventHandler(this.btnReadSync_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 392);
            this.Controls.Add(this.btnReadSync);
            this.Controls.Add(this.btnReadAsync);
            this.Controls.Add(this.tbResults);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.TextBox tbResults;
        private System.Windows.Forms.Button btnReadAsync;
        private System.Windows.Forms.Button btnReadSync;
    }
}

