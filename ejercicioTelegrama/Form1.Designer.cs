namespace ejercicioTelegrama
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
            label1 = new Label();
            txtTelegrama = new TextBox();
            label2 = new Label();
            txtPrecio = new TextBox();
            btnCalcularPrecio = new Button();
            groupBox1 = new GroupBox();
            radioBtnUrgente = new RadioButton();
            radioBtnOrdinario = new RadioButton();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(52, 26);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Texto";
            // 
            // txtTelegrama
            // 
            txtTelegrama.Location = new Point(52, 56);
            txtTelegrama.Multiline = true;
            txtTelegrama.Name = "txtTelegrama";
            txtTelegrama.Size = new Size(406, 177);
            txtTelegrama.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(52, 344);
            label2.Name = "label2";
            label2.Size = new Size(41, 15);
            label2.TabIndex = 3;
            label2.Text = "Coste:";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(113, 336);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 4;
            // 
            // btnCalcularPrecio
            // 
            btnCalcularPrecio.Location = new Point(340, 269);
            btnCalcularPrecio.Name = "btnCalcularPrecio";
            btnCalcularPrecio.Size = new Size(118, 46);
            btnCalcularPrecio.TabIndex = 5;
            btnCalcularPrecio.Text = "Calcular";
            btnCalcularPrecio.UseVisualStyleBackColor = true;
            btnCalcularPrecio.Click += btnCalcularPrecio_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(radioBtnUrgente);
            groupBox1.Controls.Add(radioBtnOrdinario);
            groupBox1.Location = new Point(52, 239);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 47);
            groupBox1.TabIndex = 6;
            groupBox1.TabStop = false;
            // 
            // radioBtnUrgente
            // 
            radioBtnUrgente.AutoSize = true;
            radioBtnUrgente.Location = new Point(110, 18);
            radioBtnUrgente.Name = "radioBtnUrgente";
            radioBtnUrgente.Size = new Size(67, 19);
            radioBtnUrgente.TabIndex = 1;
            radioBtnUrgente.Text = "Urgente";
            radioBtnUrgente.UseVisualStyleBackColor = true;
            // 
            // radioBtnOrdinario
            // 
            radioBtnOrdinario.AutoSize = true;
            radioBtnOrdinario.Checked = true;
            radioBtnOrdinario.Location = new Point(12, 18);
            radioBtnOrdinario.Name = "radioBtnOrdinario";
            radioBtnOrdinario.Size = new Size(75, 19);
            radioBtnOrdinario.TabIndex = 0;
            radioBtnOrdinario.TabStop = true;
            radioBtnOrdinario.Text = "Ordinario";
            radioBtnOrdinario.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(515, 395);
            Controls.Add(groupBox1);
            Controls.Add(btnCalcularPrecio);
            Controls.Add(txtPrecio);
            Controls.Add(label2);
            Controls.Add(txtTelegrama);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtTelegrama;
        private Label label2;
        private TextBox txtPrecio;
        private Button btnCalcularPrecio;
        private GroupBox groupBox1;
        private RadioButton radioBtnUrgente;
        private RadioButton radioBtnOrdinario;
    }
}
