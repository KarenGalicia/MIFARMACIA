﻿namespace MIFARMACIA
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Button_mostrar = new System.Windows.Forms.Button();
            this.dataGridViewvermedicamentos = new System.Windows.Forms.DataGridView();
            this.buttonprueba = new System.Windows.Forms.Button();
            this.Buttonagregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.text_Id = new System.Windows.Forms.TextBox();
            this.Text_producto = new System.Windows.Forms.TextBox();
            this.Text_Tipodemedicamento = new System.Windows.Forms.TextBox();
            this.text_Descripción = new System.Windows.Forms.TextBox();
            this.Text_Categoria = new System.Windows.Forms.TextBox();
            this.text_Precio = new System.Windows.Forms.TextBox();
            this.text_Marca = new System.Windows.Forms.TextBox();
            this.Text_Dosis = new System.Windows.Forms.TextBox();
            this.text_Presentacion = new System.Windows.Forms.TextBox();
            this.Text_Restriccionesdeventa = new System.Windows.Forms.TextBox();
            this.Text_Indicaciones = new System.Windows.Forms.TextBox();
            this.Text_Contraindicaciones = new System.Windows.Forms.TextBox();
            this.Text_Efectossecundarios = new System.Windows.Forms.TextBox();
            this.tText_Proveedor = new System.Windows.Forms.TextBox();
            this.Text_Ubicaciondeproducto = new System.Windows.Forms.TextBox();
            this.dateTimePickerFechadevencimiento = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_Fechadeadquisicion = new System.Windows.Forms.DateTimePicker();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Button_actualizar = new System.Windows.Forms.Button();
            this.Check_Existencia = new System.Windows.Forms.CheckBox();
            this.eliminarBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewvermedicamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_mostrar
            // 
            this.Button_mostrar.Location = new System.Drawing.Point(182, 673);
            this.Button_mostrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_mostrar.Name = "Button_mostrar";
            this.Button_mostrar.Size = new System.Drawing.Size(140, 36);
            this.Button_mostrar.TabIndex = 0;
            this.Button_mostrar.Text = "MOSTRAR MEDICAMENTOS";
            this.Button_mostrar.UseVisualStyleBackColor = true;
            this.Button_mostrar.Click += new System.EventHandler(this.Button_mostrar_Click);
            // 
            // dataGridViewvermedicamentos
            // 
            this.dataGridViewvermedicamentos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridViewvermedicamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewvermedicamentos.Location = new System.Drawing.Point(-4, 446);
            this.dataGridViewvermedicamentos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridViewvermedicamentos.Name = "dataGridViewvermedicamentos";
            this.dataGridViewvermedicamentos.Size = new System.Drawing.Size(1186, 220);
            this.dataGridViewvermedicamentos.TabIndex = 1;
            // 
            // buttonprueba
            // 
            this.buttonprueba.Location = new System.Drawing.Point(0, 673);
            this.buttonprueba.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonprueba.Name = "buttonprueba";
            this.buttonprueba.Size = new System.Drawing.Size(145, 41);
            this.buttonprueba.TabIndex = 2;
            this.buttonprueba.Text = "RECARGAR DATOS";
            this.buttonprueba.UseVisualStyleBackColor = true;
            this.buttonprueba.Click += new System.EventHandler(this.Buttonprueba_Click);
            // 
            // Buttonagregar
            // 
            this.Buttonagregar.Location = new System.Drawing.Point(1000, 276);
            this.Buttonagregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Buttonagregar.Name = "Buttonagregar";
            this.Buttonagregar.Size = new System.Drawing.Size(183, 44);
            this.Buttonagregar.TabIndex = 3;
            this.Buttonagregar.Text = "INGRESAR NUEVOS MEDICAMENTO";
            this.Buttonagregar.UseVisualStyleBackColor = true;
            this.Buttonagregar.Click += new System.EventHandler(this.Buttonagregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(-6, 119);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(213, 122);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 14);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombre de producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(671, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 14);
            this.label3.TabIndex = 6;
            this.label3.Text = "Tipo de medicamento:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-6, 149);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 14);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descripción:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 149);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 14);
            this.label5.TabIndex = 8;
            this.label5.Text = "Categoría:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-2, 189);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 14);
            this.label6.TabIndex = 9;
            this.label6.Text = "Marca:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(572, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 14);
            this.label8.TabIndex = 11;
            this.label8.Text = "Precio:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(365, 189);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 14);
            this.label10.TabIndex = 13;
            this.label10.Text = "Presentacion:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(200, 188);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 14);
            this.label12.TabIndex = 15;
            this.label12.Text = "Dosis:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(783, 189);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(135, 14);
            this.label13.TabIndex = 16;
            this.label13.Text = "Fecha de vencimiento:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(-7, 285);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 14);
            this.label14.TabIndex = 17;
            this.label14.Text = "Proveedor:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(248, 287);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(141, 14);
            this.label15.TabIndex = 18;
            this.label15.Text = "Ubicación de producto:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(-13, 257);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(123, 14);
            this.label16.TabIndex = 19;
            this.label16.Text = "Contraindicaciones:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(-6, 224);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(86, 14);
            this.label17.TabIndex = 20;
            this.label17.Text = "Indicaciones:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(530, 252);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(131, 14);
            this.label18.TabIndex = 21;
            this.label18.Text = "Efectos Secundarios:";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(772, 152);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(148, 14);
            this.label19.TabIndex = 22;
            this.label19.Text = "Restricciones de venta:";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(572, 292);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(135, 14);
            this.label20.TabIndex = 23;
            this.label20.Text = "Fecha de adquisición: ";
            // 
            // text_Id
            // 
            this.text_Id.Location = new System.Drawing.Point(23, 118);
            this.text_Id.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_Id.Name = "text_Id";
            this.text_Id.Size = new System.Drawing.Size(193, 25);
            this.text_Id.TabIndex = 26;
            // 
            // Text_producto
            // 
            this.Text_producto.Location = new System.Drawing.Point(349, 119);
            this.Text_producto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Text_producto.Name = "Text_producto";
            this.Text_producto.Size = new System.Drawing.Size(318, 25);
            this.Text_producto.TabIndex = 27;
            // 
            // Text_Tipodemedicamento
            // 
            this.Text_Tipodemedicamento.Location = new System.Drawing.Point(803, 117);
            this.Text_Tipodemedicamento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Text_Tipodemedicamento.Name = "Text_Tipodemedicamento";
            this.Text_Tipodemedicamento.Size = new System.Drawing.Size(380, 25);
            this.Text_Tipodemedicamento.TabIndex = 28;
            // 
            // text_Descripción
            // 
            this.text_Descripción.Location = new System.Drawing.Point(75, 146);
            this.text_Descripción.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_Descripción.Name = "text_Descripción";
            this.text_Descripción.Size = new System.Drawing.Size(250, 25);
            this.text_Descripción.TabIndex = 29;
            // 
            // Text_Categoria
            // 
            this.Text_Categoria.Location = new System.Drawing.Point(418, 146);
            this.Text_Categoria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Text_Categoria.Name = "Text_Categoria";
            this.Text_Categoria.Size = new System.Drawing.Size(139, 25);
            this.Text_Categoria.TabIndex = 30;
            // 
            // text_Precio
            // 
            this.text_Precio.Location = new System.Drawing.Point(622, 148);
            this.text_Precio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_Precio.Name = "text_Precio";
            this.text_Precio.Size = new System.Drawing.Size(139, 25);
            this.text_Precio.TabIndex = 31;
            // 
            // text_Marca
            // 
            this.text_Marca.Location = new System.Drawing.Point(49, 186);
            this.text_Marca.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_Marca.Name = "text_Marca";
            this.text_Marca.Size = new System.Drawing.Size(139, 25);
            this.text_Marca.TabIndex = 33;
            // 
            // Text_Dosis
            // 
            this.Text_Dosis.Location = new System.Drawing.Point(248, 186);
            this.Text_Dosis.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Text_Dosis.Name = "Text_Dosis";
            this.Text_Dosis.Size = new System.Drawing.Size(96, 25);
            this.Text_Dosis.TabIndex = 35;
            // 
            // text_Presentacion
            // 
            this.text_Presentacion.Location = new System.Drawing.Point(456, 186);
            this.text_Presentacion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.text_Presentacion.Name = "text_Presentacion";
            this.text_Presentacion.Size = new System.Drawing.Size(199, 25);
            this.text_Presentacion.TabIndex = 36;
            // 
            // Text_Restriccionesdeventa
            // 
            this.Text_Restriccionesdeventa.Location = new System.Drawing.Point(909, 150);
            this.Text_Restriccionesdeventa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Text_Restriccionesdeventa.Name = "Text_Restriccionesdeventa";
            this.Text_Restriccionesdeventa.Size = new System.Drawing.Size(274, 25);
            this.Text_Restriccionesdeventa.TabIndex = 37;
            // 
            // Text_Indicaciones
            // 
            this.Text_Indicaciones.Location = new System.Drawing.Point(75, 220);
            this.Text_Indicaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Text_Indicaciones.Name = "Text_Indicaciones";
            this.Text_Indicaciones.Size = new System.Drawing.Size(1108, 25);
            this.Text_Indicaciones.TabIndex = 38;
            // 
            // Text_Contraindicaciones
            // 
            this.Text_Contraindicaciones.Location = new System.Drawing.Point(102, 252);
            this.Text_Contraindicaciones.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Text_Contraindicaciones.Name = "Text_Contraindicaciones";
            this.Text_Contraindicaciones.Size = new System.Drawing.Size(420, 25);
            this.Text_Contraindicaciones.TabIndex = 39;
            // 
            // Text_Efectossecundarios
            // 
            this.Text_Efectossecundarios.Location = new System.Drawing.Point(663, 248);
            this.Text_Efectossecundarios.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Text_Efectossecundarios.Name = "Text_Efectossecundarios";
            this.Text_Efectossecundarios.Size = new System.Drawing.Size(520, 25);
            this.Text_Efectossecundarios.TabIndex = 40;
            // 
            // tText_Proveedor
            // 
            this.tText_Proveedor.Location = new System.Drawing.Point(64, 285);
            this.tText_Proveedor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tText_Proveedor.Name = "tText_Proveedor";
            this.tText_Proveedor.Size = new System.Drawing.Size(172, 25);
            this.tText_Proveedor.TabIndex = 41;
            // 
            // Text_Ubicaciondeproducto
            // 
            this.Text_Ubicaciondeproducto.Location = new System.Drawing.Point(385, 287);
            this.Text_Ubicaciondeproducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Text_Ubicaciondeproducto.Name = "Text_Ubicaciondeproducto";
            this.Text_Ubicaciondeproducto.Size = new System.Drawing.Size(172, 25);
            this.Text_Ubicaciondeproducto.TabIndex = 42;
            // 
            // dateTimePickerFechadevencimiento
            // 
            this.dateTimePickerFechadevencimiento.Location = new System.Drawing.Point(924, 189);
            this.dateTimePickerFechadevencimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePickerFechadevencimiento.Name = "dateTimePickerFechadevencimiento";
            this.dateTimePickerFechadevencimiento.Size = new System.Drawing.Size(258, 25);
            this.dateTimePickerFechadevencimiento.TabIndex = 44;
            // 
            // dateTimePicker_Fechadeadquisicion
            // 
            this.dateTimePicker_Fechadeadquisicion.Location = new System.Drawing.Point(712, 287);
            this.dateTimePicker_Fechadeadquisicion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker_Fechadeadquisicion.Name = "dateTimePicker_Fechadeadquisicion";
            this.dateTimePicker_Fechadeadquisicion.Size = new System.Drawing.Size(270, 25);
            this.dateTimePicker_Fechadeadquisicion.TabIndex = 45;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Button_actualizar
            // 
            this.Button_actualizar.Location = new System.Drawing.Point(486, 341);
            this.Button_actualizar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Button_actualizar.Name = "Button_actualizar";
            this.Button_actualizar.Size = new System.Drawing.Size(200, 55);
            this.Button_actualizar.TabIndex = 50;
            this.Button_actualizar.Text = "ACTUALIZAR";
            this.Button_actualizar.UseVisualStyleBackColor = true;
            this.Button_actualizar.Click += new System.EventHandler(this.Button_actualizar_Click);
            // 
            // Check_Existencia
            // 
            this.Check_Existencia.AutoSize = true;
            this.Check_Existencia.Location = new System.Drawing.Point(668, 188);
            this.Check_Existencia.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Check_Existencia.Name = "Check_Existencia";
            this.Check_Existencia.Size = new System.Drawing.Size(96, 18);
            this.Check_Existencia.TabIndex = 48;
            this.Check_Existencia.Text = "EXISTENCIA:";
            this.Check_Existencia.UseVisualStyleBackColor = true;
            // 
            // eliminarBtn
            // 
            this.eliminarBtn.Location = new System.Drawing.Point(1000, 328);
            this.eliminarBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.eliminarBtn.Name = "eliminarBtn";
            this.eliminarBtn.Size = new System.Drawing.Size(183, 44);
            this.eliminarBtn.TabIndex = 51;
            this.eliminarBtn.Text = "ELIMINAR MEDICAMENTO";
            this.eliminarBtn.UseVisualStyleBackColor = true;
            this.eliminarBtn.Click += new System.EventHandler(this.eliminarBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1296, 617);
            this.Controls.Add(this.eliminarBtn);
            this.Controls.Add(this.Button_actualizar);
            this.Controls.Add(this.Check_Existencia);
            this.Controls.Add(this.dateTimePicker_Fechadeadquisicion);
            this.Controls.Add(this.dateTimePickerFechadevencimiento);
            this.Controls.Add(this.Text_Ubicaciondeproducto);
            this.Controls.Add(this.tText_Proveedor);
            this.Controls.Add(this.Text_Efectossecundarios);
            this.Controls.Add(this.Text_Contraindicaciones);
            this.Controls.Add(this.Text_Indicaciones);
            this.Controls.Add(this.Text_Restriccionesdeventa);
            this.Controls.Add(this.text_Presentacion);
            this.Controls.Add(this.Text_Dosis);
            this.Controls.Add(this.text_Marca);
            this.Controls.Add(this.text_Precio);
            this.Controls.Add(this.Text_Categoria);
            this.Controls.Add(this.text_Descripción);
            this.Controls.Add(this.Text_Tipodemedicamento);
            this.Controls.Add(this.Text_producto);
            this.Controls.Add(this.text_Id);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Buttonagregar);
            this.Controls.Add(this.buttonprueba);
            this.Controls.Add(this.dataGridViewvermedicamentos);
            this.Controls.Add(this.Button_mostrar);
            this.Font = new System.Drawing.Font("The Students Teacher", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "FarmVida";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewvermedicamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Button_mostrar;
        private System.Windows.Forms.DataGridView dataGridViewvermedicamentos;
        private System.Windows.Forms.Button buttonprueba;
        private System.Windows.Forms.Button Buttonagregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox text_Id;
        private System.Windows.Forms.TextBox Text_producto;
        private System.Windows.Forms.TextBox Text_Tipodemedicamento;
        private System.Windows.Forms.TextBox text_Descripción;
        private System.Windows.Forms.TextBox Text_Categoria;
        private System.Windows.Forms.TextBox text_Precio;
        private System.Windows.Forms.TextBox text_Marca;
        private System.Windows.Forms.TextBox Text_Dosis;
        private System.Windows.Forms.TextBox text_Presentacion;
        private System.Windows.Forms.TextBox Text_Restriccionesdeventa;
        private System.Windows.Forms.TextBox Text_Indicaciones;
        private System.Windows.Forms.TextBox Text_Contraindicaciones;
        private System.Windows.Forms.TextBox Text_Efectossecundarios;
        private System.Windows.Forms.TextBox tText_Proveedor;
        private System.Windows.Forms.TextBox Text_Ubicaciondeproducto;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechadevencimiento;
        private System.Windows.Forms.DateTimePicker dateTimePicker_Fechadeadquisicion;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Button_actualizar;
        private System.Windows.Forms.CheckBox Check_Existencia;
        private System.Windows.Forms.Button eliminarBtn;
    }
}

