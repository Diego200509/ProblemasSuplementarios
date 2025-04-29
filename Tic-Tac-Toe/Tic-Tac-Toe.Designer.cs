namespace Tic_Tac_Toe
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
            this.gboxInicio = new System.Windows.Forms.GroupBox();
            this.gboxTicTac = new System.Windows.Forms.GroupBox();
            this.tblTicTacToe = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnNuevoJuego = new System.Windows.Forms.Button();
            this.btnJugarComputadora = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.gboxInicio.SuspendLayout();
            this.gboxTicTac.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxInicio
            // 
            this.gboxInicio.Controls.Add(this.btnSalir);
            this.gboxInicio.Controls.Add(this.btnJugarComputadora);
            this.gboxInicio.Controls.Add(this.btnNuevoJuego);
            this.gboxInicio.Controls.Add(this.lblTitulo);
            this.gboxInicio.Location = new System.Drawing.Point(12, 12);
            this.gboxInicio.Margin = new System.Windows.Forms.Padding(4);
            this.gboxInicio.Name = "gboxInicio";
            this.gboxInicio.Size = new System.Drawing.Size(252, 479);
            this.gboxInicio.TabIndex = 0;
            this.gboxInicio.TabStop = false;
            // 
            // gboxTicTac
            // 
            this.gboxTicTac.Controls.Add(this.tblTicTacToe);
            this.gboxTicTac.Location = new System.Drawing.Point(271, 12);
            this.gboxTicTac.Name = "gboxTicTac";
            this.gboxTicTac.Size = new System.Drawing.Size(674, 479);
            this.gboxTicTac.TabIndex = 1;
            this.gboxTicTac.TabStop = false;
            // 
            // tblTicTacToe
            // 
            this.tblTicTacToe.ColumnCount = 3;
            this.tblTicTacToe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblTicTacToe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblTicTacToe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblTicTacToe.Location = new System.Drawing.Point(55, 90);
            this.tblTicTacToe.Name = "tblTicTacToe";
            this.tblTicTacToe.RowCount = 3;
            this.tblTicTacToe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblTicTacToe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblTicTacToe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblTicTacToe.Size = new System.Drawing.Size(570, 358);
            this.tblTicTacToe.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(48, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(167, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Tres en calle";
            this.lblTitulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnNuevoJuego
            // 
            this.btnNuevoJuego.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNuevoJuego.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevoJuego.Location = new System.Drawing.Point(16, 90);
            this.btnNuevoJuego.Name = "btnNuevoJuego";
            this.btnNuevoJuego.Size = new System.Drawing.Size(227, 49);
            this.btnNuevoJuego.TabIndex = 1;
            this.btnNuevoJuego.Text = "Nuevo Juego";
            this.btnNuevoJuego.UseVisualStyleBackColor = true;
            // 
            // btnJugarComputadora
            // 
            this.btnJugarComputadora.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnJugarComputadora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnJugarComputadora.Location = new System.Drawing.Point(16, 159);
            this.btnJugarComputadora.Name = "btnJugarComputadora";
            this.btnJugarComputadora.Size = new System.Drawing.Size(227, 55);
            this.btnJugarComputadora.TabIndex = 2;
            this.btnJugarComputadora.Text = "Jugar con computadora";
            this.btnJugarComputadora.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Location = new System.Drawing.Point(16, 230);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(227, 42);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 503);
            this.Controls.Add(this.gboxTicTac);
            this.Controls.Add(this.gboxInicio);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboxInicio.ResumeLayout(false);
            this.gboxInicio.PerformLayout();
            this.gboxTicTac.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxInicio;
        private System.Windows.Forms.GroupBox gboxTicTac;
        private System.Windows.Forms.TableLayoutPanel tblTicTacToe;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnNuevoJuego;
        private System.Windows.Forms.Button btnJugarComputadora;
        private System.Windows.Forms.Button btnSalir;
    }
}

