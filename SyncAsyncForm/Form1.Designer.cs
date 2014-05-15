namespace SyncAsyncForm
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
            this.txt_Status = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_StartSyncLooping = new System.Windows.Forms.Button();
            this.btn_StartAsyncLooping = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_StartParallelExecution = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // txt_Status
            // 
            this.txt_Status.Location = new System.Drawing.Point(12, 111);
            this.txt_Status.Multiline = true;
            this.txt_Status.Name = "txt_Status";
            this.txt_Status.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Status.Size = new System.Drawing.Size(394, 196);
            this.txt_Status.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_StartSyncLooping);
            this.groupBox1.Controls.Add(this.btn_StartAsyncLooping);
            this.groupBox1.Location = new System.Drawing.Point(367, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 93);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sync Async Executions";
            // 
            // btn_StartSyncLooping
            // 
            this.btn_StartSyncLooping.Location = new System.Drawing.Point(37, 49);
            this.btn_StartSyncLooping.Name = "btn_StartSyncLooping";
            this.btn_StartSyncLooping.Size = new System.Drawing.Size(127, 23);
            this.btn_StartSyncLooping.TabIndex = 6;
            this.btn_StartSyncLooping.Text = "Start Sync Looping";
            this.btn_StartSyncLooping.UseVisualStyleBackColor = true;
            this.btn_StartSyncLooping.Click += new System.EventHandler(this.btn_StartSyncLooping_Click);
            // 
            // btn_StartAsyncLooping
            // 
            this.btn_StartAsyncLooping.Location = new System.Drawing.Point(37, 20);
            this.btn_StartAsyncLooping.Name = "btn_StartAsyncLooping";
            this.btn_StartAsyncLooping.Size = new System.Drawing.Size(127, 23);
            this.btn_StartAsyncLooping.TabIndex = 5;
            this.btn_StartAsyncLooping.Text = "Start Async Looping";
            this.btn_StartAsyncLooping.UseVisualStyleBackColor = true;
            this.btn_StartAsyncLooping.Click += new System.EventHandler(this.btn_StartAsyncLooping_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_StartParallelExecution);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 93);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Parallel Executions";
            // 
            // btn_StartParallelExecution
            // 
            this.btn_StartParallelExecution.Location = new System.Drawing.Point(20, 20);
            this.btn_StartParallelExecution.Name = "btn_StartParallelExecution";
            this.btn_StartParallelExecution.Size = new System.Drawing.Size(138, 23);
            this.btn_StartParallelExecution.TabIndex = 9;
            this.btn_StartParallelExecution.Text = "Start Parallel Processing";
            this.btn_StartParallelExecution.UseVisualStyleBackColor = true;
            this.btn_StartParallelExecution.Click += new System.EventHandler(this.btn_StartParallelExecution_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 319);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_Status);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Status;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_StartSyncLooping;
        private System.Windows.Forms.Button btn_StartAsyncLooping;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_StartParallelExecution;
    }
}

