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
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnJugarComputadora = new System.Windows.Forms.Button();
            this.btnNuevoJuego = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gboxTicTac = new System.Windows.Forms.GroupBox();
            this.lblCurrentPlayer = new System.Windows.Forms.Label();
            this.lblTiempoTrans = new System.Windows.Forms.Label();
            this.tblTicTacToe = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.gboxInicio.SuspendLayout();
            this.gboxTicTac.SuspendLayout();
            this.tblTicTacToe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
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
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnSalir.Location = new System.Drawing.Point(16, 230);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(227, 42);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.btnJugarComputadora.Click += new System.EventHandler(this.btnJugarComputadora_Click);
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
            this.btnNuevoJuego.Click += new System.EventHandler(this.btnNuevoJuego_Click);
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
            // gboxTicTac
            // 
            this.gboxTicTac.Controls.Add(this.lblCurrentPlayer);
            this.gboxTicTac.Controls.Add(this.lblTiempoTrans);
            this.gboxTicTac.Controls.Add(this.tblTicTacToe);
            this.gboxTicTac.Location = new System.Drawing.Point(271, 12);
            this.gboxTicTac.Name = "gboxTicTac";
            this.gboxTicTac.Size = new System.Drawing.Size(700, 479);
            this.gboxTicTac.TabIndex = 1;
            this.gboxTicTac.TabStop = false;
            this.gboxTicTac.Enter += new System.EventHandler(this.gboxTicTac_Enter);
            // 
            // lblCurrentPlayer
            // 
            this.lblCurrentPlayer.AutoSize = true;
            this.lblCurrentPlayer.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurrentPlayer.Location = new System.Drawing.Point(49, 22);
            this.lblCurrentPlayer.Name = "lblCurrentPlayer";
            this.lblCurrentPlayer.Size = new System.Drawing.Size(82, 35);
            this.lblCurrentPlayer.TabIndex = 3;
            this.lblCurrentPlayer.Text = "Turno";
            this.lblCurrentPlayer.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // lblTiempoTrans
            // 
            this.lblTiempoTrans.AutoSize = true;
            this.lblTiempoTrans.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiempoTrans.Location = new System.Drawing.Point(543, 22);
            this.lblTiempoTrans.Name = "lblTiempoTrans";
            this.lblTiempoTrans.Size = new System.Drawing.Size(82, 35);
            this.lblTiempoTrans.TabIndex = 2;
            this.lblTiempoTrans.Text = "0.00s";
            this.lblTiempoTrans.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // tblTicTacToe
            // 
            this.tblTicTacToe.ColumnCount = 3;
            this.tblTicTacToe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblTicTacToe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblTicTacToe.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.tblTicTacToe.Controls.Add(this.pictureBox9, 2, 2);
            this.tblTicTacToe.Controls.Add(this.pictureBox8, 1, 2);
            this.tblTicTacToe.Controls.Add(this.pictureBox7, 0, 2);
            this.tblTicTacToe.Controls.Add(this.pictureBox6, 2, 1);
            this.tblTicTacToe.Controls.Add(this.pictureBox5, 1, 1);
            this.tblTicTacToe.Controls.Add(this.pictureBox4, 0, 1);
            this.tblTicTacToe.Controls.Add(this.pictureBox3, 2, 0);
            this.tblTicTacToe.Controls.Add(this.pictureBox2, 1, 0);
            this.tblTicTacToe.Controls.Add(this.pictureBox1, 0, 0);
            this.tblTicTacToe.Location = new System.Drawing.Point(76, 90);
            this.tblTicTacToe.Name = "tblTicTacToe";
            this.tblTicTacToe.RowCount = 3;
            this.tblTicTacToe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblTicTacToe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblTicTacToe.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tblTicTacToe.Size = new System.Drawing.Size(570, 358);
            this.tblTicTacToe.TabIndex = 0;
            this.tblTicTacToe.Paint += new System.Windows.Forms.PaintEventHandler(this.tblTicTacToe_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(192, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(183, 113);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(382, 3);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(183, 113);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(3, 122);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(183, 113);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Location = new System.Drawing.Point(192, 122);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(183, 113);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 4;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Location = new System.Drawing.Point(382, 122);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(183, 113);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 5;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Location = new System.Drawing.Point(3, 241);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(183, 113);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 6;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Location = new System.Drawing.Point(192, 241);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(183, 113);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 7;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Location = new System.Drawing.Point(382, 241);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(183, 113);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 8;
            this.pictureBox9.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 503);
            this.Controls.Add(this.gboxTicTac);
            this.Controls.Add(this.gboxInicio);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic-Tac-Toe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gboxInicio.ResumeLayout(false);
            this.gboxInicio.PerformLayout();
            this.gboxTicTac.ResumeLayout(false);
            this.gboxTicTac.PerformLayout();
            this.tblTicTacToe.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
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
        private System.Windows.Forms.Label lblTiempoTrans;
        private System.Windows.Forms.Label lblCurrentPlayer;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

