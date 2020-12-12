using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;


namespace CifradoXSustitucion
{
    public class ControllerPrincipal {

        private ControllerEvents ctrlEvents;
        private ModelCipherCesarAtbash modelCipher;
        private FrmPrincipal frmPrincipal;

        public ControllerPrincipal() {

            this.frmPrincipal = new FrmPrincipal();
            InitFrmElements();
            this.modelCipher= new ModelCipherCesarAtbash(frmPrincipal);
            this.ctrlEvents = new ControllerEvents(frmPrincipal,modelCipher);



            //Lanzando FRM
            Application.EnableVisualStyles();
            Application.Run(frmPrincipal);


        }//Fin del controlador principal

        private void InitFrmElements() {
            frmPrincipal.CmbBoxNumberRoot.Enabled = false;
            frmPrincipal.CmbBoxNumberRoot.SelectedIndex = 0;
            frmPrincipal.RBtnCesarBrute.Checked = true;
        }
    }//Fin del ControllerPrincipal
}
