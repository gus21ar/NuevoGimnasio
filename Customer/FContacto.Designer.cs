﻿namespace Customer
{
	partial class FContacto
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
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			btnSiguiente = new Button();
			btnAnterior = new Button();
			txtDireccion = new TextBox();
			txtTelefono = new TextBox();
			txtMail = new TextBox();
			btnCancelar = new Button();
			panel1 = new Panel();
			panel2 = new Panel();
			panel3 = new Panel();
			panel4 = new Panel();
			panel5 = new Panel();
			panel1.SuspendLayout();
			panel2.SuspendLayout();
			panel3.SuspendLayout();
			panel4.SuspendLayout();
			panel5.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.ForeColor = Color.White;
			label1.Location = new Point(20, 21);
			label1.Name = "label1";
			label1.Size = new Size(163, 38);
			label1.TabIndex = 0;
			label1.Text = "Dirección:";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.ForeColor = Color.White;
			label2.Location = new Point(20, 83);
			label2.Name = "label2";
			label2.Size = new Size(149, 38);
			label2.TabIndex = 1;
			label2.Text = "Telefono:";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.ForeColor = Color.White;
			label3.Location = new Point(20, 148);
			label3.Name = "label3";
			label3.Size = new Size(91, 38);
			label3.TabIndex = 2;
			label3.Text = "Mail:";
			// 
			// btnSiguiente
			// 
			btnSiguiente.BackColor = Color.SteelBlue;
			btnSiguiente.ForeColor = Color.White;
			btnSiguiente.Location = new Point(397, 10);
			btnSiguiente.Name = "btnSiguiente";
			btnSiguiente.Size = new Size(160, 50);
			btnSiguiente.TabIndex = 3;
			btnSiguiente.Text = "Siguiente";
			btnSiguiente.UseVisualStyleBackColor = false;
			btnSiguiente.Click += btnSiguiente_Click;
			// 
			// btnAnterior
			// 
			btnAnterior.BackColor = Color.SteelBlue;
			btnAnterior.ForeColor = Color.White;
			btnAnterior.Location = new Point(3, 10);
			btnAnterior.Name = "btnAnterior";
			btnAnterior.Size = new Size(160, 50);
			btnAnterior.TabIndex = 4;
			btnAnterior.Text = "Anterior";
			btnAnterior.UseVisualStyleBackColor = false;
			btnAnterior.Click += btnAnterior_Click;
			// 
			// txtDireccion
			// 
			txtDireccion.BackColor = Color.DarkGray;
			txtDireccion.ForeColor = Color.White;
			txtDireccion.Location = new Point(189, 21);
			txtDireccion.Name = "txtDireccion";
			txtDireccion.Size = new Size(391, 44);
			txtDireccion.TabIndex = 5;
			txtDireccion.TextAlign = HorizontalAlignment.Center;
			// 
			// txtTelefono
			// 
			txtTelefono.BackColor = Color.DarkGray;
			txtTelefono.ForeColor = Color.White;
			txtTelefono.Location = new Point(189, 83);
			txtTelefono.Name = "txtTelefono";
			txtTelefono.Size = new Size(391, 44);
			txtTelefono.TabIndex = 6;
			txtTelefono.TextAlign = HorizontalAlignment.Center;
			// 
			// txtMail
			// 
			txtMail.BackColor = Color.DarkGray;
			txtMail.ForeColor = Color.White;
			txtMail.Location = new Point(189, 148);
			txtMail.Name = "txtMail";
			txtMail.Size = new Size(391, 44);
			txtMail.TabIndex = 7;
			txtMail.TextAlign = HorizontalAlignment.Center;
			// 
			// btnCancelar
			// 
			btnCancelar.BackColor = Color.Firebrick;
			btnCancelar.ForeColor = Color.White;
			btnCancelar.Location = new Point(209, 10);
			btnCancelar.Name = "btnCancelar";
			btnCancelar.Size = new Size(160, 50);
			btnCancelar.TabIndex = 8;
			btnCancelar.Text = "Cancelar";
			btnCancelar.UseVisualStyleBackColor = false;
			btnCancelar.Click += btnCancelar_Click;
			// 
			// panel1
			// 
			panel1.BackColor = SystemColors.ControlDarkDark;
			panel1.Controls.Add(btnAnterior);
			panel1.Controls.Add(btnCancelar);
			panel1.Controls.Add(btnSiguiente);
			panel1.Location = new Point(20, 217);
			panel1.Name = "panel1";
			panel1.Size = new Size(560, 70);
			panel1.TabIndex = 9;
			// 
			// panel2
			// 
			panel2.BackColor = Color.DimGray;
			panel2.Controls.Add(label1);
			panel2.Controls.Add(panel1);
			panel2.Controls.Add(label2);
			panel2.Controls.Add(txtMail);
			panel2.Controls.Add(label3);
			panel2.Controls.Add(txtTelefono);
			panel2.Controls.Add(txtDireccion);
			panel2.Location = new Point(75, 165);
			panel2.Name = "panel2";
			panel2.Size = new Size(600, 300);
			panel2.TabIndex = 10;
			// 
			// panel3
			// 
			panel3.BackColor = Color.Gray;
			panel3.Controls.Add(panel4);
			panel3.Location = new Point(10, 10);
			panel3.Name = "panel3";
			panel3.Size = new Size(810, 690);
			panel3.TabIndex = 11;
			// 
			// panel4
			// 
			panel4.BackColor = Color.DarkGray;
			panel4.Controls.Add(panel5);
			panel4.Location = new Point(10, 10);
			panel4.Name = "panel4";
			panel4.Size = new Size(790, 670);
			panel4.TabIndex = 11;
			// 
			// panel5
			// 
			panel5.BackColor = Color.Silver;
			panel5.Controls.Add(panel2);
			panel5.Location = new Point(10, 10);
			panel5.Name = "panel5";
			panel5.Size = new Size(770, 650);
			panel5.TabIndex = 11;
			// 
			// FContacto
			// 
			AutoScaleDimensions = new SizeF(19F, 38F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.DimGray;
			ClientSize = new Size(830, 710);
			Controls.Add(panel3);
			Font = new Font("Georgia", 24F, FontStyle.Regular, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.None;
			Margin = new Padding(8);
			Name = "FContacto";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Datos de Contacto";
			panel1.ResumeLayout(false);
			panel2.ResumeLayout(false);
			panel2.PerformLayout();
			panel3.ResumeLayout(false);
			panel4.ResumeLayout(false);
			panel5.ResumeLayout(false);
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Button btnSiguiente;
		private Button btnAnterior;
		private TextBox txtDireccion;
		private TextBox txtTelefono;
		private TextBox txtMail;
		private Button btnCancelar;
		private Panel panel1;
		private Panel panel2;
		private Panel panel3;
		private Panel panel4;
		private Panel panel5;
	}
}