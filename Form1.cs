using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace ProyectoU5IgnacioCasillas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        FileStream fs;
        StreamReader sr;
        string[] campos = new string[11];
        char[] separador = { ',' };

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void lblFechaModificacion_Click(object sender, EventArgs e)
        {

        }

        private void btnAbrir_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                datagridview1.Visible = true;
                string ubicacion = openFileDialog1.FileName;
                lblUbicacion.Text = "Ubicacion del archivo \r\n" + openFileDialog1.FileName;
                lblFechaCreacion.Text = "Fecha de creacion: \r\n" + File.GetCreationTime(ubicacion).ToString();
                lblFechaModificacion.Text = "Fecha de ultima modificacion: \r\n" + File.GetLastWriteTime(ubicacion).ToString();
                lblFechaUltimoAcceso.Text = "Fecha de ultimo acceso: \r\n" + File.GetLastAccessTime(ubicacion).ToString();

                fs = new FileStream(ubicacion, FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                string linea = sr.ReadLine();
                int contadorfilas = 0;
                int contadorstarters = 0;
                int contadorwatchers = 0;
                int contadorcompleters = 0;
                int contadorSiTerminan = 0;
                int contadorNoTerminan = 0;
                int contadorSerie = 0;
                int contadorPelicula = 0;
                int contadorRomance = 0;
                int contadorDrama = 0;
                int contadorTerror = 0;
                int contadorAccion = 0;
                int contadorSuspenso = 0;
                int contador2020 = 0;
                int contador2021 = 0;
                int contador2022 = 0;
                int contador2023 = 0;
                int contadorMexico = 0;
                int contadorEU = 0;
                int contadorCanada = 0;
                int contadorColombia = 0;
                int contadorCuba = 0;
                int contadorCostaRica = 0;
                int contadorInvitacion = 0;
                int contadorFreedom = 0;
                int contadorNOP = 0;
                int contadorPacifiction = 0;
                int contadorBridgerton = 0;
                int contadorStranger = 0;
                int contadorNorthMan = 0;
                int contadorDropuot = 0;
                int contadorCalamar = 0;
                while (linea != null)
                {
                    campos = linea.Split(separador);
                    datagridview1.Rows.Add(campos[0], campos[1], campos[2], campos[3], campos[4], campos[5], campos[6], campos[7], campos[8], campos[9], campos[10]);
                    linea = sr.ReadLine();
                    contadorfilas++;
                }
                double[] resultados = new double[contadorfilas];
                for (int i = 0; i <= contadorfilas -1 ; i++)
                {
                    resultados[i] = ((Convert.ToDouble(datagridview1.Rows[i].Cells[10].Value) / Convert.ToDouble(datagridview1.Rows[i].Cells[9].Value) * 100));
                    if (resultados[i] <= 10)
                        contadorstarters++;
                    else if (resultados[i] < 90)
                        contadorwatchers++;
                    else if (resultados[i] <= 100)
                        contadorcompleters++;

                    if (Convert.ToDouble(datagridview1.Rows[i].Cells[10].Value) == Convert.ToDouble(datagridview1.Rows[i].Cells[9].Value))
                        contadorSiTerminan++;
                    if (Convert.ToDouble(datagridview1.Rows[i].Cells[10].Value) != Convert.ToDouble(datagridview1.Rows[i].Cells[9].Value))
                        contadorNoTerminan++;
                    if (datagridview1.Rows[i].Cells[4].Value.ToString() == "PELICULA")
                        contadorPelicula++;
                    else if (datagridview1.Rows[i].Cells[4].Value.ToString() == "SERIE")
                        contadorSerie++;

                    if (datagridview1.Rows[i].Cells[6].Value.ToString() == "ROMANCE")
                        contadorRomance++;
                    else if (datagridview1.Rows[i].Cells[6].Value.ToString() == "DRAMA")
                        contadorDrama++;
                    else if (datagridview1.Rows[i].Cells[6].Value.ToString() == "TERROR")
                        contadorTerror++;
                    else if (datagridview1.Rows[i].Cells[6].Value.ToString() == "ACCION")
                        contadorAccion++;
                    else if (datagridview1.Rows[i].Cells[6].Value.ToString() == "SUSPENSO")
                        contadorSuspenso++;

                    if (datagridview1.Rows[i].Cells[5].Value.ToString() == "2020")
                        contador2020++;
                    else if (datagridview1.Rows[i].Cells[5].Value.ToString() == "2021")
                        contador2021++;
                    else if (datagridview1.Rows[i].Cells[5].Value.ToString() == "2022")
                        contador2022++;
                    else if (datagridview1.Rows[i].Cells[5].Value.ToString() == "2023")
                        contador2023++;

                    if (datagridview1.Rows[i].Cells[2].Value.ToString() == "MEXICO")
                        contadorMexico++;
                    else if (datagridview1.Rows[i].Cells[2].Value.ToString() == "EU")
                        contadorEU++;
                    else if (datagridview1.Rows[i].Cells[2].Value.ToString() == "CANADA")
                        contadorCanada++;
                    else if (datagridview1.Rows[i].Cells[2].Value.ToString() == "CUBA")
                        contadorCuba++;
                    else if (datagridview1.Rows[i].Cells[2].Value.ToString() == "COLOMBIA")
                        contadorColombia++;
                    else if (datagridview1.Rows[i].Cells[2].Value.ToString() == "COSTA RICA")
                        contadorCostaRica++;
                    if (datagridview1.Rows[i].Cells[3].Value.ToString() == "LA INVITACION")
                        contadorInvitacion++;
                    else if (datagridview1.Rows[i].Cells[3].Value.ToString() == "GREAT FREEDOM")
                        contadorFreedom++;
                    else if (datagridview1.Rows[i].Cells[3].Value.ToString() == "NOP")
                        contadorNOP++;
                    else if (datagridview1.Rows[i].Cells[3].Value.ToString() == "PACIFICTION")
                        contadorPacifiction++;
                    else if (datagridview1.Rows[i].Cells[3].Value.ToString() == "LOS BRIDGERTON")
                        contadorBridgerton++;
                    else if (datagridview1.Rows[i].Cells[3].Value.ToString() == "STRANGER THINGS")
                        contadorStranger++;
                    else if (datagridview1.Rows[i].Cells[3].Value.ToString() == "THE NORTHMAN")
                        contadorNorthMan++;
                    else if (datagridview1.Rows[i].Cells[3].Value.ToString() == "THE DROPOUT")
                        contadorDropuot++;
                    else if (datagridview1.Rows[i].Cells[3].Value.ToString() == "EL JUEGO DEL CALAMAR")
                        contadorCalamar++;
                }
                //IncisoA
                lbltotalUsuarios.Text = contadorfilas.ToString();
                lblPorcentTotal.Text = ((double)contadorfilas / contadorfilas * 100).ToString()+"%";
                lblNoStarters.Text = contadorstarters.ToString();
                lblPorcentStarters.Text = ((double)contadorstarters / contadorfilas * 100).ToString() + "%";
                lblNoWatchers.Text = contadorwatchers.ToString();
                lblPorcentWatchers.Text = ((double)contadorwatchers / contadorfilas * 100).ToString() + "%";
                lblNoCompleters.Text = contadorcompleters.ToString();
                lblPorcentCompleters.Text = ((double)contadorcompleters / contadorfilas * 100).ToString() + "%";
                //IncisoB
                TotalUsuarios2.Text = contadorfilas.ToString();
                lblPorcentTotal2.Text = ((double)contadorfilas / contadorfilas * 100).ToString()+"%";
                lblSiTerminan.Text = contadorSiTerminan.ToString();
                lblPorcentSiTerminan.Text = ((double)contadorSiTerminan / contadorfilas * 100).ToString()+"%";
                lblNoTerminan.Text = contadorNoTerminan.ToString();
                lblPorcentNoTerminan.Text = ((double)contadorNoTerminan / contadorfilas * 100).ToString()+"%";
                //IncisoC
                Total3.Text = contadorfilas.ToString();
                PorcentTotal3.Text = ((double)contadorfilas / contadorfilas * 100).ToString()+"%";
                TotalVenPeliculas.Text = contadorPelicula.ToString();
                PorcentVenPeliculas.Text = ((double)contadorPelicula / contadorfilas * 100).ToString()+"%";
                TotalVenSeries.Text = contadorSerie.ToString();
                PorcentVenSeries.Text = ((double)contadorSerie / contadorfilas * 100).ToString()+"%";
                //IncisoD
                TotalUsuarios4.Text = contadorfilas.ToString();
                PorcentTotal4.Text = ((double)contadorfilas / contadorfilas * 100).ToString()+"%";
                TotalesRomance.Text = contadorRomance.ToString();
                PorcentRomace.Text = ((double)contadorRomance / contadorfilas * 100).ToString()+"%";
                TotalesDrama.Text = contadorDrama.ToString();
                PorcentDrama.Text = ((double)contadorDrama / contadorfilas * 100).ToString()+"%";
                TotalesTerror.Text = contadorTerror.ToString();
                PorcentTerror.Text = ((double)contadorTerror / contadorfilas * 100).ToString()+"%";
                TotalesAccion.Text = contadorAccion.ToString();
                PorcentAccion.Text = ((double)contadorAccion / contadorfilas * 100).ToString()+"%";
                TotalesSuspenso.Text = contadorSuspenso.ToString();
                PorcentSuspenso.Text = ((double)contadorSuspenso / contadorfilas * 100).ToString()+"%";
                //IncisoE
                Total2020.Text = contador2020.ToString();
                Total2021.Text = contador2021.ToString();
                Total2022.Text = contador2022.ToString();
                Total2023.Text = contador2023.ToString();
                //IncisoF
                PeliculaMasPopular.Text = PeliculaPopular(contadorInvitacion, contadorFreedom, contadorNOP, contadorPacifiction,contadorNorthMan);
                //IncisoG
                SerieMasPopular.Text = SeriePopular(contadorBridgerton, contadorStranger, contadorDropuot, contadorCalamar);
                //IncisoH
                PaisMasPopular.Text = PaisPopular(contadorMexico, contadorEU, contadorCanada, contadorCuba, contadorColombia,contadorCostaRica);
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        public string SeriePopular(int contadorBridgerton, int contadorStranger, int contadorDropout, int contadorCalamar)
        {
            int valormaximo = contadorBridgerton;

            if (contadorBridgerton > valormaximo)
                valormaximo = contadorBridgerton;
            if (contadorCalamar > valormaximo)
                valormaximo = contadorCalamar;
            if (contadorDropout > valormaximo)
                valormaximo = contadorDropout;
            if (contadorStranger > valormaximo)
                valormaximo = contadorStranger;
            string serieMasPopular = "";
            if (valormaximo == contadorBridgerton)
                serieMasPopular = " Los Bridgerton";
            else if (valormaximo == contadorCalamar)
                serieMasPopular = "Juego Del Calamar";
            else if (valormaximo == contadorDropout)
                serieMasPopular = "Dropuot";
            else if (valormaximo == contadorStranger)
                serieMasPopular = "Stranger Things";
            return serieMasPopular;
        }
        public string PeliculaPopular(int contadorInvitacion, int contadorFreedom, int contadorNOP, int contadorPacifiction,int contadorNorthMan)
        {
            int maxContador = contadorInvitacion;

            if (contadorFreedom > maxContador)
                maxContador = contadorFreedom;
            if (contadorNOP > maxContador)
                maxContador = contadorNOP;
            if (contadorPacifiction > maxContador)
                maxContador = contadorPacifiction;
            if (contadorNorthMan > maxContador)
                maxContador = contadorNorthMan;

            string PeliculaMasPopular = "";
            if (maxContador == contadorInvitacion)
                PeliculaMasPopular = " La Invitacion";
            else if (maxContador == contadorFreedom)
                PeliculaMasPopular = "Great Freedom";
            else if (maxContador == contadorNOP)
                PeliculaMasPopular = "NOP";
            else if (maxContador == contadorPacifiction)
                PeliculaMasPopular = "Pacifiction";
            else if (maxContador == contadorNorthMan)
                PeliculaMasPopular = "The NorthMan";
            return PeliculaMasPopular;
        }
        public string PaisPopular(int contadorMexico, int contadorEU, int contadorCanada, int contadorCuba, int contadorColombia,int contadorCostaRica)
        {
            int valorMaximo = contadorMexico;

            if (contadorMexico > valorMaximo)
                valorMaximo = contadorMexico;
            if (contadorEU > valorMaximo)
                valorMaximo = contadorEU;
            if (contadorCanada > valorMaximo)
                valorMaximo = contadorCanada;
            if (contadorCuba > valorMaximo)
                valorMaximo = contadorCuba;
            if (contadorColombia > valorMaximo)
                valorMaximo = contadorColombia;
            if (contadorCostaRica > valorMaximo)
                valorMaximo = contadorCostaRica;
            string pais = "";
            if (contadorMexico == valorMaximo)
                pais = "Mexico";
            else if (contadorEU == valorMaximo)
                pais = "EU";
            else if (contadorCanada == valorMaximo)
                pais = "Canada";
            else if (contadorCuba == valorMaximo)
                pais = "Cuba";
            else if (contadorColombia == valorMaximo)
                pais = "Colombia";
            else if (contadorCostaRica == valorMaximo)
                pais = "Costa Rica";
            return pais;
        }

        private void label66_Click(object sender, EventArgs e)
        {

        }

        private void IncisoB_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Point DireccionBuena = new Point(12, 375);
            Point DireccionA = new Point(12,94);
            Point DireccionB = new Point(12, 227);
            Point DireccionC = new Point(276, 94);
            Point DireccionD = new Point(276, 227);
            Point DireccionE = new Point(547, 94);
            Point DireccionF = new Point(796, 228);
            Point DireccionG = new Point(721, 94);
            Point DireccionH = new Point(721, 159);

            
            if (rbtIncisoA.Checked == true)
            {
                IncisoA.Location = DireccionBuena; IncisoB.Location = DireccionB; IncisoC.Location = DireccionC; IncisoD.Location = DireccionD; IncisoE.Location = DireccionE; IncisoF.Location = DireccionF; IncisoG.Location = DireccionG; IncisoH.Location = DireccionH;
                IncisoA.Visible = true; IncisoB.Visible = false; IncisoC.Visible = false; IncisoD.Visible = false; IncisoE.Visible = false; IncisoF.Visible = false; IncisoG.Visible = false; IncisoH.Visible = false;
            }
            if (rbtIncisoB.Checked == true)
            {
                IncisoA.Location = DireccionA; IncisoB.Location = DireccionBuena; IncisoC.Location = DireccionC; IncisoD.Location = DireccionD; IncisoE.Location = DireccionE; IncisoF.Location = DireccionF; IncisoG.Location = DireccionG; IncisoH.Location = DireccionH;
                IncisoA.Visible = false; IncisoB.Visible = true; IncisoC.Visible = false; IncisoD.Visible = false; IncisoE.Visible = false; IncisoF.Visible = false; IncisoG.Visible = false; IncisoH.Visible = false;
            }
            if (rbtIncisoC.Checked == true)
            {
                IncisoA.Location = DireccionA; IncisoB.Location = DireccionB; IncisoC.Location = DireccionBuena; IncisoD.Location = DireccionD; IncisoE.Location = DireccionE; IncisoF.Location = DireccionF; IncisoG.Location = DireccionG; IncisoH.Location = DireccionH;
                IncisoA.Visible = false; IncisoB.Visible = false; IncisoC.Visible = true; IncisoD.Visible = false; IncisoE.Visible = false; IncisoF.Visible = false; IncisoG.Visible = false; IncisoH.Visible = false;
            }
            if (rbtIncisoD.Checked == true)
            {
                IncisoA.Location = DireccionA; IncisoB.Location = DireccionB; IncisoC.Location = DireccionC; IncisoD.Location = DireccionBuena; IncisoE.Location = DireccionE; IncisoF.Location = DireccionF; IncisoG.Location = DireccionG; IncisoH.Location = DireccionH;
                IncisoA.Visible = false; IncisoB.Visible = false; IncisoC.Visible = false; IncisoD.Visible = true; IncisoE.Visible = false; IncisoF.Visible = false; IncisoG.Visible = false; IncisoH.Visible = false;
            }
            if (rbtIncisoE.Checked == true)
            {
                IncisoA.Location = DireccionA; IncisoB.Location = DireccionB; IncisoC.Location = DireccionC; IncisoD.Location = DireccionD; IncisoE.Location = DireccionBuena; IncisoF.Location = DireccionF; IncisoG.Location = DireccionG; IncisoH.Location = DireccionH;
                IncisoA.Visible = false; IncisoB.Visible = false; IncisoC.Visible = false; IncisoD.Visible = false; IncisoE.Visible = true; IncisoF.Visible = false; IncisoG.Visible = false; IncisoH.Visible = false;
            }
            if (rbtIncisoF.Checked == true)
            {
                IncisoA.Location = DireccionA; IncisoB.Location = DireccionB; IncisoC.Location = DireccionC; IncisoD.Location = DireccionD; IncisoE.Location = DireccionE; IncisoF.Location = DireccionBuena; IncisoG.Location = DireccionG; IncisoH.Location = DireccionH;
                IncisoA.Visible = false; IncisoB.Visible = false; IncisoC.Visible = false; IncisoD.Visible = false; IncisoE.Visible = false; IncisoF.Visible = true; IncisoG.Visible = false; IncisoH.Visible = false;
            }
            if (rbtIncisoG.Checked == true)
            {
                IncisoA.Location = DireccionA; IncisoB.Location = DireccionB; IncisoC.Location = DireccionC; IncisoD.Location = DireccionD; IncisoE.Location = DireccionE; IncisoF.Location = DireccionF; IncisoG.Location = DireccionBuena; IncisoH.Location = DireccionH;
                IncisoA.Visible = false; IncisoB.Visible = false; IncisoC.Visible = false; IncisoD.Visible = false; IncisoE.Visible = false; IncisoF.Visible = false; IncisoG.Visible = true; IncisoH.Visible = false;
            }
            if (rbtIncisoH.Checked == true)
            {
                IncisoA.Location = DireccionA; IncisoB.Location = DireccionB; IncisoC.Location = DireccionC; IncisoD.Location = DireccionD; IncisoE.Location = DireccionE; IncisoF.Location = DireccionF; IncisoG.Location = DireccionG; IncisoH.Location = DireccionBuena;
                IncisoA.Visible = false; IncisoB.Visible = false; IncisoC.Visible = false; IncisoD.Visible = false; IncisoE.Visible = false; IncisoF.Visible = false; IncisoG.Visible = false; IncisoH.Visible = true;
            }


        }
    }
}
