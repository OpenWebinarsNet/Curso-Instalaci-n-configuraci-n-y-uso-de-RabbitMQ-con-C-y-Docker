namespace RabbitMQProductor
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtMensaje = new System.Windows.Forms.TextBox();
            this.btnDirect = new System.Windows.Forms.Button();
            this.btnTopic = new System.Windows.Forms.Button();
            this.btnFanout = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Introduzca un mensaje";
            // 
            // txtMensaje
            // 
            this.txtMensaje.Location = new System.Drawing.Point(12, 27);
            this.txtMensaje.Name = "txtMensaje";
            this.txtMensaje.Size = new System.Drawing.Size(313, 23);
            this.txtMensaje.TabIndex = 1;
            // 
            // btnDirect
            // 
            this.btnDirect.Location = new System.Drawing.Point(12, 56);
            this.btnDirect.Name = "btnDirect";
            this.btnDirect.Size = new System.Drawing.Size(313, 23);
            this.btnDirect.TabIndex = 2;
            this.btnDirect.Text = "Enviar a Direct";
            this.btnDirect.UseVisualStyleBackColor = true;
            this.btnDirect.Click += new System.EventHandler(this.btnDirect_Click);
            // 
            // btnTopic
            // 
            this.btnTopic.Location = new System.Drawing.Point(12, 85);
            this.btnTopic.Name = "btnTopic";
            this.btnTopic.Size = new System.Drawing.Size(313, 23);
            this.btnTopic.TabIndex = 2;
            this.btnTopic.Text = "Enviar a Topic";
            this.btnTopic.UseVisualStyleBackColor = true;
            this.btnTopic.Click += new System.EventHandler(this.btnTopic_Click);
            // 
            // btnFanout
            // 
            this.btnFanout.Location = new System.Drawing.Point(12, 114);
            this.btnFanout.Name = "btnFanout";
            this.btnFanout.Size = new System.Drawing.Size(313, 23);
            this.btnFanout.TabIndex = 2;
            this.btnFanout.Text = "Enviar a Fanout";
            this.btnFanout.UseVisualStyleBackColor = true;
            this.btnFanout.Click += new System.EventHandler(this.btnFanout_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 162);
            this.Controls.Add(this.btnFanout);
            this.Controls.Add(this.btnTopic);
            this.Controls.Add(this.btnDirect);
            this.Controls.Add(this.txtMensaje);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtMensaje;
        private Button btnDirect;
        private Button btnTopic;
        private Button btnFanout;
    }
}