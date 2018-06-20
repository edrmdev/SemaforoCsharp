using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SemaforoEquipo5
{
    public partial class frmPrincipal : Form
    {
        double dblSegundos = 0;
        Boolean blNorteSur = false;
        int intIntervaloAmarillo = 0;
        int intIntervaloVerde = 0;
        int intSegundos = 0;

        //Variable banderas
        bool blnParpadeoVerde = true;
        bool blnParpadeoAmarillo = true;
        bool semafAmarillos = true;

        public frmPrincipal()
        {
            InitializeComponent();
            rstSemaforos("Todos");
            redimenzionarImagenes();
            btnEncender.Enabled = false;
        }

        private void redimenzionarImagenes()
        {
            //Redimension de los pb rojos
            RegionDeImagen(pbSemARojo);
            RegionDeImagen(pbSemBRojo);
            RegionDeImagen(pbSemCRojo);
            RegionDeImagen(pbSemDRojo);
            //Redimension de los pb amarillos
            RegionDeImagen(pbSemAAmarillo);
            RegionDeImagen(pbSemBAmarillo);
            RegionDeImagen(pbSemCAmarillo);
            RegionDeImagen(pbSemDAmarillo);

            //Redimenzion de los verdes
            RegionDeImagen(pbSemAVerde);
            RegionDeImagen(pbSemBVerde);
            RegionDeImagen(pbSemCVerde);
            RegionDeImagen(pbSemDVerde);

        }

        private void RegionDeImagen(PictureBox pb)
        {
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pb.Width - 4, pb.Height - 4);
            Region rg = new Region(gp);
            pb.Region = rg;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
        }

        private void pbLeft_Click(object sender, EventArgs e)
        {

        }

        private void btnEncender_Click(object sender, EventArgs e)
        {
            if(txtIntervaloAm.Value !=0)
            {
                estadoInicial();
                prmContador.Start();
                blNorteSur = true;
            }
            else
            {
                MessageBox.Show("Ingrese valor en intervalo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rstSemaforos(string Semaf)
        {
            //Semaforo A///
            switch (Semaf)
            {
                case "Norte":
                    pbSemARojo.BackColor = Color.Gray;
                    pbSemAVerde.BackColor = Color.Gray;
                    pbSemAAmarillo.BackColor = Color.Gray;
                    break;
                case "Sur":
                    pbSemCAmarillo.BackColor = Color.Gray;
                    pbSemCVerde.BackColor = Color.Gray;
                    pbSemCRojo.BackColor = Color.Gray;
                    break;
                case "Este":
                    pbSemDAmarillo.BackColor = Color.Gray;
                    pbSemDRojo.BackColor = Color.Gray;
                    pbSemDVerde.BackColor = Color.Gray;
                    break;
                case "Oeste":
                    pbSemBVerde.BackColor = Color.Gray;
                    pbSemBRojo.BackColor = Color.Gray;
                    pbSemBAmarillo.BackColor = Color.Gray;
                    break;
                default:
                    //Norte
                    pbSemARojo.BackColor = Color.Gray;
                    pbSemAVerde.BackColor = Color.Gray;
                    pbSemAAmarillo.BackColor = Color.Gray;
                    //Sur
                    pbSemCAmarillo.BackColor = Color.Gray;
                    pbSemCVerde.BackColor = Color.Gray;
                    pbSemCRojo.BackColor = Color.Gray;
                    //Este
                    pbSemDAmarillo.BackColor = Color.Gray;
                    pbSemDRojo.BackColor = Color.Gray;
                    pbSemDVerde.BackColor = Color.Gray;
                    //Oeste
                    pbSemBVerde.BackColor = Color.Gray;
                    pbSemBRojo.BackColor = Color.Gray;
                    pbSemBAmarillo.BackColor = Color.Gray;
                    break;
            }
        }

        //Estado inicial de semaforo...
        private void estadoInicial()
        {
            pbSemAVerde.BackColor = Color.Lime;
            pbSemCVerde.BackColor = Color.Lime;
            pbSemBRojo.BackColor = Color.Red;
            pbSemDRojo.BackColor = Color.Red;
        }

        //Semaforos norte y sur...
        private void conteoNorteSur(int IntervaloVerde, int IntervaloAmarillo)
        {
            //VERDE FIJO
            if (dblSegundos <= IntervaloVerde)//<=10
            {
                lblSegundos.ForeColor = Color.Lime;
                //lblSegundos.Text = intSegundos.ToString();
                lblSegundos.Text = Convert.ToString(Math.Truncate(dblSegundos));
                //Sem verdes
                pbSemAVerde.BackColor = Color.Lime;//Norte
                pbSemCVerde.BackColor = Color.Lime;//Sur
                //Sem rojos.
                pbSemDRojo.BackColor = Color.Red;//Este
                pbSemBRojo.BackColor = Color.Red;//Oeste
                                                 //salida puerto paralelo.
                PuertoParalelo.Output(888, 33);
                return;
            }
            //VERDE PARPADEANTE
            if(dblSegundos >= (IntervaloVerde + .5) && dblSegundos <= ((IntervaloVerde + IntervaloAmarillo) + .5))
            {
                if (blnParpadeoVerde)
                {
                    lblSegundos.ForeColor = Color.Green;
                    lblSegundos.Text = "";
                    pbSemAVerde.BackColor = Color.Gray;
                    pbSemBVerde.BackColor = Color.Gray;
                    pbSemCVerde.BackColor = Color.Gray;
                    pbSemDVerde.BackColor = Color.Gray;

                    blnParpadeoVerde = false;

                    if (dblSegundos == ((IntervaloVerde + IntervaloAmarillo) + .5))//13.5
                    {
                        blnParpadeoVerde = true;
                    }

                    PuertoParalelo.Output(888, 32);

                    return;
                }
                else
                {
                    lblSegundos.ForeColor = Color.Green;
                    intSegundos = (int)dblSegundos - IntervaloVerde;
                    lblSegundos.Text = intSegundos.ToString();

                    pbSemAVerde.BackColor = Color.Lime;
                    pbSemCVerde.BackColor = Color.Lime;
                    pbSemDRojo.BackColor = Color.Red;
                    pbSemBRojo.BackColor = Color.Red;
                    //picSemaforoNorte.Image = Semaforo.Properties.Resources.NorteVerde;
                    //picSemaforoSur.Image = Semaforo.Properties.Resources.SurVerde;
                    //picSemaforoEste.Image = Semaforo.Properties.Resources.EsteRojo;
                    //picSemaforoOeste.Image = Semaforo.Properties.Resources.OesteRojo;

                    blnParpadeoVerde = true;

                    PuertoParalelo.Output(888, 33);

                    return;
                }
            }
                                 //10   +     3       = 13 + 1 = 14              seg <=  10 + 3 = 13 + 3 = 16
            if (dblSegundos >= ((IntervaloVerde + IntervaloAmarillo) + 1) && dblSegundos <= ((IntervaloVerde + IntervaloAmarillo) + 3))
            {
                lblSegundos.ForeColor = Color.Yellow;
                intSegundos = (int)Math.Truncate(dblSegundos) - (IntervaloVerde + IntervaloAmarillo);
                lblSegundos.Text = Convert.ToInt32(intSegundos).ToString();

                pbSemAAmarillo.BackColor = Color.Yellow;//Norte
                pbSemCAmarillo.BackColor = Color.Yellow;//Sur
                pbSemDRojo.BackColor = Color.Red;//Este
                pbSemBRojo.BackColor = Color.Red;//Oeste

                PuertoParalelo.Output(888, 34);

                return;
            }                //10             +     3   =  ((13 + 3) + 3.5) = 16.5
            if(dblSegundos == ((IntervaloVerde + IntervaloAmarillo) + 3.5)){
                lblSegundos.ForeColor = Color.Yellow;
                lblSegundos.Text = "";

                rstSemaforos("Norte");
                rstSemaforos("Sur");
                pbSemDRojo.BackColor = Color.Red;
                pbSemBRojo.BackColor = Color.Red;
                PuertoParalelo.Output(888, 32);

                return;
            }
            if (dblSegundos >= ((IntervaloVerde + IntervaloAmarillo) + 4) && dblSegundos <= ((IntervaloVerde + IntervaloAmarillo) + 5))
            {
                //intSegundos = 0;
                lblSegundos.ForeColor = Color.Red;
                intSegundos = (int)Math.Truncate(dblSegundos) - ((IntervaloAmarillo + IntervaloVerde) + 3);
                lblSegundos.Text = intSegundos.ToString();

                pbSemARojo.BackColor = Color.Red;
                pbSemBRojo.BackColor = Color.Red;
                pbSemCRojo.BackColor = Color.Red;
                pbSemDRojo.BackColor = Color.Red;
                PuertoParalelo.Output(888, 36);
              
                return;
            }

            if(dblSegundos >= ((IntervaloVerde + IntervaloAmarillo) + 5))
            {
                lblSegundos.ForeColor = Color.Red;
                lblSegundos.Text = "";//intSegundos.ToString();

                pbSemARojo.BackColor = Color.Red;
                pbSemCRojo.BackColor = Color.Red;
                rstSemaforos("Este");
                rstSemaforos("Oeste");

                dblSegundos = 0.5;
                blNorteSur = false;
                PuertoParalelo.Output(888, 4);
            }
        }

        private void conteoEsteOeste(int IntervaloVerde, int IntervaloAmarillo)
        {
            //VERDE FIJO
            if (dblSegundos <= IntervaloVerde)//<=10
            {
                lblSegundos.ForeColor = Color.Green;
                lblSegundos.Text = Convert.ToString(Math.Truncate(dblSegundos));
                //Sem verdes
                pbSemARojo.BackColor = Color.Red;//Norte
                pbSemCRojo.BackColor = Color.Red;//Sur
                //Sem rojos.
                pbSemDVerde.BackColor = Color.Lime;//Este
                pbSemBVerde.BackColor = Color.Lime;//Oeste
                                                 //salida puerto paralelo.
                PuertoParalelo.Output(888, 12);
               

                return;
            }
            //VERDE PARPADEANTE
            if (dblSegundos >= (IntervaloVerde + .5) && dblSegundos <= ((IntervaloVerde + IntervaloAmarillo) + .5))
            {
                if (blnParpadeoVerde)
                {
                    lblSegundos.ForeColor = Color.Green;
                    lblSegundos.Text = "";
                    
                    pbSemARojo.BackColor = Color.Red;
                    pbSemCRojo.BackColor = Color.Red;
                    rstSemaforos("Este"); //Apagamos el semaforo este...
                    rstSemaforos("Oeste");//Apagamos el semaforo oeste...
                    
                    blnParpadeoVerde = false;


                    if (dblSegundos == ((IntervaloVerde + IntervaloAmarillo) + .5))//13.5
                    {
                        blnParpadeoVerde = true;
                    }

                    PuertoParalelo.Output(888, 4);

                    return;
                }
                else
                {
                    lblSegundos.ForeColor = Color.Green;
                    intSegundos = (int)dblSegundos - IntervaloVerde;
                    lblSegundos.Text = intSegundos.ToString();

                    pbSemARojo.BackColor = Color.Red;
                    pbSemCRojo.BackColor = Color.Red;
                    pbSemDVerde.BackColor = Color.Lime;
                    pbSemBVerde.BackColor = Color.Lime;

                    blnParpadeoVerde = true;

                    PuertoParalelo.Output(888, 12);

                    return;
                }
            }
            
            //10   +     3       = 13 + 1 = 14              seg <=  10 + 3 = 13 + 3 = 16
            if (dblSegundos >= ((IntervaloVerde + IntervaloAmarillo) + 1) && dblSegundos <= ((IntervaloVerde + IntervaloAmarillo) + 3))
            {
                lblSegundos.ForeColor = Color.Yellow;
                intSegundos = (int)Math.Truncate(dblSegundos) - (IntervaloVerde + IntervaloAmarillo);
                lblSegundos.Text = intSegundos.ToString();

                pbSemARojo.BackColor = Color.Red;//Norte
                pbSemCRojo.BackColor = Color.Red;//Sur
                pbSemDAmarillo.BackColor = Color.Yellow;//Este
                pbSemBAmarillo.BackColor = Color.Yellow;//Oeste

                PuertoParalelo.Output(888, 20);

                return;
            }                 //10             +     3   =  ((13 + 3) + 3.5) = 16.5
            if (dblSegundos == ((IntervaloVerde + IntervaloAmarillo) + 3.5))
            {
                lblSegundos.ForeColor = Color.Yellow;
                lblSegundos.Text = "";
                //Norte y sur rojos
                pbSemARojo.BackColor = Color.Red;
                pbSemCRojo.BackColor = Color.Red;
                rstSemaforos("Este");
                rstSemaforos("Oeste");
                //PuertoParalelo.Output(888, 4);

                return;
            }
            if (dblSegundos >= ((IntervaloVerde + IntervaloAmarillo) + 4) && dblSegundos <= ((IntervaloVerde + IntervaloAmarillo) + 5))
            {
                lblSegundos.ForeColor = Color.Red;
                intSegundos = (int)Math.Truncate(dblSegundos) - ((IntervaloVerde + IntervaloAmarillo) + 3);
                lblSegundos.Text = intSegundos.ToString();

                pbSemARojo.BackColor = Color.Red;
                pbSemBRojo.BackColor = Color.Red;
                pbSemCRojo.BackColor = Color.Red;
                pbSemDRojo.BackColor = Color.Red;
                PuertoParalelo.Output(888, 36);

                return;
            }

            if (dblSegundos >= ((IntervaloVerde + IntervaloAmarillo) + 5))
            {
                lblSegundos.ForeColor = Color.Red;
                lblSegundos.Text = "";

                pbSemDRojo.BackColor = Color.Red;
                pbSemBRojo.BackColor = Color.Red;
                rstSemaforos("Norte");
                rstSemaforos("Sur");

                dblSegundos = 0.5;
                blNorteSur = true;

                PuertoParalelo.Output(888, 32);
            }
        }

        private void prmContador_Tick(object sender, EventArgs e)
        {
            if (blNorteSur)//Quiere decir que empezamos con nuestro conteo...
            {
                dblSegundos = dblSegundos + 0.5; //Se estara incrementando mientras este de norte a sur...
                conteoNorteSur(intIntervaloVerde, intIntervaloAmarillo);
            }
            else
            {
                dblSegundos = dblSegundos + 0.5;
                conteoEsteOeste(intIntervaloVerde, intIntervaloAmarillo);
            }

            //lblSegundos.Text = dblSegundos.ToString();
        }

        private void btnConfigurar_Click(object sender, EventArgs e)
        {
            intIntervaloVerde = int.Parse(txtIntervaloVer.Value.ToString());//asignamos los intervalos
            intIntervaloAmarillo = int.Parse(txtIntervaloAm.Value.ToString());
            if(intIntervaloVerde != 0 && intIntervaloAmarillo != 0)
            {
                MessageBox.Show("Se ha configurado el intervalo de tiempo.", "Correcto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnEncender.Enabled = true;
            }
            else
            {
                MessageBox.Show("Configure con valores distintos de 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnEncender.Enabled = false;
            }
        }

        private void btnIntermitentes_Click(object sender, EventArgs e)
        {
            if (semafAmarillos)
            {
                semafAmarillos = false;
                sgContador.Start();
                //BLPAmarillos = true;
                lblSegundos.ForeColor = Color.Yellow;
            }
            else
            {
                semafAmarillos = true;
                sgContador.Stop();
                rstSemaforos("Norte");
                rstSemaforos("Sur");
                rstSemaforos("Este");
                rstSemaforos("Oeste");
            }
        }

        private void sgContador_Tick(object sender, EventArgs e)
        {
            sgContador.Interval = 500;

            lblSegundos.ForeColor = Color.Yellow;
            if (blnParpadeoAmarillo)
            {
                lblSegundos.Text = "1";

                pbSemAAmarillo.BackColor = Color.Yellow;
                pbSemBAmarillo.BackColor = Color.Yellow;
                pbSemCAmarillo.BackColor = Color.Yellow;
                pbSemDAmarillo.BackColor = Color.Yellow;

                PuertoParalelo.Output(888, 18);
                blnParpadeoAmarillo = false;
            }
            else
            {
                lblSegundos.Text = "0";
                rstSemaforos("Norte");
                rstSemaforos("Sur");
                rstSemaforos("Este");
                rstSemaforos("Oeste");

                PuertoParalelo.Output(888, 0);
                blnParpadeoAmarillo = true;
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (txtIntervaloAm.Value != 0 || txtIntervaloVer.Value != 0)
            {
                prmContador.Stop();
                sgContador.Stop();
                rstSemaforos("Norte");
                rstSemaforos("Sur");
                rstSemaforos("Este");
                rstSemaforos("Oeste");
                lblSegundos.ForeColor = Color.Black;
                lblSegundos.Text = "Apagado";
                txtIntervaloVer.Value = 0;
                txtIntervaloAm.Value = 0;
                dblSegundos = 0;
                intSegundos = 0;
            }
            else
            {
                MessageBox.Show("No se han agregado valores de intervalos.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtIntervaloVer.Focus();
            }
        }
    }
}
