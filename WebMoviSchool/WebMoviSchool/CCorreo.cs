using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Mail;

namespace WebMoviSchool
{
    public class CCorreo
    {
        Boolean estado = true;
        String merror;

        public CCorreo(String destinatario,
            String asunto, String mensaje)
        {

            MailMessage correo = new MailMessage();
            SmtpClient protocolo = new SmtpClient();


            correo.To.Add(destinatario);
            correo.From = new MailAddress("RecuperarC.MoviSchool@gmail.com","Recuperacion Contraseña MOVISCHOOL", System.Text.Encoding.UTF8);
            correo.Subject = asunto;
            correo.SubjectEncoding = System.Text.Encoding.UTF8;

            correo.Body = mensaje;
            correo.BodyEncoding = System.Text.Encoding.UTF8;
            correo.IsBodyHtml = false;

            protocolo.Credentials = new System.Net.NetworkCredential("RecuperarC.MoviSchool@gmail.com", "movi159357");
            protocolo.Port = 587;
            protocolo.Host = "smtp.gmail.com";
            protocolo.EnableSsl = true;

            try
            {
                protocolo.Send(correo);
            }
            catch(SmtpException error)
            {
                estado = false;
                merror = error.Message.ToString();

            }


        }

        public Boolean Estado
        {
            get { return estado; }
        }

        public String mensaje_error
        {
            get { return merror; }
        }

    }
}