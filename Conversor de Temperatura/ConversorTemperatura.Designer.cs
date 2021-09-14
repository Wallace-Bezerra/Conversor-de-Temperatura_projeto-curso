
namespace Conversor_de_Temperatura
{
    partial class ConversorTemperatura
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
            this.comboBox_1Temp = new System.Windows.Forms.ComboBox();
            this.comboBox_2Temp = new System.Windows.Forms.ComboBox();
            this.textBox_Resultado = new System.Windows.Forms.TextBox();
            this.button_RealizarConversao = new System.Windows.Forms.Button();
            this.textBox_Temp1 = new System.Windows.Forms.TextBox();
            this.label_Para = new System.Windows.Forms.Label();
            this.label1_igual = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_Limpar = new System.Windows.Forms.Button();
            this.label_Letra_Temperatura = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_1Temp
            // 
            this.comboBox_1Temp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_1Temp.FormattingEnabled = true;
            this.comboBox_1Temp.Items.AddRange(new object[] {
            "",
            "Celsius",
            "Fahrenheit"});
            this.comboBox_1Temp.Location = new System.Drawing.Point(154, 280);
            this.comboBox_1Temp.Name = "comboBox_1Temp";
            this.comboBox_1Temp.Size = new System.Drawing.Size(114, 26);
            this.comboBox_1Temp.TabIndex = 0;
            this.comboBox_1Temp.SelectionChangeCommitted += new System.EventHandler(this.comboBox_1Temp_SelectionChangeCommitted);
            // 
            // comboBox_2Temp
            // 
            this.comboBox_2Temp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_2Temp.FormattingEnabled = true;
            this.comboBox_2Temp.Items.AddRange(new object[] {
            "",
            "Celsius",
            "Fahrenheit"});
            this.comboBox_2Temp.Location = new System.Drawing.Point(347, 280);
            this.comboBox_2Temp.Name = "comboBox_2Temp";
            this.comboBox_2Temp.Size = new System.Drawing.Size(134, 26);
            this.comboBox_2Temp.TabIndex = 0;
            // 
            // textBox_Resultado
            // 
            this.textBox_Resultado.Location = new System.Drawing.Point(518, 279);
            this.textBox_Resultado.Multiline = true;
            this.textBox_Resultado.Name = "textBox_Resultado";
            this.textBox_Resultado.ReadOnly = true;
            this.textBox_Resultado.Size = new System.Drawing.Size(116, 28);
            this.textBox_Resultado.TabIndex = 1;
            // 
            // button_RealizarConversao
            // 
            this.button_RealizarConversao.Font = new System.Drawing.Font("Consolas", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_RealizarConversao.Location = new System.Drawing.Point(96, 390);
            this.button_RealizarConversao.Name = "button_RealizarConversao";
            this.button_RealizarConversao.Size = new System.Drawing.Size(225, 77);
            this.button_RealizarConversao.TabIndex = 2;
            this.button_RealizarConversao.Text = "Converter";
            this.button_RealizarConversao.UseVisualStyleBackColor = true;
            this.button_RealizarConversao.Click += new System.EventHandler(this.button_RealizarConversao_Click);
            // 
            // textBox_Temp1
            // 
            this.textBox_Temp1.Location = new System.Drawing.Point(36, 279);
            this.textBox_Temp1.Multiline = true;
            this.textBox_Temp1.Name = "textBox_Temp1";
            this.textBox_Temp1.Size = new System.Drawing.Size(89, 28);
            this.textBox_Temp1.TabIndex = 3;
            this.textBox_Temp1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Para
            // 
            this.label_Para.AutoSize = true;
            this.label_Para.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label_Para.Location = new System.Drawing.Point(283, 281);
            this.label_Para.Name = "label_Para";
            this.label_Para.Size = new System.Drawing.Size(58, 24);
            this.label_Para.TabIndex = 4;
            this.label_Para.Text = "Para";
            // 
            // label1_igual
            // 
            this.label1_igual.AutoSize = true;
            this.label1_igual.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1_igual.Location = new System.Drawing.Point(487, 279);
            this.label1_igual.Name = "label1_igual";
            this.label1_igual.Size = new System.Drawing.Size(25, 28);
            this.label1_igual.TabIndex = 5;
            this.label1_igual.Text = "=";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Conversor_de_Temperatura.Properties.Resources.ConversordeTemperatura;
            this.pictureBox1.Location = new System.Drawing.Point(96, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(439, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox2
            // 
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "",
            "Celsius",
            "Fahrenheit"});
            this.comboBox2.Location = new System.Drawing.Point(290, 226);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(134, 23);
            this.comboBox2.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(461, 227);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(101, 23);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(-21, 285);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(75, 23);
            this.textBox2.TabIndex = 3;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(226, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "Para";
            // 
            // button_Limpar
            // 
            this.button_Limpar.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button_Limpar.Location = new System.Drawing.Point(388, 395);
            this.button_Limpar.Name = "button_Limpar";
            this.button_Limpar.Size = new System.Drawing.Size(147, 70);
            this.button_Limpar.TabIndex = 7;
            this.button_Limpar.Text = "Limpar";
            this.button_Limpar.UseVisualStyleBackColor = true;
            this.button_Limpar.Click += new System.EventHandler(this.button_Limpar_Click);
            // 
            // label_Letra_Temperatura
            // 
            this.label_Letra_Temperatura.BackColor = System.Drawing.Color.White;
            this.label_Letra_Temperatura.Location = new System.Drawing.Point(96, 282);
            this.label_Letra_Temperatura.Name = "label_Letra_Temperatura";
            this.label_Letra_Temperatura.Size = new System.Drawing.Size(29, 22);
            this.label_Letra_Temperatura.TabIndex = 8;
            this.label_Letra_Temperatura.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // ConversorTemperatura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 546);
            this.Controls.Add(this.label_Letra_Temperatura);
            this.Controls.Add(this.button_Limpar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1_igual);
            this.Controls.Add(this.label_Para);
            this.Controls.Add(this.textBox_Temp1);
            this.Controls.Add(this.button_RealizarConversao);
            this.Controls.Add(this.textBox_Resultado);
            this.Controls.Add(this.comboBox_2Temp);
            this.Controls.Add(this.comboBox_1Temp);
            this.Font = new System.Drawing.Font("Consolas", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ConversorTemperatura";
            this.Text = "Conversor de Temperatura";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_1Temp;
        private System.Windows.Forms.ComboBox comboBox_2Temp;
        private System.Windows.Forms.TextBox textBox_Resultado;
        private System.Windows.Forms.Button button_RealizarConversao;
        private System.Windows.Forms.TextBox textBox_Temp1;
        private System.Windows.Forms.Label label_Para;
        private System.Windows.Forms.Label label1_igual;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_Limpar;
        private System.Windows.Forms.Label label_Letra_Temperatura;
    }
}

