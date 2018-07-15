namespace RegistroLibro.UI.Registrar
{
    partial class rLibros
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
            this.components = new System.ComponentModel.Container();
            this.BuscarButton = new System.Windows.Forms.Button();
            this.NuevoButton = new System.Windows.Forms.Button();
            this.GuardarButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.LibrosIdNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.DescripcionTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SiglasTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.FechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.TipoComboBox = new System.Windows.Forms.ComboBox();
            this.MyErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.LibrosIdNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // BuscarButton
            // 
            this.BuscarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BuscarButton.Image = global::RegistroLibro.Properties.Resources.Search_16px;
            this.BuscarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BuscarButton.Location = new System.Drawing.Point(150, 6);
            this.BuscarButton.Name = "BuscarButton";
            this.BuscarButton.Size = new System.Drawing.Size(80, 23);
            this.BuscarButton.TabIndex = 77;
            this.BuscarButton.Text = "Buscar";
            this.BuscarButton.UseVisualStyleBackColor = true;
            this.BuscarButton.Click += new System.EventHandler(this.BuscarButton_Click);
            // 
            // NuevoButton
            // 
            this.NuevoButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.NuevoButton.Image = global::RegistroLibro.Properties.Resources.Save_16px;
            this.NuevoButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.NuevoButton.Location = new System.Drawing.Point(12, 205);
            this.NuevoButton.Name = "NuevoButton";
            this.NuevoButton.Size = new System.Drawing.Size(67, 43);
            this.NuevoButton.TabIndex = 78;
            this.NuevoButton.Text = "Nuevo";
            this.NuevoButton.UseVisualStyleBackColor = true;
            this.NuevoButton.Click += new System.EventHandler(this.NuevoButton_Click);
            // 
            // GuardarButton
            // 
            this.GuardarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GuardarButton.Image = global::RegistroLibro.Properties.Resources.Edit_Property_16px;
            this.GuardarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.GuardarButton.Location = new System.Drawing.Point(85, 205);
            this.GuardarButton.Name = "GuardarButton";
            this.GuardarButton.Size = new System.Drawing.Size(80, 43);
            this.GuardarButton.TabIndex = 79;
            this.GuardarButton.Text = "Guardar";
            this.GuardarButton.UseVisualStyleBackColor = true;
            this.GuardarButton.Click += new System.EventHandler(this.GuardarButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.EliminarButton.Image = global::RegistroLibro.Properties.Resources.Delete_16px;
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EliminarButton.Location = new System.Drawing.Point(171, 205);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(74, 43);
            this.EliminarButton.TabIndex = 80;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 81;
            this.label1.Text = "ArtículoId";
            // 
            // LibrosIdNumericUpDown
            // 
            this.LibrosIdNumericUpDown.Location = new System.Drawing.Point(68, 8);
            this.LibrosIdNumericUpDown.Name = "LibrosIdNumericUpDown";
            this.LibrosIdNumericUpDown.Size = new System.Drawing.Size(75, 20);
            this.LibrosIdNumericUpDown.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 83;
            this.label2.Text = "Descripción";
            // 
            // DescripcionTextBox
            // 
            this.DescripcionTextBox.Location = new System.Drawing.Point(68, 87);
            this.DescripcionTextBox.Multiline = true;
            this.DescripcionTextBox.Name = "DescripcionTextBox";
            this.DescripcionTextBox.Size = new System.Drawing.Size(162, 34);
            this.DescripcionTextBox.TabIndex = 84;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 85;
            this.label3.Text = "Siglas";
            // 
            // SiglasTextBox
            // 
            this.SiglasTextBox.Location = new System.Drawing.Point(68, 127);
            this.SiglasTextBox.Multiline = true;
            this.SiglasTextBox.Name = "SiglasTextBox";
            this.SiglasTextBox.Size = new System.Drawing.Size(162, 33);
            this.SiglasTextBox.TabIndex = 86;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 87;
            this.label4.Text = "Tipo";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 88;
            this.label7.Text = "Fecha";
            // 
            // FechaDateTimePicker
            // 
            this.FechaDateTimePicker.CustomFormat = "dd//MM/yy";
            this.FechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.FechaDateTimePicker.Location = new System.Drawing.Point(68, 48);
            this.FechaDateTimePicker.Name = "FechaDateTimePicker";
            this.FechaDateTimePicker.Size = new System.Drawing.Size(97, 20);
            this.FechaDateTimePicker.TabIndex = 89;
            // 
            // TipoComboBox
            // 
            this.TipoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoComboBox.FormattingEnabled = true;
            this.TipoComboBox.Items.AddRange(new object[] {
            "Viejo Testamento",
            "Nuevo Testamento"});
            this.TipoComboBox.Location = new System.Drawing.Point(68, 166);
            this.TipoComboBox.Name = "TipoComboBox";
            this.TipoComboBox.Size = new System.Drawing.Size(162, 21);
            this.TipoComboBox.TabIndex = 90;
            // 
            // MyErrorProvider
            // 
            this.MyErrorProvider.ContainerControl = this;
            // 
            // rLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(257, 260);
            this.Controls.Add(this.TipoComboBox);
            this.Controls.Add(this.FechaDateTimePicker);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SiglasTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DescripcionTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LibrosIdNumericUpDown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.GuardarButton);
            this.Controls.Add(this.NuevoButton);
            this.Controls.Add(this.BuscarButton);
            this.Name = "rLibros";
            this.Text = "rLibros";
            ((System.ComponentModel.ISupportInitialize)(this.LibrosIdNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BuscarButton;
        private System.Windows.Forms.Button NuevoButton;
        private System.Windows.Forms.Button GuardarButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown LibrosIdNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox DescripcionTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SiglasTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker FechaDateTimePicker;
        private System.Windows.Forms.ComboBox TipoComboBox;
        private System.Windows.Forms.ErrorProvider MyErrorProvider;
    }
}