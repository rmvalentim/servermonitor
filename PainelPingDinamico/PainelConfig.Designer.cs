namespace PainelPingDinamico
{
    partial class PainelConfig
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
            this.lblPacote = new MetroFramework.Controls.MetroLabel();
            this.txtPacote = new MetroFramework.Controls.MetroTextBox();
            this.lblIp = new MetroFramework.Controls.MetroLabel();
            this.txtIp = new MetroFramework.Controls.MetroTextBox();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnConfirmar = new MetroFramework.Controls.MetroButton();
            this.lblLocalidade = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // lblPacote
            // 
            this.lblPacote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPacote.AutoSize = true;
            this.lblPacote.Location = new System.Drawing.Point(148, 39);
            this.lblPacote.Name = "lblPacote";
            this.lblPacote.Size = new System.Drawing.Size(51, 19);
            this.lblPacote.TabIndex = 8;
            this.lblPacote.Text = "Pacote:";
            // 
            // txtPacote
            // 
            this.txtPacote.AllowDrop = true;
            this.txtPacote.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPacote.Location = new System.Drawing.Point(205, 39);
            this.txtPacote.Name = "txtPacote";
            this.txtPacote.Size = new System.Drawing.Size(76, 20);
            this.txtPacote.TabIndex = 7;
            // 
            // lblIp
            // 
            this.lblIp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblIp.Location = new System.Drawing.Point(11, 39);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(23, 18);
            this.lblIp.TabIndex = 6;
            this.lblIp.Text = "IP:";
            // 
            // txtIp
            // 
            this.txtIp.AllowDrop = true;
            this.txtIp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtIp.Location = new System.Drawing.Point(40, 39);
            this.txtIp.Name = "txtIp";
            this.txtIp.Size = new System.Drawing.Size(105, 20);
            this.txtIp.TabIndex = 5;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(40, 66);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(105, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(166, 66);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(114, 23);
            this.btnConfirmar.TabIndex = 10;
            this.btnConfirmar.Text = "Confirmar";
            // 
            // lblLocalidade
            // 
            this.lblLocalidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLocalidade.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblLocalidade.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.lblLocalidade.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblLocalidade.Location = new System.Drawing.Point(11, 7);
            this.lblLocalidade.Name = "lblLocalidade";
            this.lblLocalidade.Size = new System.Drawing.Size(269, 29);
            this.lblLocalidade.TabIndex = 11;
            this.lblLocalidade.Text = "Localidade";
            this.lblLocalidade.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblLocalidade.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // PainelConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 107);
            this.Controls.Add(this.lblLocalidade);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblPacote);
            this.Controls.Add(this.txtPacote);
            this.Controls.Add(this.lblIp);
            this.Controls.Add(this.txtIp);
            this.Name = "PainelConfig";
            this.ShowIcon = false;
            this.Text = "Definições do Painel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel lblPacote;
        private MetroFramework.Controls.MetroTextBox txtPacote;
        private MetroFramework.Controls.MetroLabel lblIp;
        private MetroFramework.Controls.MetroTextBox txtIp;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnConfirmar;
        private MetroFramework.Controls.MetroLabel lblLocalidade;
    }
}