using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CifradoXSustitucion
{
    public class ModelCipherCesarAtbash {
      
        private FrmPrincipal frmPrincipal;

  //      private char[] charLetters = {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z',
  //                             '火' ,'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z'};


        public ModelCipherCesarAtbash( FrmPrincipal frmPrincipal) {

            this.frmPrincipal = frmPrincipal;
           
        }//Fin del constructor




        public void CesarBrute() {
           Console.WriteLine("CesarBrute");

            frmPrincipal.TxtBoxOutput.Text = ($"Aplicando ROOT[intervalo 0-25]:\r\n\r\n");
            
            char[] input = frmPrincipal.TxtBoxInput.Text.ToCharArray();//Recogiendo el texto del INPUT en un array de CHAR
           
            for (int root = 0; root < 26 ; root++) {
              
                frmPrincipal.TxtBoxOutput.AppendText($"ROOT[{root}]==> {RunCesarRotate(input, root)}\r\n\r\n");//Escribiendo resultado ibtenido de la llamada al Método RunCesarRotate en el OUTPUT
            }//Fin del for que realiza todas las posibilidades
                       
        }//Fin de CesarBrute



        public void CesarRoot() {

            frmPrincipal.TxtBoxOutput.Text = ($"Aplicando ROOT[{frmPrincipal.CmbBoxNumberRoot.SelectedItem.ToString()}]:\r\n\r\n");
            int root = Int32.Parse(frmPrincipal.CmbBoxNumberRoot.SelectedItem.ToString());//Recogiendo objeto seleccionado en el ComboBox
            
            char[] input = frmPrincipal.TxtBoxInput.Text.ToCharArray();//Recogiendo el texto del INPUT en un array de CHAR
            
            string result = RunCesarRotate(input,root);//Almacenamos el resultado devuelto por el método RunCesarRotate, que producirá la rotación (Podía habermela ahorrado)

            frmPrincipal.TxtBoxOutput.Text += result;//Escribiendo resultado en el OUTPUT

        }//Fin de CesarRoot





        public void Atbash() {
            //Recogiendo el texto del INPUT en un array de CHAR
            char[] input = frmPrincipal.TxtBoxInput.Text.ToCharArray();

            //Creamos un Diccionario en el que almacenaremos la Letra NORMAL como Key y el valor 'invertido' como Value
            Dictionary<char, char> dic = new Dictionary<char, char>();

            //CARGAMOS el diccionario 
            for (int i = 0; i < 26; i++) {

                int minuscAsc = 97 + i;
                int minuscDesc = 122 - i;
                dic.Add((char)minuscAsc, (char)minuscDesc);
                int mayuscAsc = 65 + i;
                int mayuscDesc = 90 - i;
                dic.Add((char)mayuscAsc, (char)mayuscDesc);
            }// Fin del For que carga el diccionario
            
            frmPrincipal.TxtBoxOutput.Text = "Aplicando ATBASH:\r\n\r\n";

            //Comenzamos a aplicar el DES/cifrado sobre nuestro array de char y a imprimirlo directamente
            for (int i = 0; i < input.Length; i++) {

                if (dic.ContainsKey(input[i])) {

                    frmPrincipal.TxtBoxOutput.Text += (dic[input[i]]);

                } else {

                    frmPrincipal.TxtBoxOutput.Text += input[i];
                }
               
            }//Find el for de DES/cifrado

        }//Fin de Atbash



/// /////////////////////////////////////////////////////////////////////////////////////////////////7
        
        private string RunCesarRotate(char[] input, int root) {

            string result = "";//Donde almacenaremos el resultado

            //Recorriendo el Array de caracteres (en el que convertimos todo el INPUT)
            for (int i = 0; i < input.Length; i++) {

                int intValue = input[i];//Cogemos el valor INT del char para Trabajar con el

                //Comprobamos si es una MAYÚSCULA
                if (intValue >= 65 && intValue <= 90) {

                    //Restamos la rotacion a el VALOR DEL CHAR correspondiente
                    int auxIntValue = intValue + root;

                    //Comprobamos si el resultado es menor o igual a 90 para poder insertar el caracter equivalente YA!
                    if (auxIntValue <= 90) {

                        result += (char)auxIntValue;//Agregamos el CHAR sustituido a el Resultado

                    //En caso de haber pasado los 90, volvemos al 65 con el restante seguimos sumando hasta llegar a su caracter correspondiente
                    } else {
                        //Restamos a el (Auxiliar) 90, y le restamos 1(porque lo situamos ya en el 65) para obtener cuanto nos queda por sumar y sumamos al 65(A) "la carga"
                        int charge = (auxIntValue - 90) - 1;
                        result += (char)(65 + charge);
                    }
                }//Fin del iF en caso de ser Mayuscula


                //Comprobamos si es una MINÚSCULA
                else if (intValue >= 97 && intValue <= 122) {

                    //Restamos la rotacion a el VALOR DEL CHAR correspondiente
                    int auxIntValue = intValue + root;

                    //Comprobamos si el resultado es menor o igual a 122 para poder insertar el caracter equivalente YA!
                    if (auxIntValue <= 122) {

                        result += (char)auxIntValue;//Agregamos el CHAR sustituido a el Resultado

                        //En caso de haber pasado los 122, volvemos al 97 con el restante seguimos sumando hasta llegar a su caracter correspondiente
                    } else {
                        //Restamos a el (Auxiliar) 122(z), y le restamos 1(porque lo situamos ya en el 97) para obtener cuanto nos queda por sumar y sumamos al 97(a) "la carga"
                        int charge = (auxIntValue - 122) - 1;
                        result += (char)(97 + charge);
                       
                    }
                }//Fin del ElseIf en caso de ser minuscula


                //Si es otr caracter.. pasamos y lo agregamos tal cual
                else {

                    result += input[i];
                }//Fin del if-else_if
            
            }//Fin del FOR

            return result;
    }//Fin de RunCesarRotate


    }//Fin del ModelCipherCesarAtbash


}//FIn
