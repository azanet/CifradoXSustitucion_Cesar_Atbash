using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CifradoXSustitucion
{
    public class ControllerEvents {

        private FrmPrincipal frmPrincipal;
        private ModelCipherCesarAtbash modelCipher;

        public ControllerEvents(FrmPrincipal frmPrincipal, ModelCipherCesarAtbash modelCipher) {
            this.frmPrincipal = frmPrincipal;
            this.modelCipher = modelCipher;

            InitEvents();
        }//Fin del constructor


        private void InitEvents() {

            frmPrincipal.BtnDesCipher.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Btn_Clicked);
            frmPrincipal.RBtnCesarRoot.CheckedChanged += new EventHandler(this.CesarRootIsSelected);
        }//Fin de InitEvnts


        //En este "listener" estaremos revisando de el RButtonCesarRoot está NO/activado para DES/habilitar el combobox
        private void CesarRootIsSelected(object sender, EventArgs e) {

            RadioButton obj = (RadioButton)sender;
            if (obj.Checked) {

                frmPrincipal.CmbBoxNumberRoot.Enabled = true;
            }else{

                frmPrincipal.CmbBoxNumberRoot.Enabled = false;
            }//Fin del If-Else

        }//Fin del ListenerRBtnCesarRoot


        private void Btn_Clicked(object sender, MouseEventArgs e) {

            if (frmPrincipal.RBtnCesarBrute.Checked){
                modelCipher.CesarBrute();
            }
            else if (frmPrincipal.RBtnCesarRoot.Checked){
                modelCipher.CesarRoot();

            }
            else if (frmPrincipal.RBtnAtbash.Checked) {
                modelCipher.Atbash();
            }


             
        }
    }//Fin de controllerEvents
}
