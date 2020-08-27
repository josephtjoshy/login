namespace login
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
            this.label1 = new System.Windows.Forms.Label();
            this.ipaddressinput = new System.Windows.Forms.TextBox();
            this.portinput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.connectbutton = new System.Windows.Forms.Button();
            this.sendtext = new System.Windows.Forms.TextBox();
            this.reciveText = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.connecting = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.stopbutton = new System.Windows.Forms.Button();
            this.startlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label1.Location = new System.Drawing.Point(115, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "ip address";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ipaddressinput
            // 
            this.ipaddressinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.ipaddressinput.Location = new System.Drawing.Point(278, 90);
            this.ipaddressinput.Name = "ipaddressinput";
            this.ipaddressinput.Size = new System.Drawing.Size(171, 23);
            this.ipaddressinput.TabIndex = 1;
            this.ipaddressinput.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // portinput
            // 
            this.portinput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.portinput.Location = new System.Drawing.Point(278, 138);
            this.portinput.Name = "portinput";
            this.portinput.Size = new System.Drawing.Size(171, 23);
            this.portinput.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
            this.label2.Location = new System.Drawing.Point(115, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 31);
            this.label2.TabIndex = 2;
            this.label2.Text = "port";
            // 
            // connectbutton
            // 
            this.connectbutton.Location = new System.Drawing.Point(323, 201);
            this.connectbutton.Name = "connectbutton";
            this.connectbutton.Size = new System.Drawing.Size(75, 23);
            this.connectbutton.TabIndex = 4;
            this.connectbutton.Text = "connect";
            this.connectbutton.UseVisualStyleBackColor = true;
            this.connectbutton.Click += new System.EventHandler(this.connectbutton_Click);
            // 
            // sendtext
            // 
            this.sendtext.Location = new System.Drawing.Point(578, 66);
            this.sendtext.Name = "sendtext";
            this.sendtext.Size = new System.Drawing.Size(185, 20);
            this.sendtext.TabIndex = 5;
            // 
            // reciveText
            // 
            this.reciveText.Location = new System.Drawing.Point(587, 118);
            this.reciveText.Multiline = true;
            this.reciveText.Name = "reciveText";
            this.reciveText.Size = new System.Drawing.Size(175, 132);
            this.reciveText.TabIndex = 6;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(779, 66);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 7;
            this.send.Text = "send";
            this.send.UseVisualStyleBackColor = true;
            // 
            // connecting
            // 
            this.connecting.AutoSize = true;
            this.connecting.Location = new System.Drawing.Point(320, 280);
            this.connecting.Name = "connecting";
            this.connecting.Size = new System.Drawing.Size(74, 13);
            this.connecting.TabIndex = 8;
            this.connecting.Text = "press connect";
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(587, 280);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(75, 23);
            this.startbutton.TabIndex = 9;
            this.startbutton.Text = "start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // stopbutton
            // 
            this.stopbutton.Location = new System.Drawing.Point(687, 280);
            this.stopbutton.Name = "stopbutton";
            this.stopbutton.Size = new System.Drawing.Size(75, 23);
            this.stopbutton.TabIndex = 10;
            this.stopbutton.Text = "stop";
            this.stopbutton.UseVisualStyleBackColor = true;
            this.stopbutton.Click += new System.EventHandler(this.stopbutton_Click);
            // 
            // startlabel
            // 
            this.startlabel.AutoSize = true;
            this.startlabel.Location = new System.Drawing.Point(638, 318);
            this.startlabel.Name = "startlabel";
            this.startlabel.Size = new System.Drawing.Size(55, 13);
            this.startlabel.TabIndex = 11;
            this.startlabel.Text = "press start";
            this.startlabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(913, 340);
            this.Controls.Add(this.startlabel);
            this.Controls.Add(this.stopbutton);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.connecting);
            this.Controls.Add(this.send);
            this.Controls.Add(this.reciveText);
            this.Controls.Add(this.sendtext);
            this.Controls.Add(this.connectbutton);
            this.Controls.Add(this.portinput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ipaddressinput);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ipaddressinput;
        private System.Windows.Forms.TextBox portinput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button connectbutton;
        private System.Windows.Forms.TextBox sendtext;
        private System.Windows.Forms.TextBox reciveText;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Label connecting;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Button stopbutton;
        private System.Windows.Forms.Label startlabel;
    }
}

