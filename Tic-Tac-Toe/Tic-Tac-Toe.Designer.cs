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
            this.gboxTicTac.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxInicio
            // 
            this.gboxInicio.Location = new System.Drawing.Point(12, 12);
            this.gboxInicio.Name = "gboxInicio";
            this.gboxInicio.Size = new System.Drawing.Size(231, 454);
            this.gboxInicio.TabIndex = 0;
            this.gboxInicio.TabStop = false;
            // 
            // gboxTicTac
            // 
            this.gboxTicTac.Controls.Add(this.tblTicTacToe);
            this.gboxTicTac.Location = new System.Drawing.Point(261, 12);
            this.gboxTicTac.Name = "gboxTicTac";
            this.gboxTicTac.Size = new System.Drawing.Size(674, 454);
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
            this.gboxTicTac.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxInicio;
        private System.Windows.Forms.GroupBox gboxTicTac;
        private System.Windows.Forms.TableLayoutPanel tblTicTacToe;
    }
}

