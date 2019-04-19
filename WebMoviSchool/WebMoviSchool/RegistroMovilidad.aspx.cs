using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Negocio;
using Capa_Entidad;
using System.Data;
using System.IO;
using System.Configuration;
using System.Drawing;
//using System.Windows.Forms;

namespace WebMoviSchool
{
    public partial class RegistroMovilidad : System.Web.UI.Page
    {
        negMovilidad negOMovilidad = new negMovilidad();
        negUsuario negUsuarios = new negUsuario();
        EntMovilidad usuar = new EntMovilidad();
        //String dniCOd;
        public void cargar_Cabecera()
        {
            
                List<EntMovilidad> login = new List<EntMovilidad>();

                //usuar.NombreAp = lblNombreApe.Text;
                //usuar.Celular = Celular.Text;
                //usuar.CorreoElec = lblCorreo.Text;
                
                login = negOMovilidad.SEL_USUARIOPANEL(Session["DNI"].ToString());

                if (login.Count == 0)
                {
                   // tipPersona = "0";
                }
                else
                {
                    
                 lblNombreApe.Text= login[0].NombreAp ;
                 Celular.Text= login[0].Celular ;
                 lblCorreo.Text= login[0].CorreoElec;

                }
            

    }

        protected void Page_Load(object sender, EventArgs e)
        {
            ////dniCOd = "47266222";
            //if (((string)Session["DNI"]) == "4")
            //{
            //    Response.Redirect("IndexPadre.aspx");
            //}
            //else if (((string)Session["ID_TIPOUSU"]) == "5")
            //{
            //    Response.Redirect("IndexMovilidad.aspx");
            //}
            //else
            //{

            //}
                       

            if (Session["DNI"] != null)
            {
                cargar_Cabecera();
            }else
            {
                Response.Redirect("index.aspx");
                // Response.Write("<script>window.alert('Debes ingresar tu usuario antes')");
            }


            if (!IsPostBack)
            {

                DataTable dt = negUsuarios.SEL_TIPODOC();
                cboTipDocumento.DataSource = dt;
                cboTipDocumento.DataValueField = "id";
                cboTipDocumento.DataTextField = "nom";
                cboTipDocumento.DataBind();

            }

            if (!IsPostBack)
            {

                DataTable dt1 = negUsuarios.SEL_PAIS();
                cboPais.DataSource = dt1;
                cboPais.DataValueField = "id";
                cboPais.DataTextField = "nom";
                cboPais.DataBind();

            }

            






        }

        protected void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codDepa = Convert.ToInt16(cboDepartamento.SelectedValue);
            DataTable dt = negUsuarios.SEL_DISTRITO(codDepa);
            cboDistrito.DataSource = dt;
            cboDistrito.DataValueField = "id";
            cboDistrito.DataTextField = "nom";
            cboDistrito.DataBind();
            cboDistrito.Items.Insert(0, new ListItem("--Ingrese un Distrito--","0"));
        }

        protected void cboPais_SelectedIndexChanged(object sender, EventArgs e)
        {
            int codPais = Convert.ToInt16(cboPais.SelectedValue);
            DataTable dt = negUsuarios.SEL_DEPARTAMENTO(codPais);
            cboDepartamento.DataSource = dt;
            cboDepartamento.DataValueField = "id";
            cboDepartamento.DataTextField = "nom";
            cboDepartamento.DataBind();
            cboDepartamento.Items.Insert(0, new ListItem("--Ingrese un Departamento--", "0"));
        }

        protected void cboDistrito_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                int codDistrito = Convert.ToInt16(cboDistrito.SelectedValue);
                DataTable dt2 = negOMovilidad.SEL_COLEGIO(codDistrito);
                cboColegio.DataSource = dt2;
                cboColegio.DataValueField = "id";
                cboColegio.DataTextField = "nom";
                cboColegio.DataBind();
                cboColegio.Items.Insert(0, new ListItem("--Ingrese un Colegio--", "0"));

            }
        }

        public System.Drawing.Image RedimencionarImagen(System.Drawing.Image ImagenOriginal, int Alto)
        {

            var Radio = (double)Alto / ImagenOriginal.Height;
            var NuevoAncho = (int)(ImagenOriginal.Width * Radio);
            var NuevoAlto = (int)(ImagenOriginal.Height * Radio);
            var NuevaImagenRedimencionada = new Bitmap(NuevoAncho, NuevoAlto);
            var g = Graphics.FromImage(NuevaImagenRedimencionada);
            g.DrawImage(ImagenOriginal, 0, 0, NuevoAncho, NuevoAlto);
            return NuevaImagenRedimencionada;

        }

        public System.Drawing.Image byteArrayToImage(byte[] byteArrayIn)
        {
            MemoryStream ms = new MemoryStream(byteArrayIn);
            System.Drawing.Image returnImage = System.Drawing.Image.FromStream(ms);
            return returnImage;
        }


        protected void Button1_Click(object sender, EventArgs e)
        {
            EntMovilidadRegistro oEntMovilidadReg = new EntMovilidadRegistro();
            HttpPostedFile postedFile = FileUpload1.PostedFile;

            string filaname = Path.GetFileName(postedFile.FileName);
            string fileExtension = Path.GetExtension(filaname);
            int fileSize = postedFile.ContentLength;

            
            HttpPostedFile postedFile2 = FileUploadRevtec.PostedFile;

            string filaname2 = Path.GetFileName(postedFile2.FileName);
            string fileExtension2 = Path.GetExtension(filaname2);
            int fileSize2 = postedFile2.ContentLength;

            HttpPostedFile postedFile3 = FileUploadFotoAuto.PostedFile;
            
            string filaname3 = Path.GetFileName(postedFile3.FileName);
            string fileExtension3 = Path.GetExtension(filaname3);
            int fileSize3 = postedFile3.ContentLength;

            if ((fileExtension.ToLower() == ".jpeg" || fileExtension.ToLower() == ".jpg" || fileExtension.ToLower() == ".bmp" ||
                fileExtension.ToLower() == ".gif" || fileExtension.ToLower() == ".png")
                && (fileExtension2.ToLower() == ".jpeg" || fileExtension2.ToLower() == ".jpg"  || fileExtension2.ToLower() == ".bmp" ||
                fileExtension2.ToLower() == ".gif" || fileExtension2.ToLower() == ".png")
                && (fileExtension3.ToLower() == ".jpeg" || fileExtension3.ToLower() == ".jpg" || fileExtension3.ToLower() == ".bmp" ||
                fileExtension3.ToLower() == ".gif" || fileExtension3.ToLower() == ".png"))
            {


                Stream stream = postedFile.InputStream;
                BinaryReader binaryReader = new BinaryReader(stream);

                byte[] bytes = binaryReader.ReadBytes((int)stream.Length);
                
                
                //Rev Tecnica
                Stream stream2 = postedFile2.InputStream;
                BinaryReader binaryReader2 = new BinaryReader(stream2);

                byte[] bytes2 = binaryReader2.ReadBytes((int)stream2.Length);

                // Foto auto 
                Stream stream3 = postedFile3.InputStream;
                BinaryReader binaryReader3 = new BinaryReader(stream3);

                byte[] bytes3 = binaryReader3.ReadBytes((int)stream3.Length);

                //// Conversion 

                System.Drawing.Image imtThumbnail;
                int TamanioThumbanail = 400;
                imtThumbnail = RedimencionarImagen(byteArrayToImage(bytes), TamanioThumbanail);


                System.Drawing.Image imtThumbnailRev;
                imtThumbnailRev = RedimencionarImagen(byteArrayToImage(bytes2),TamanioThumbanail);

                System.Drawing.Image imtThumbnailFotoAuto;
                imtThumbnailFotoAuto = RedimencionarImagen(byteArrayToImage(bytes3), TamanioThumbanail);


                byte[] bImagenThumbnail = new byte[TamanioThumbanail];
                ImageConverter Convertidor = new ImageConverter();
                bImagenThumbnail = (byte[])Convertidor.ConvertTo(imtThumbnail,typeof(byte[]));

                byte[] bImagenThumbnail2 = new byte[TamanioThumbanail];
                ImageConverter Convertidor2 = new ImageConverter();
                bImagenThumbnail2 = (byte[])Convertidor2.ConvertTo(imtThumbnailRev, typeof(byte[]));

                byte[] bImagenThumbnail3 = new byte[TamanioThumbanail];
                ImageConverter Convertidor3 = new ImageConverter();
                bImagenThumbnail3 = (byte[])Convertidor3.ConvertTo(imtThumbnailFotoAuto, typeof(byte[]));

                //string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                oEntMovilidadReg.NombreChofer = txtChofer.Text;
                oEntMovilidadReg.Idtipodocumento = Convert.ToInt16(cboTipDocumento.SelectedValue);
                oEntMovilidadReg.NroDocumento = txtNrDocumento.Text;
                oEntMovilidadReg.Telefono = txtTelefono.Text;
                oEntMovilidadReg.idColegio = Convert.ToInt16(cboColegio.SelectedValue);
                oEntMovilidadReg.Soat = bImagenThumbnail;
                oEntMovilidadReg.Placa = txtPlaca.Text;
                oEntMovilidadReg.RevTecnica = bImagenThumbnail2;
                oEntMovilidadReg.Marca = txtMarca.Text;
                oEntMovilidadReg.Modelo = txtModelo.Text;
                oEntMovilidadReg.Color = txtColor.Text;
                oEntMovilidadReg.Capacidad = Convert.ToInt16(txtCapacidad.Text);
                oEntMovilidadReg.FotoCarro = bImagenThumbnail3;
                oEntMovilidadReg.PapelRegla = 1;
                oEntMovilidadReg.Dni = Session["DNI"].ToString();

                negOMovilidad.INS_MOVILIDAD(oEntMovilidadReg, 1);

                // MessageBox.Show("Registro exitoso");

                Response.Write("<script>alert('Registro exitoso !!!!')</script>");

                Response.Redirect("RegistroMovilidad.aspx");

            }
            else
            {
                
                if((fileExtension.ToLower() != ".jpeg" || fileExtension.ToLower() != ".jpg" || fileExtension.ToLower() != ".bmp" ||
                fileExtension.ToLower() != ".gif" || fileExtension.ToLower() != ".png")
                && (fileExtension2.ToLower() != ".jpeg" || fileExtension2.ToLower() == ".jpg" || fileExtension2.ToLower() != ".bmp" ||
                fileExtension2.ToLower() != ".gif" || fileExtension2.ToLower() == ".png")
                && (fileExtension3.ToLower() != ".jpeg" || fileExtension3.ToLower() != ".jpg" || fileExtension3.ToLower() != ".bmp" ||
                fileExtension3.ToLower() != ".gif" || fileExtension3.ToLower() != ".png"))
                {
                    Response.Write("<script>alert('Solo puede usar .jpeg , .jpg, .bmp, .gif, .png o Ingrese todos los archivos Corresctamente')</script>");
                }
                else
                {
                    Response.Write("<script>alert('Complete todos los campos  !!!!')</script>");

                }

                
            }

        }
    }
}