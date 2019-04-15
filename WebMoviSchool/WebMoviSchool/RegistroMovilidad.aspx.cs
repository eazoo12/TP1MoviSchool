﻿using System;
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
                    //tipPersona = Convert.ToString(login[0].TipoUsuario);
                //usuar.NombreAp = lblNombreApe.Text;
                //usuar.Celular = Celular.Text;
                //usuar.CorreoElec = lblCorreo.Text;
                 lblNombreApe.Text= login[0].NombreAp ;
                 Celular.Text= login[0].Celular ;
                 lblCorreo.Text= login[0].CorreoElec;
                }
            //Session["ID_TIPOUSU"] = tipPersona;
            //    if (tipPersona == "4")
            //    {

            //        Response.Redirect("IndexPadre.aspx", false);
            //    }
            //    else if (tipPersona == "5")
            //    {
            //        Response.Redirect("IndexMovilidad.aspx", false);
            //    }

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


            if ((fileExtension.ToLower() == ".jpeg" || fileExtension.ToLower() == ".bmp" ||
                fileExtension.ToLower() == ".gif" || fileExtension.ToLower() == ".png")
                && (fileExtension2.ToLower() == ".jpeg" || fileExtension2.ToLower() == ".bmp" ||
                fileExtension2.ToLower() == ".gif" || fileExtension2.ToLower() == ".png"))
            {
                Stream stream = postedFile.InputStream;
                BinaryReader binaryReader = new BinaryReader(stream);

                byte[] bytes = binaryReader.ReadBytes((int)stream.Length);
                //Rev Tecnica
                Stream stream2 = postedFile2.InputStream;
                BinaryReader binaryReader2 = new BinaryReader(stream2);

                byte[] bytes2 = binaryReader2.ReadBytes((int)stream2.Length);


                //string cs = ConfigurationManager.ConnectionStrings["DBCS"].ConnectionString;
                oEntMovilidadReg.NombreChofer = txtChofer.Text;
                oEntMovilidadReg.Idtipodocumento = Convert.ToInt16(cboTipDocumento.SelectedValue);
                oEntMovilidadReg.NroDocumento = txtNrDocumento.Text;
                oEntMovilidadReg.Telefono = txtTelefono.Text;
                oEntMovilidadReg.idColegio = Convert.ToInt16(cboColegio.SelectedValue);
                oEntMovilidadReg.Soat = bytes;
                oEntMovilidadReg.Placa = txtPlaca.Text;
                oEntMovilidadReg.RevTecnica = bytes2;
                oEntMovilidadReg.Marca = txtMarca.Text;
                oEntMovilidadReg.Modelo = txtModelo.Text;
                oEntMovilidadReg.Color = txtColor.Text;
                oEntMovilidadReg.Capacidad = Convert.ToInt16(txtCapacidad.Text);
                oEntMovilidadReg.FotoCarro = bytes;
                oEntMovilidadReg.PapelRegla = 1;
                oEntMovilidadReg.Dni = Session["DNI"].ToString();

                negOMovilidad.INS_MOVILIDAD(oEntMovilidadReg, 1);

                // MessageBox.Show("Registro exitoso");

                Response.Write("<script>alert('Registro exitoso !!!!')</script>");

                Response.Redirect("RegistroMovilidad.aspx");

            }
            else
            {
                //MessageBox.Show("Complete todos los campos");
                Response.Write("<script>alert('Complete todos los campos !!!!')</script>");
            }

        }
    }
}