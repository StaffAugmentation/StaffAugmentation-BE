using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Net.Mime;
//using StaffAugmentation.Security.Types;
//using StaffAugmentation.Security.Connexions;
using System.IO;

namespace Shared.Utility;
public class SendEmail
{
    //public static void SendEmailTo(string mailFrom, string mailTo, string subjectText, string bodyText)
    //{
    //    try
    //    {
    //        SmtpClient SmtpServer = new SmtpClient();
    //        MailMessage mail = new MailMessage();
    //        SmtpServer.Credentials = new NetworkCredential(mailFrom, "Staff(2017);");
    //        SmtpServer.Port = 587;
    //        SmtpServer.Host = "smtp.gmail.com";
    //        SmtpServer.EnableSsl = true;
    //        mail = new MailMessage();
    //        mail.From = new MailAddress(mailFrom);
    //        mail.To.Add(mailTo);
    //        mail.Subject = subjectText;
    //        mail.Body = bodyText;
    //        using (AlternateView alternate = AlternateView.CreateAlternateViewFromString(bodyText, Encoding.UTF8, MediaTypeNames.Text.Html))
    //        {
    //            mail.AlternateViews.Add(alternate);
    //            mail.IsBodyHtml = true;
    //            mail.BodyEncoding = Encoding.UTF8;
    //            SmtpServer.Send(mail);
    //        }

    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}

    //public static void SendEmailTo2(string mailFrom, string mailTo, string subjectText, string bodyText)
    //{
    //    try
    //    {
    //        MailMessage message = new MailMessage();
    //        SmtpClient SmtpServer = new SmtpClient("smtp-mail.outlook.com");
    //        message.From = new MailAddress(mailFrom);
    //        message.To.Add(mailTo);
    //        message.Subject = subjectText;
    //        message.Body = bodyText;
    //        SmtpServer.Port = 587;
    //        SmtpServer.Credentials = new System.Net.NetworkCredential("rob_hcheouat@emeal.nttdata.com", "MghQ7892389");
    //        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
    //        SmtpServer.EnableSsl = true;
    //        using (AlternateView alternate = AlternateView.CreateAlternateViewFromString(bodyText, Encoding.UTF8, MediaTypeNames.Text.Html))
    //        {
    //            message.AlternateViews.Add(alternate);
    //            message.IsBodyHtml = true;
    //            message.BodyEncoding = Encoding.UTF8;
    //            SmtpServer.Send(message);
    //        }





    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }






    //}
    //public static void SendEmailTo3(string mailFrom, string mailTo, string subjectText, string bodyText, string cc)
    //{
    //    try
    //    {
    //        MailMessage message = new MailMessage();
    //        SmtpClient SmtpServer = new SmtpClient("smtp-mail.outlook.com");
    //        message.From = new MailAddress(mailFrom);
    //        string[] listTo = mailTo.Split(';');
    //        foreach (string toEmail in listTo)
    //        {
    //            message.To.Add(new MailAddress(toEmail.TrimStart().TrimEnd())); //Adding Multiple To emails 
    //        }
    //        if (cc != null)
    //        {
    //            string[] listCC = cc.Split(';');
    //            foreach (string CCEmail in listCC)
    //            {
    //                message.CC.Add(new MailAddress(CCEmail.TrimStart().TrimEnd())); //Adding Multiple CC emails 
    //            }
    //        }
    //        if (bodyText == null)
    //        {
    //            bodyText = "";
    //        }
    //        message.Subject = subjectText;
    //        message.Body = bodyText;
    //        SmtpServer.Port = 587;
    //        SmtpServer.Credentials = new System.Net.NetworkCredential("rob_hcheouat@emeal.nttdata.com", "MghQ7892389");
    //        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
    //        SmtpServer.EnableSsl = true;
    //        using (AlternateView alternate = AlternateView.CreateAlternateViewFromString(bodyText, Encoding.UTF8, MediaTypeNames.Text.Html))
    //        {
    //            message.AlternateViews.Add(alternate);
    //            message.IsBodyHtml = true;
    //            message.BodyEncoding = Encoding.UTF8;
    //            SmtpServer.Send(message);
    //        }
    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}
    //public static void SendEmail_User(string mailFrom, string mailTo, string subjectText, string bodyText)
    //{
    //    try
    //    {
    //        MailMessage message = new MailMessage();
    //        SmtpClient SmtpServer = new SmtpClient("smtp-mail.outlook.com");
    //        message.From = new MailAddress(mailFrom);
    //        message.To.Add(mailTo);
    //        message.Subject = subjectText;
    //        message.Body = bodyText;
    //        SmtpServer.Port = 587;
    //        //Staff(@2017); ;
    //        SmtpServer.Credentials = new System.Net.NetworkCredential("rob_hcheouat@emeal.nttdata.com", "MghQ7892389");
    //        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
    //        SmtpServer.EnableSsl = true;
    //        using (AlternateView alternate = AlternateView.CreateAlternateViewFromString(bodyText, Encoding.UTF8, MediaTypeNames.Text.Html))
    //        {
    //            message.AlternateViews.Add(alternate);
    //            message.IsBodyHtml = true;
    //            message.BodyEncoding = Encoding.UTF8;
    //            SmtpServer.Send(message);
    //        }





    //    }
    //    catch (Exception)
    //    {
    //        throw;
    //    }






    //}
    //public static void sendToPartner(string mailFrom, string mailTo, string subjectText, string bodyText, string cc, List<string> attachment, List<byte[]> attachmentByte)
    //{
    //    try
    //    {

    //        MailMessage message = new MailMessage();
    //        SmtpClient SmtpServer = new SmtpClient("smtp-mail.outlook.com");
    //        message.From = new MailAddress(mailFrom);
    //        if (bodyText == null)
    //        {
    //            bodyText = "";
    //        }
    //        message.Subject = subjectText;
    //        message.Body = bodyText;
    //        //Destinators List
    //        string[] Destinators = mailTo.Split(';');
    //        foreach (string toEmail in Destinators)
    //        {
    //            message.To.Add(new MailAddress(toEmail.TrimStart().TrimEnd()));
    //        }
    //        // CC List
    //        if (cc != null)
    //        {
    //            string[] listCC = cc.Split(';');
    //            foreach (string CCEmail in listCC)
    //            {
    //                message.CC.Add(new MailAddress(CCEmail.TrimStart().TrimEnd()));
    //            }
    //        }
    //        // attachment List
    //        if (attachmentByte != null && attachment != null)
    //            for (int j = 0; j < attachmentByte.Count; j++)
    //            {
    //                MemoryStream ms = new MemoryStream(attachmentByte[j]);
    //                string[] fileName = attachment[j].Split('\\');
    //                Attachment attachments = new Attachment(ms, fileName[fileName.Length - 1]);
    //                if (attachments.ContentStream.Length != 0)
    //                    message.Attachments.Add(attachments);
    //            }

    //        //SmtpServer.UseDefaultCredentials = false;
    //        SmtpServer.Port = 587;
    //        SmtpServer.Credentials = new System.Net.NetworkCredential("rob_hcheouat@emeal.nttdata.com", "MghQ7892389");
    //        System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls12;
    //        SmtpServer.EnableSsl = true;
    //        using (AlternateView alternate = AlternateView.CreateAlternateViewFromString(bodyText, Encoding.UTF8, MediaTypeNames.Text.Html))
    //        {
    //            message.AlternateViews.Add(alternate);
    //            message.IsBodyHtml = true;
    //            message.BodyEncoding = Encoding.UTF8;
    //            SmtpServer.Timeout = 300000;
    //            SmtpServer.Send(message);
    //        }

    //    }


    //    catch (Exception)
    //    {
    //        throw;
    //    }
    //}
    //public static void sendEmailAttachement(string mailFrom, string mailTo, string subjectText, string bodyText, string cc, List<string> attachments)
    //{
    //    try
    //    {

    //        MailMessage message = new MailMessage();
    //        SmtpClient SmtpServer = new SmtpClient("smtp-mail.outlook.com");
    //        message.From = new MailAddress(mailFrom);
    //        //if (mailTo.IndexOf(",") != -1)
    //        //{
    //        //    string[] listTO = mailTo.Split(',');
    //        //    foreach (string TO in listTO)
    //        //    {
    //        //        message.To.Add(TO);
    //        //    }
    //        //}
    //        //else {
    //        message.To.Add(mailTo);
    //        //}
    //        message.Subject = subjectText;
    //        message.Body = bodyText;
    //        SmtpServer.Port = 587;
    //        List<Attachment> ListAttachment = new List<Attachment>();
    //        if (attachments != null)
    //        {
    //            foreach (var path in attachments)
    //            {
    //                FileInfo fileInfo = new FileInfo(path);
    //                string fileName = Path.GetFileName(fileInfo.FullName);

    //                ListAttachment.Add(new Attachment(path));
    //                //Attach.Dispose();
    //            }
    //        }

    //        // CC List
    //        if (cc != null)
    //        {
    //            string[] listCC = cc.Split(',');
    //            foreach (string CCEmail in listCC)
    //            {
    //                message.CC.Add(new MailAddress(CCEmail.TrimStart().TrimEnd()));
    //            }
    //        }
    //        SmtpServer.Credentials = new System.Net.NetworkCredential("rob_hcheouat@emeal.nttdata.com", "MghQ7892389");
    //        //SmtpServer.Credentials = new System.Net.NetworkCredential(mailFrom, "MghQ7892389");
    //        SmtpServer.EnableSsl = true;
    //        SmtpServer.Timeout = Int32.MaxValue; ;
    //        using (AlternateView alternate = AlternateView.CreateAlternateViewFromString(bodyText, Encoding.UTF8, MediaTypeNames.Text.Html))
    //        {
    //            message.AlternateViews.Add(alternate);
    //            message.IsBodyHtml = true;
    //            message.BodyEncoding = Encoding.UTF8;
    //            if (ListAttachment.Count > 0)
    //            {
    //                foreach (var Attachment in ListAttachment)
    //                {
    //                    message.Attachments.Add(Attachment);
    //                }
    //            }
    //            SmtpServer.Send(message);

    //            if (ListAttachment.Count > 0)
    //            {
    //                foreach (var Attachment in ListAttachment)
    //                {
    //                    Attachment.Dispose();
    //                }
    //            }
    //        }

    //    }
    //    catch (Exception e)
    //    {
    //        throw;
    //    }
    //}

    //public static string getBaseURL()
    //{

    //    switch (FactoryConnection.db_Connection)
    //    {
    //        case DatabaseConnection.LOCALHOST:
    //            return "http://localhost:5000/";
    //        case DatabaseConnection.TEST.PREPRODUCTION:
    //            return "https://tst.staffaugmentation.com/";
    //        case DatabaseConnection.PREPRODUCTION:
    //            return "https://pre.staffaugmentation.com/";
    //        case DatabaseConnection.PRODUCTION:
    //            return "https://staffaugmentation.com/";
    //        default: return string.Empty;
    //    }

    //}

    //public static string GetPortaURL()
    //{
    //    try
    //    {
    //        switch (FactoryConnection.db_Connection)
    //        {
    //            case DatabaseConnection.LOCALHOST:
    //                return  "http://localhost:5005/";
    //            //case DatabaseConnection.TEST:
    //            //    return "";

    //            //case DatabaseConnection.PRODUCTION:
    //            //    return "https://contractmanagement.com/";
    //            default: return string.Empty;
    //        }
    //    }
    //    catch
    //    {
    //        throw;
    //    }

    //}
    //public static string Convert_StringvalueToHexvalue(string stringvalue, System.Text.Encoding encoding)
    //{
    //    Byte[] stringBytes = encoding.GetBytes(stringvalue);
    //    StringBuilder sbBytes = new StringBuilder(stringBytes.Length * 2);
    //    foreach (byte b in stringBytes)
    //    {
    //        sbBytes.AppendFormat("{0:X2}", b);
    //    }
    //    return sbBytes.ToString();
    //}

}
