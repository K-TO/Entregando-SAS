namespace Entregando.App
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.InputEmpleadoId = new System.Windows.Forms.TextBox();
            this.WarningLabel = new System.Windows.Forms.Label();
            this.viajesGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dateTimeFecha = new System.Windows.Forms.DateTimePicker();
            this.PlacaInput = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.viajesGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(402, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 52);
            this.button1.TabIndex = 0;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Id del empleado:";
            // 
            // InputEmpleadoId
            // 
            this.InputEmpleadoId.Location = new System.Drawing.Point(152, 39);
            this.InputEmpleadoId.Name = "InputEmpleadoId";
            this.InputEmpleadoId.Size = new System.Drawing.Size(200, 20);
            this.InputEmpleadoId.TabIndex = 2;
            this.InputEmpleadoId.TextChanged += new System.EventHandler(this.InputEmpleadoId_TextChanged);
            // 
            // WarningLabel
            // 
            this.WarningLabel.AutoSize = true;
            this.WarningLabel.ForeColor = System.Drawing.Color.Red;
            this.WarningLabel.Location = new System.Drawing.Point(41, 140);
            this.WarningLabel.Name = "WarningLabel";
            this.WarningLabel.Size = new System.Drawing.Size(0, 13);
            this.WarningLabel.TabIndex = 3;
            this.WarningLabel.UseMnemonic = false;
            // 
            // viajesGridView1
            // 
            this.viajesGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.viajesGridView1.Location = new System.Drawing.Point(44, 171);
            this.viajesGridView1.Name = "viajesGridView1";
            this.viajesGridView1.Size = new System.Drawing.Size(1106, 536);
            this.viajesGridView1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha de viaje:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Placa del vehículo:";
            // 
            // dateTimeFecha
            // 
            this.dateTimeFecha.AllowDrop = true;
            this.dateTimeFecha.Checked = false;
            this.dateTimeFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeFecha.Location = new System.Drawing.Point(152, 74);
            this.dateTimeFecha.Name = "dateTimeFecha";
            this.dateTimeFecha.ShowCheckBox = true;
            this.dateTimeFecha.Size = new System.Drawing.Size(200, 20);
            this.dateTimeFecha.TabIndex = 7;
            this.dateTimeFecha.Value = new System.DateTime(2020, 7, 5, 18, 9, 4, 0);
            this.dateTimeFecha.ValueChanged += new System.EventHandler(this.dateTimeFecha_ValueChanged);
            // 
            // PlacaInput
            // 
            this.PlacaInput.Location = new System.Drawing.Point(152, 111);
            this.PlacaInput.Name = "PlacaInput";
            this.PlacaInput.Size = new System.Drawing.Size(200, 20);
            this.PlacaInput.TabIndex = 8;
            this.PlacaInput.TextChanged += new System.EventHandler(this.PlacaInput_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 719);
            this.Controls.Add(this.PlacaInput);
            this.Controls.Add(this.dateTimeFecha);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.viajesGridView1);
            this.Controls.Add(this.WarningLabel);
            this.Controls.Add(this.InputEmpleadoId);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Empleados Dashboard - Entregando SAS";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.viajesGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox InputEmpleadoId;
        private System.Windows.Forms.Label WarningLabel;
        private System.Windows.Forms.DataGridView viajesGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dateTimeFecha;
        private System.Windows.Forms.TextBox PlacaInput;
    }
}

