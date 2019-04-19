using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Capa_Entidad;
using Capa_Negocio;

namespace WebMoviSchool
{
    public partial class RecuperarContraseña : System.Web.UI.Page
    {
        negUsuario objNegUsuario = new negUsuario();
        EntUsuario usuar = new EntUsuario();
        int codUsuario = 0;
        string passCon;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtCorreo.Text != "" )
            {
                List<EntUsuario> login = new List<EntUsuario>();

                usuar.CorreoElec = txtCorreo.Text;
               

                login = objNegUsuario.SEL_CORR_CONTRA(usuar.CorreoElec);

                if (login.Count == 0)
                {
                    codUsuario = 0;
                    

                    ///
                    Response.Write("<script>alert('Correo No encontrado !!!!')</script>");
                }
                else
                {
                    codUsuario = Convert.ToInt32(login[0].Codigo);
                   


                }
                

            }
            else
            {
                ///MessageBox.Show("Ingrese un usuario y password");
                Response.Write("<script>alert('Ingrese el Correo')</script>");
            }

            if (codUsuario != 0)
            {

                Random rnd = new Random();
                int month = rnd.Next(0, 9);  
                int dice = rnd.Next(0, 9);   
                int card = rnd.Next(0,9);
                int card1 = rnd.Next(0, 9);
                int card2 = rnd.Next(0, 9);
                int card3 = rnd.Next(0, 9);
                int card4 = rnd.Next(0, 9);
                int card5 = rnd.Next(0, 9);

                passCon = Convert.ToString(month) + Convert.ToString(dice) + Convert.ToString(card) + Convert.ToString(card1) +
                    Convert.ToString(card2) + Convert.ToString(card3) + Convert.ToString(card4) + Convert.ToString(card5);



                CCorreo ObjCorreo = new CCorreo(usuar.CorreoElec, "Restablecer Contraseña", "Su Nueva Contraseña enviada" +
                    "por Su Aplicativo es la Siguiente : " +" "+ passCon +" " + " ..WEB RENZO PARRAGA HUAPAYA");
                if (ObjCorreo.Estado)
                {
                    objNegUsuario.UPD_CAMB_PW(codUsuario, passCon);
                    Response.Write("Se Envio el Correo Correctamente");
                }
                else
                {
                    Response.Write("Error al enviar correo electronico Verifique _____ <br>" + ObjCorreo.mensaje_error);
                }

            }

            
        }
    }
}