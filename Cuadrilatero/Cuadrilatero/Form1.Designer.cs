
namespace Cuadrilatero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_A = new System.Windows.Forms.Label();
            this.lbl_B = new System.Windows.Forms.Label();
            this.lbl_area = new System.Windows.Forms.Label();
            this.lbl_peri = new System.Windows.Forms.Label();
            this.tex_LadoA = new System.Windows.Forms.TextBox();
            this.tex_Peri = new System.Windows.Forms.TextBox();
            this.tex_Area = new System.Windows.Forms.TextBox();
            this.tex_LadoB = new System.Windows.Forms.TextBox();
            this.btn_salirr = new System.Windows.Forms.Button();
            this.btn_limpia = new System.Windows.Forms.Button();
            this.btn_calculo = new System.Windows.Forms.Button();
            this.picbox_cuadrado = new System.Windows.Forms.PictureBox();
            this.picbox_rectan = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_cuadrado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_rectan)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_A
            // 
            this.lbl_A.AutoSize = true;
            this.lbl_A.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_A.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_A.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_A.Location = new System.Drawing.Point(13, 57);
            this.lbl_A.Name = "lbl_A";
            this.lbl_A.Size = new System.Drawing.Size(70, 25);
            this.lbl_A.TabIndex = 0;
            this.lbl_A.Text = "Lado A";
            // 
            // lbl_B
            // 
            this.lbl_B.AutoSize = true;
            this.lbl_B.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_B.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.lbl_B.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_B.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_B.Location = new System.Drawing.Point(14, 102);
            this.lbl_B.Name = "lbl_B";
            this.lbl_B.Size = new System.Drawing.Size(69, 25);
            this.lbl_B.TabIndex = 1;
            this.lbl_B.Text = "Lado B";
            // 
            // lbl_area
            // 
            this.lbl_area.AutoSize = true;
            this.lbl_area.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_area.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.lbl_area.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_area.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_area.Location = new System.Drawing.Point(14, 151);
            this.lbl_area.Name = "lbl_area";
            this.lbl_area.Size = new System.Drawing.Size(51, 25);
            this.lbl_area.TabIndex = 2;
            this.lbl_area.Text = "Área";
            // 
            // lbl_peri
            // 
            this.lbl_peri.AutoSize = true;
            this.lbl_peri.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_peri.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.lbl_peri.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_peri.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_peri.Location = new System.Drawing.Point(14, 198);
            this.lbl_peri.Name = "lbl_peri";
            this.lbl_peri.Size = new System.Drawing.Size(94, 25);
            this.lbl_peri.TabIndex = 3;
            this.lbl_peri.Text = "Perímetro";
            // 
            // tex_LadoA
            // 
            this.tex_LadoA.BackColor = System.Drawing.SystemColors.InfoText;
            this.tex_LadoA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tex_LadoA.ForeColor = System.Drawing.SystemColors.Menu;
            this.tex_LadoA.Location = new System.Drawing.Point(115, 57);
            this.tex_LadoA.Name = "tex_LadoA";
            this.tex_LadoA.Size = new System.Drawing.Size(338, 23);
            this.tex_LadoA.TabIndex = 4;
            // 
            // tex_Peri
            // 
            this.tex_Peri.BackColor = System.Drawing.SystemColors.InfoText;
            this.tex_Peri.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tex_Peri.ForeColor = System.Drawing.SystemColors.Info;
            this.tex_Peri.Location = new System.Drawing.Point(114, 200);
            this.tex_Peri.Name = "tex_Peri";
            this.tex_Peri.Size = new System.Drawing.Size(339, 23);
            this.tex_Peri.TabIndex = 5;
            // 
            // tex_Area
            // 
            this.tex_Area.BackColor = System.Drawing.SystemColors.InfoText;
            this.tex_Area.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tex_Area.ForeColor = System.Drawing.SystemColors.Info;
            this.tex_Area.Location = new System.Drawing.Point(115, 157);
            this.tex_Area.Name = "tex_Area";
            this.tex_Area.Size = new System.Drawing.Size(339, 23);
            this.tex_Area.TabIndex = 6;
            // 
            // tex_LadoB
            // 
            this.tex_LadoB.BackColor = System.Drawing.SystemColors.InfoText;
            this.tex_LadoB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tex_LadoB.ForeColor = System.Drawing.SystemColors.Info;
            this.tex_LadoB.Location = new System.Drawing.Point(115, 104);
            this.tex_LadoB.Name = "tex_LadoB";
            this.tex_LadoB.Size = new System.Drawing.Size(339, 23);
            this.tex_LadoB.TabIndex = 7;
            // 
            // btn_salirr
            // 
            this.btn_salirr.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_salirr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_salirr.BackgroundImage")));
            this.btn_salirr.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_salirr.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_salirr.Location = new System.Drawing.Point(286, 269);
            this.btn_salirr.Name = "btn_salirr";
            this.btn_salirr.Size = new System.Drawing.Size(76, 53);
            this.btn_salirr.TabIndex = 11;
            this.btn_salirr.Text = "Salir";
            this.btn_salirr.UseVisualStyleBackColor = false;
            this.btn_salirr.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_limpia
            // 
            this.btn_limpia.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_limpia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_limpia.BackgroundImage")));
            this.btn_limpia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_limpia.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_limpia.Location = new System.Drawing.Point(148, 269);
            this.btn_limpia.Name = "btn_limpia";
            this.btn_limpia.Size = new System.Drawing.Size(84, 53);
            this.btn_limpia.TabIndex = 12;
            this.btn_limpia.Text = "Limpiar";
            this.btn_limpia.UseVisualStyleBackColor = false;
            this.btn_limpia.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_calculo
            // 
            this.btn_calculo.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.btn_calculo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_calculo.BackgroundImage")));
            this.btn_calculo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_calculo.ForeColor = System.Drawing.SystemColors.Info;
            this.btn_calculo.Location = new System.Drawing.Point(14, 269);
            this.btn_calculo.Name = "btn_calculo";
            this.btn_calculo.Size = new System.Drawing.Size(102, 53);
            this.btn_calculo.TabIndex = 13;
            this.btn_calculo.Text = "Calcular";
            this.btn_calculo.UseVisualStyleBackColor = false;
            this.btn_calculo.Click += new System.EventHandler(this.btn_calculo_Click);
            // 
            // picbox_cuadrado
            // 
            this.picbox_cuadrado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.picbox_cuadrado.Image = ((System.Drawing.Image)(resources.GetObject("picbox_cuadrado.Image")));
            this.picbox_cuadrado.Location = new System.Drawing.Point(12, 342);
            this.picbox_cuadrado.Name = "picbox_cuadrado";
            this.picbox_cuadrado.Size = new System.Drawing.Size(152, 109);
            this.picbox_cuadrado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_cuadrado.TabIndex = 14;
            this.picbox_cuadrado.TabStop = false;
            // 
            // picbox_rectan
            // 
            this.picbox_rectan.BackColor = System.Drawing.SystemColors.ControlDark;
            this.picbox_rectan.Image = ((System.Drawing.Image)(resources.GetObject("picbox_rectan.Image")));
            this.picbox_rectan.Location = new System.Drawing.Point(245, 342);
            this.picbox_rectan.Name = "picbox_rectan";
            this.picbox_rectan.Size = new System.Drawing.Size(239, 109);
            this.picbox_rectan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picbox_rectan.TabIndex = 15;
            this.picbox_rectan.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(541, 498);
            this.Controls.Add(this.picbox_rectan);
            this.Controls.Add(this.picbox_cuadrado);
            this.Controls.Add(this.btn_calculo);
            this.Controls.Add(this.btn_limpia);
            this.Controls.Add(this.btn_salirr);
            this.Controls.Add(this.tex_LadoB);
            this.Controls.Add(this.tex_Area);
            this.Controls.Add(this.tex_Peri);
            this.Controls.Add(this.tex_LadoA);
            this.Controls.Add(this.lbl_peri);
            this.Controls.Add(this.lbl_area);
            this.Controls.Add(this.lbl_B);
            this.Controls.Add(this.lbl_A);
            this.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.Name = "Form1";
            this.Text = "Calculo de Cuadrilateros";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picbox_cuadrado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbox_rectan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_A;
        private System.Windows.Forms.Label lbl_B;
        private System.Windows.Forms.Label lbl_area;
        private System.Windows.Forms.Label lbl_peri;
        private System.Windows.Forms.TextBox tex_LadoA;
        private System.Windows.Forms.TextBox tex_Peri;
        private System.Windows.Forms.TextBox tex_Area;
        private System.Windows.Forms.TextBox tex_LadoB;
        private System.Windows.Forms.Button btn_salirr;
        private System.Windows.Forms.Button btn_limpia;
        private System.Windows.Forms.Button btn_calculo;
        private System.Windows.Forms.PictureBox picbox_cuadrado;
        private System.Windows.Forms.PictureBox picbox_rectan;
    }
}

