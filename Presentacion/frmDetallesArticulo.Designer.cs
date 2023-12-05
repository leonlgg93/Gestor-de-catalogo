
namespace Presentacion
{
    partial class frmDetallesArticulo
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDetallesArticulo));
            this.lwDetalles = new System.Windows.Forms.ListView();
            this.pbxDetalles = new System.Windows.Forms.PictureBox();
            this.btnVerDetalles = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // lwDetalles
            // 
            this.lwDetalles.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.lwDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lwDetalles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.lwDetalles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lwDetalles.ForeColor = System.Drawing.SystemColors.Window;
            this.lwDetalles.HideSelection = false;
            this.lwDetalles.Location = new System.Drawing.Point(12, 281);
            this.lwDetalles.Name = "lwDetalles";
            this.lwDetalles.Size = new System.Drawing.Size(297, 78);
            this.lwDetalles.TabIndex = 0;
            this.lwDetalles.UseCompatibleStateImageBehavior = false;
            this.lwDetalles.View = System.Windows.Forms.View.List;
            // 
            // pbxDetalles
            // 
            this.pbxDetalles.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pbxDetalles.Location = new System.Drawing.Point(12, 18);
            this.pbxDetalles.Name = "pbxDetalles";
            this.pbxDetalles.Size = new System.Drawing.Size(297, 257);
            this.pbxDetalles.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxDetalles.TabIndex = 1;
            this.pbxDetalles.TabStop = false;
            // 
            // btnVerDetalles
            // 
            this.btnVerDetalles.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnVerDetalles.Location = new System.Drawing.Point(70, 365);
            this.btnVerDetalles.Name = "btnVerDetalles";
            this.btnVerDetalles.Size = new System.Drawing.Size(81, 27);
            this.btnVerDetalles.TabIndex = 2;
            this.btnVerDetalles.Text = "Ver Detalles";
            this.btnVerDetalles.UseVisualStyleBackColor = true;
            this.btnVerDetalles.Click += new System.EventHandler(this.btnVerDetalles_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSalir.Location = new System.Drawing.Point(157, 365);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(81, 27);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmDetallesArticulo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(321, 394);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnVerDetalles);
            this.Controls.Add(this.pbxDetalles);
            this.Controls.Add(this.lwDetalles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(588, 649);
            this.MinimumSize = new System.Drawing.Size(337, 433);
            this.Name = "frmDetallesArticulo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Detalles";
            this.Load += new System.EventHandler(this.frmDetallesArticulo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxDetalles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lwDetalles;
        private System.Windows.Forms.PictureBox pbxDetalles;
        private System.Windows.Forms.Button btnVerDetalles;
        private System.Windows.Forms.Button btnSalir;
    }
}