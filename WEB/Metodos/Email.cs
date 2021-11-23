using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Mail;
using DTO;

namespace WEB.Metodos
{
    public class Email
    {
        #region EmailContato
        public bool EmailContato(DTO.HomeContato homeContato)
        {
            try
            {
                // SETANDDO E-MAIL PERFIL RESPONSAVEL
                var bll = new BLL.Sistema();
                var sistemaEmailCredenciais = new SistemaEmailCredenciais();
                sistemaEmailCredenciais = bll.sistemaEmailCredenciais("CON");

                // CONFIGURAÇÃO CORPO DO E-MAIL
                var mailMessage = new MailMessage();
                mailMessage.To.Add(new MailAddress("wagner.fornielis@gmail.com"));
                mailMessage.To.Add(new MailAddress("wilson.fornielis@gmail.com"));
                mailMessage.From = new MailAddress(sistemaEmailCredenciais.Email, "Contato | badisco.online");
                mailMessage.Subject = "Mensagem: " + homeContato.Nome;
                mailMessage.IsBodyHtml = true;

                mailMessage.Body =
                "<b>Contato enviado através do site.</b><br/><hr>" +
                "<b>Nome: </b>" + homeContato.Nome + "<br/><hr>" +
                "<b>E-mail: </b>" + homeContato.Email + "<br /><hr>" +
                "<b>Mensagem: </b>" + homeContato.Mensagem + "<br /><hr>" +
                sistemaEmailCredenciais.Codigo;

                // CONFIGURAÇÃO PARA ENVIO
                var smtpCliente = new SmtpClient("smtp.gmail.com", 587);
                smtpCliente.Credentials = new NetworkCredential(sistemaEmailCredenciais.Email, sistemaEmailCredenciais.Senha);
                smtpCliente.EnableSsl = true;
                smtpCliente.Send(mailMessage);

                // VARIÁVEL DE RETORNO
                bool retorno = true;
                return retorno;
            }
            catch (Exception)
            {
                // VARIÁVEL DE RETORNO
                bool retorno = false;
                return retorno;
            }
        }
        #endregion
    }
}