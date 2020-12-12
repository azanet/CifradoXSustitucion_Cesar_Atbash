
using System.Windows.Forms;

namespace CifradoXSustitucion
{
    partial class FrmPrincipal
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtBoxInput = new System.Windows.Forms.TextBox();
            this.lblInput = new System.Windows.Forms.Label();
            this.rBtnCesarBrute = new System.Windows.Forms.RadioButton();
            this.lblSelectRoot = new System.Windows.Forms.Label();
            this.lblTitleSelection = new System.Windows.Forms.Label();
            this.rBtnCesarRoot = new System.Windows.Forms.RadioButton();
            this.rBtnAtbash = new System.Windows.Forms.RadioButton();
            this.txtBoxOutput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.cmbBoxNumberRoot = new System.Windows.Forms.ComboBox();
            this.btnDesCipher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(0, 1);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtBoxInput);
            this.splitContainer1.Panel1.Controls.Add(this.lblInput);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rBtnCesarBrute);
            this.splitContainer1.Panel2.Controls.Add(this.lblSelectRoot);
            this.splitContainer1.Panel2.Controls.Add(this.lblTitleSelection);
            this.splitContainer1.Panel2.Controls.Add(this.rBtnCesarRoot);
            this.splitContainer1.Panel2.Controls.Add(this.rBtnAtbash);
            this.splitContainer1.Panel2.Controls.Add(this.txtBoxOutput);
            this.splitContainer1.Panel2.Controls.Add(this.lblOutput);
            this.splitContainer1.Panel2.Controls.Add(this.cmbBoxNumberRoot);
            this.splitContainer1.Panel2.Controls.Add(this.btnDesCipher);
            this.splitContainer1.Size = new System.Drawing.Size(799, 449);
            this.splitContainer1.SplitterDistance = 132;
            this.splitContainer1.TabIndex = 6;
            // 
            // txtBoxInput
            // 
            this.txtBoxInput.AcceptsReturn = true;
            this.txtBoxInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxInput.Location = new System.Drawing.Point(16, 26);
            this.txtBoxInput.MinimumSize = new System.Drawing.Size(4, 50);
            this.txtBoxInput.Multiline = true;
            this.txtBoxInput.Name = "txtBoxInput";
            this.txtBoxInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxInput.Size = new System.Drawing.Size(768, 99);
            this.txtBoxInput.TabIndex = 1;
            this.txtBoxInput.WordWrap = false;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(13, 10);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(49, 13);
            this.lblInput.TabIndex = 4;
            this.lblInput.Text = "INPUT:";
            // 
            // rBtnCesarBrute
            // 
            this.rBtnCesarBrute.AutoSize = true;
            this.rBtnCesarBrute.Location = new System.Drawing.Point(228, 28);
            this.rBtnCesarBrute.Name = "rBtnCesarBrute";
            this.rBtnCesarBrute.Size = new System.Drawing.Size(227, 17);
            this.rBtnCesarBrute.TabIndex = 10;
            this.rBtnCesarBrute.TabStop = true;
            this.rBtnCesarBrute.Text = "CESAR [BruteForce 0-25 desplazamientos]";
            this.rBtnCesarBrute.UseVisualStyleBackColor = true;
            // 
            // lblSelectRoot
            // 
            this.lblSelectRoot.AutoSize = true;
            this.lblSelectRoot.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblSelectRoot.Location = new System.Drawing.Point(285, 54);
            this.lblSelectRoot.Name = "lblSelectRoot";
            this.lblSelectRoot.Size = new System.Drawing.Size(177, 13);
            this.lblSelectRoot.TabIndex = 9;
            this.lblSelectRoot.Text = "[Seleccione Nº de desplazamientos]";
            // 
            // lblTitleSelection
            // 
            this.lblTitleSelection.AutoSize = true;
            this.lblTitleSelection.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleSelection.Location = new System.Drawing.Point(113, 12);
            this.lblTitleSelection.Name = "lblTitleSelection";
            this.lblTitleSelection.Size = new System.Drawing.Size(118, 13);
            this.lblTitleSelection.TabIndex = 8;
            this.lblTitleSelection.Text = "Seleccione Cifrado:";
            // 
            // rBtnCesarRoot
            // 
            this.rBtnCesarRoot.AutoSize = true;
            this.rBtnCesarRoot.Location = new System.Drawing.Point(228, 52);
            this.rBtnCesarRoot.Name = "rBtnCesarRoot";
            this.rBtnCesarRoot.Size = new System.Drawing.Size(61, 17);
            this.rBtnCesarRoot.TabIndex = 7;
            this.rBtnCesarRoot.TabStop = true;
            this.rBtnCesarRoot.Text = "CESAR";
            this.rBtnCesarRoot.UseVisualStyleBackColor = true;
            // 
            // rBtnAtbash
            // 
            this.rBtnAtbash.AutoSize = true;
            this.rBtnAtbash.Location = new System.Drawing.Point(228, 76);
            this.rBtnAtbash.Name = "rBtnAtbash";
            this.rBtnAtbash.Size = new System.Drawing.Size(262, 17);
            this.rBtnAtbash.TabIndex = 6;
            this.rBtnAtbash.TabStop = true;
            this.rBtnAtbash.Text = "ATBASH o cifrado hebreo (Alfabeto invertido [z-a])";
            this.rBtnAtbash.UseVisualStyleBackColor = true;
            // 
            // txtBoxOutput
            // 
            this.txtBoxOutput.AcceptsReturn = true;
            this.txtBoxOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxOutput.Location = new System.Drawing.Point(12, 126);
            this.txtBoxOutput.Multiline = true;
            this.txtBoxOutput.Name = "txtBoxOutput";
            this.txtBoxOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtBoxOutput.Size = new System.Drawing.Size(772, 171);
            this.txtBoxOutput.TabIndex = 3;
            this.txtBoxOutput.WordWrap = false;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(13, 110);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(62, 13);
            this.lblOutput.TabIndex = 5;
            this.lblOutput.Text = "OUTPUT:";
            // 
            // cmbBoxNumberRoot
            // 
            this.cmbBoxNumberRoot.FormattingEnabled = true;
            this.cmbBoxNumberRoot.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25"});
            this.cmbBoxNumberRoot.Location = new System.Drawing.Point(468, 51);
            this.cmbBoxNumberRoot.Name = "cmbBoxNumberRoot";
            this.cmbBoxNumberRoot.Size = new System.Drawing.Size(58, 21);
            this.cmbBoxNumberRoot.TabIndex = 2;
            // 
            // btnDesCipher
            // 
            this.btnDesCipher.Location = new System.Drawing.Point(566, 40);
            this.btnDesCipher.Name = "btnDesCipher";
            this.btnDesCipher.Size = new System.Drawing.Size(150, 41);
            this.btnDesCipher.TabIndex = 0;
            this.btnDesCipher.Text = "Cifrar/Descifrar";
            this.btnDesCipher.UseVisualStyleBackColor = true;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DES/cifrar [Cesar, Atbash]";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxInput;
        public TextBox TxtBoxInput {
            get => txtBoxInput;
            set => txtBoxInput = value;
        }

        private System.Windows.Forms.Button btnDesCipher;
        public Button BtnDesCipher
        {
            get => btnDesCipher;
        }

        private System.Windows.Forms.ComboBox cmbBoxNumberRoot;
        public ComboBox CmbBoxNumberRoot {
            get => cmbBoxNumberRoot;
        }
        
        private System.Windows.Forms.RadioButton rBtnCesarRoot;
        public RadioButton RBtnCesarRoot {
            get => rBtnCesarRoot;
        }

        private System.Windows.Forms.RadioButton rBtnAtbash;
        public RadioButton RBtnAtbash {
            get => rBtnAtbash;
        }

        private System.Windows.Forms.RadioButton rBtnCesarBrute;
        public RadioButton RBtnCesarBrute {
            get => rBtnCesarBrute;
        }


        private System.Windows.Forms.TextBox txtBoxOutput;
        public TextBox TxtBoxOutput
        {
            get => txtBoxOutput;
            set => txtBoxOutput = value;
        }

        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblSelectRoot;
        private System.Windows.Forms.Label lblTitleSelection;
        
    }
}

