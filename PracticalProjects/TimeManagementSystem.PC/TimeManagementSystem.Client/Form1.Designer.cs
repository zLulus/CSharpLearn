
namespace TimeManagementSystem.PC
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
            this.TheTaskList = new System.Windows.Forms.ListBox();
            this.DetailEditAddButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.CompleteButton = new System.Windows.Forms.Button();
            this.StopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TheTaskList
            // 
            this.TheTaskList.FormattingEnabled = true;
            this.TheTaskList.ItemHeight = 12;
            this.TheTaskList.Location = new System.Drawing.Point(34, 47);
            this.TheTaskList.Name = "TheTaskList";
            this.TheTaskList.Size = new System.Drawing.Size(586, 352);
            this.TheTaskList.TabIndex = 0;
            this.TheTaskList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // DetailEditAddButton
            // 
            this.DetailEditAddButton.Location = new System.Drawing.Point(667, 47);
            this.DetailEditAddButton.Name = "DetailEditAddButton";
            this.DetailEditAddButton.Size = new System.Drawing.Size(112, 47);
            this.DetailEditAddButton.TabIndex = 5;
            this.DetailEditAddButton.Text = "详情/编辑/新增";
            this.DetailEditAddButton.UseVisualStyleBackColor = true;
            this.DetailEditAddButton.Click += new System.EventHandler(this.DetailEditAddButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(667, 150);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(112, 47);
            this.DeleteButton.TabIndex = 6;
            this.DeleteButton.Text = "删除";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // CompleteButton
            // 
            this.CompleteButton.Location = new System.Drawing.Point(667, 352);
            this.CompleteButton.Name = "CompleteButton";
            this.CompleteButton.Size = new System.Drawing.Size(112, 47);
            this.CompleteButton.TabIndex = 8;
            this.CompleteButton.Text = "完成";
            this.CompleteButton.UseVisualStyleBackColor = true;
            this.CompleteButton.Click += new System.EventHandler(this.Complete_Click);
            // 
            // StopButton
            // 
            this.StopButton.Location = new System.Drawing.Point(667, 248);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(112, 47);
            this.StopButton.TabIndex = 9;
            this.StopButton.Text = "中止";
            this.StopButton.UseVisualStyleBackColor = true;
            this.StopButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.CompleteButton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.DetailEditAddButton);
            this.Controls.Add(this.TheTaskList);
            this.Name = "Form1";
            this.Text = "时间管理";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox TheTaskList;
        private System.Windows.Forms.Button DetailEditAddButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button CompleteButton;
        private System.Windows.Forms.Button StopButton;
    }
}

