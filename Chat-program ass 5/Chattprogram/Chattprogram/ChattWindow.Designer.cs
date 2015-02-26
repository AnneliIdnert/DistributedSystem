namespace Chattprogram
{
    partial class ChatClient
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
            this.button1 = new System.Windows.Forms.Button();
            this.lisConversation = new System.Windows.Forms.ListBox();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listB_responseFromServer = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(504, 75);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "ok!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lisConversation
            // 
            this.lisConversation.FormattingEnabled = true;
            this.lisConversation.ItemHeight = 20;
            this.lisConversation.Location = new System.Drawing.Point(52, 114);
            this.lisConversation.Name = "lisConversation";
            this.lisConversation.Size = new System.Drawing.Size(436, 64);
            this.lisConversation.TabIndex = 1;
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(54, 75);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(436, 26);
            this.txt_input.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Weekend Getaway";
            // 
            // listB_responseFromServer
            // 
            this.listB_responseFromServer.FormattingEnabled = true;
            this.listB_responseFromServer.ItemHeight = 20;
            this.listB_responseFromServer.Location = new System.Drawing.Point(54, 236);
            this.listB_responseFromServer.Name = "listB_responseFromServer";
            this.listB_responseFromServer.Size = new System.Drawing.Size(434, 84);
            this.listB_responseFromServer.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 198);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Weekend Getaway";
            // 
            // ChatClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 400);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listB_responseFromServer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.lisConversation);
            this.Controls.Add(this.button1);
            this.Name = "ChatClient";
            this.Text = "ChatWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lisConversation;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listB_responseFromServer;
        private System.Windows.Forms.Label label2;
    }
}

