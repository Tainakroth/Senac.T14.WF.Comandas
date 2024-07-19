namespace Comandas
{
    partial class FrmCardapio
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
            Cardapio = new ReaLTaiizor.Forms.ForeverForm();
            btnVoltar = new ReaLTaiizor.Controls.CyberButton();
            Cardapio.SuspendLayout();
            SuspendLayout();
            // 
            // Cardapio
            // 
            Cardapio.BackColor = Color.White;
            Cardapio.BaseColor = Color.FromArgb(60, 70, 73);
            Cardapio.BorderColor = Color.DodgerBlue;
            Cardapio.Controls.Add(btnVoltar);
            Cardapio.Dock = DockStyle.Fill;
            Cardapio.Font = new Font("Segoe UI", 12F);
            Cardapio.ForeverColor = Color.FromArgb(35, 168, 109);
            Cardapio.HeaderColor = Color.FromArgb(45, 47, 49);
            Cardapio.HeaderMaximize = false;
            Cardapio.HeaderTextFont = new Font("Segoe UI", 12F);
            Cardapio.Image = null;
            Cardapio.Location = new Point(0, 0);
            Cardapio.MinimumSize = new Size(210, 50);
            Cardapio.Name = "Cardapio";
            Cardapio.Padding = new Padding(1, 51, 1, 1);
            Cardapio.Sizable = true;
            Cardapio.Size = new Size(800, 443);
            Cardapio.TabIndex = 0;
            Cardapio.Text = "Cardápio";
            Cardapio.TextColor = Color.FromArgb(234, 234, 234);
            Cardapio.TextLight = Color.SeaGreen;
            // 
            // btnVoltar
            // 
            btnVoltar.Alpha = 20;
            btnVoltar.BackColor = Color.Transparent;
            btnVoltar.Background = true;
            btnVoltar.Background_WidthPen = 4F;
            btnVoltar.BackgroundPen = true;
            btnVoltar.ColorBackground = Color.FromArgb(37, 52, 68);
            btnVoltar.ColorBackground_1 = Color.FromArgb(37, 52, 68);
            btnVoltar.ColorBackground_2 = Color.FromArgb(41, 63, 86);
            btnVoltar.ColorBackground_Pen = Color.FromArgb(29, 200, 238);
            btnVoltar.ColorLighting = Color.FromArgb(29, 200, 238);
            btnVoltar.ColorPen_1 = Color.FromArgb(37, 52, 68);
            btnVoltar.ColorPen_2 = Color.FromArgb(41, 63, 86);
            btnVoltar.CyberButtonStyle = ReaLTaiizor.Enum.Cyber.StateStyle.Custom;
            btnVoltar.Effect_1 = true;
            btnVoltar.Effect_1_ColorBackground = Color.FromArgb(29, 200, 238);
            btnVoltar.Effect_1_Transparency = 25;
            btnVoltar.Effect_2 = true;
            btnVoltar.Effect_2_ColorBackground = Color.White;
            btnVoltar.Effect_2_Transparency = 20;
            btnVoltar.Font = new Font("Arial", 11F);
            btnVoltar.ForeColor = Color.FromArgb(245, 245, 245);
            btnVoltar.Lighting = false;
            btnVoltar.LinearGradient_Background = false;
            btnVoltar.LinearGradientPen = false;
            btnVoltar.Location = new Point(12, 338);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.PenWidth = 15;
            btnVoltar.RGB = true;
            btnVoltar.Rounding = true;
            btnVoltar.RoundingInt = 70;
            btnVoltar.Size = new Size(173, 77);
            btnVoltar.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnVoltar.TabIndex = 1;
            btnVoltar.Tag = "Cyber";
            btnVoltar.TextButton = "Voltar";
            btnVoltar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnVoltar.Timer_Effect_1 = 5;
            btnVoltar.Timer_RGB = 300;
            btnVoltar.Click += btnVoltar_Click_1;
            // 
            // FrmCardapio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 443);
            Controls.Add(Cardapio);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FrmCardapio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cardapio";
            TransparencyKey = Color.Fuchsia;
            Click += FrmCardapio_Click;
            Cardapio.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Forms.ForeverForm Cardapio;
        private ReaLTaiizor.Controls.CyberButton btnVoltar;
    }
}