using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Newtonsoft.Json;
using System.Text;
using Microsoft.Owin.Security;// .Host.SystemWeb;
using Microsoft.Owin.Cors;
using System.Security.Cryptography;
using System.Net.Mail;
using System.Configuration;
using System.Web.Http.Owin;
using Microsoft.Owin.Security.OAuth;

using System.Web;
using Microsoft.Owin;
using SRS.REST.App_Start;
namespace SRS.REST.Controllers
{
    public class UserController : ApiController
    {

        [HttpGet]
        public List<tbl_User>  GetUserLists(string Username) //List<tbl_User>
        {
           
                DBAskDataContext db = new DBAskDataContext();
                var obj = db.tbl_Users.Where(x => x.UserName.Contains(Username) && x.Leaver == false).ToList();
                return obj;
           
        }
        [HttpGet]
        public string Test (string Param) //List<tbl_User>
        {
            
            return Param;
        }

        [HttpGet]
        public string SetPermission(string Username,string IsLocked ) 
        {


            DBAskDataContext db = new DBAskDataContext();
            usp_tbl_EmailMessage_SearchResult em = db.usp_tbl_EmailMessage_Search(" LanguageID = 2057 AND tbl_EmailMessage.PK = 1 ").FirstOrDefault();            
            SendEmail("test Sub", em.Body, "from-any@servertest.com", "tnguyen327@dxc.com", "batien83@gmail.com");
            return "";

            ///var obj = db.tbl_Users.Where(x => x.UserName.Contains(Username) && x.Leaver == false).ToList();
            tbl_User user = db.tbl_Users.FirstOrDefault(x => x.UserName == Username);
            if (user == null)
                return "not found";
            user.Locked = (IsLocked == "1");
            //db.SubmitChanges();
            if(IsLocked != "1")
            {
                
                tbl_PasswordReset pr = db.tbl_PasswordResets.Where(x => x.UserID == user.PK).OrderByDescending(x => x.PK).First();
                if (pr != null)
                {
                    if ((PasswordResetStatus)pr.Status == PasswordResetStatus.InProgress)
                    {
                        pr.Status = (int)PasswordResetStatus.Expired;
                        pr.LastAttemptDate = DateTime.UtcNow;
                        
                    }
                }
                   
            }
            tbl_PasswordReset resetPwdEnt = new tbl_PasswordReset();
            
            string tempPwd = GeneratePassword(10);
            string validationCode = GetMD5String(DateTime.UtcNow.ToString());
          
            resetPwdEnt.UserID = user.PK;
            resetPwdEnt.TempPassword = tempPwd;
            resetPwdEnt.ValidationCode = validationCode;
            resetPwdEnt.ResetDate = DateTime.UtcNow;
            db.SubmitChanges();
            string URL_CHANGE_PASSWORD = ConfigurationManager.AppSettings["URL_RESET"];
           
        }
        private string SendEmail(string Subject, string BodyMsg, string fromemail, string addresses, string cc)
        {
            SmtpClient smtpClientType = new SmtpClient();
            smtpClientType.Host = ConfigurationManager.AppSettings.Get("MailServer");
            smtpClientType.Port = System.Convert.ToInt32(ConfigurationManager.AppSettings.Get("MailPort"));

            MailMessage message = new MailMessage();
            message.IsBodyHtml = true;
            string fromAddr = fromemail;
            string fromAddrDisplay = fromemail;
            MailAddress fromAddress = new MailAddress(fromAddr, fromAddrDisplay);
            try
            {
                message.Body = BodyMsg;
                message.Subject = Subject;
                if (addresses.Contains(","))
                {
                    string[] adds = addresses.Split(',');
                    foreach (string stradd in adds)
                    {
                        message.To.Add(stradd);
                    }
                }
                else
                    message.To.Add(addresses);

                if (string.IsNullOrEmpty(cc) == false)
                {
                    //message.CC.Add(cc);
                    //Wei request change from CC to BCC
                    if (cc.Contains(","))
                    {
                        string[] ccs = cc.Split(',');
                        foreach (string strcc in ccs)
                        {
                            message.Bcc.Add(strcc);
                        }
                    }
                    else
                        message.Bcc.Add(cc);

                }
                message.From = fromAddress;

                smtpClientType.Send(message);

                return "True";
            }
            catch (SmtpException smtpEx)
            {
                return ("Error in Sending Mail:" + smtpEx.Message);
            }
            catch (Exception ex)
            {
                return ("Error in Sending Mail:" + ex.Message);
            }
        }
        public static string GetMD5String(string text)
        {
            byte[] data = Encoding.UTF8.GetBytes(text);
            MD5CryptoServiceProvider provider = new MD5CryptoServiceProvider();
            byte[] encodedData = provider.ComputeHash(data);
            StringBuilder sb = new StringBuilder();
            foreach (byte b in encodedData)
            {
                sb.Append(b.ToString("X2"));
            }
            return sb.ToString();
        }
        public static string GeneratePassword(int passwordLength)
        {
            const int charNums = 67; // "A-Z" + "0-9" + "~!@#$"
            char[] specialChars = new char[] { '~', '!', '@', '#', '$' };

            Random random = new Random();
            StringBuilder sb = new StringBuilder();
            for (int count = 0; count < passwordLength; count++)
            {
                int number = random.Next(charNums);
                if (number < 10)
                {
                    sb.Append(number);
                }
                else if (number >= 10 && number < 36)
                {
                    sb.Append(Convert.ToChar(55 + number));
                }
                else if (number >= 36 && number < 62)
                {
                    sb.Append(Convert.ToChar(61 + number));
                }
                else if (number >= 62)
                {
                    sb.Append(specialChars[number - 62]);
                }
            }
            return sb.ToString();
        }
        public enum PasswordResetStatus
        {
            InProgress = 1,
            Success = 2,
            Failure = 3,
            Expired = 4,
        }
        [HttpGet]
        public string CreateUserFromExist(string Firstname,string LastName,string UserName,string EmailAddress,string ContactTelephone, string ExistUser)
        {
            try
            {
                //test:  https://localhost:44339/api/user?Firstname=tnguyen3z&Lastname=cachon&UserName=tnguyen399&EmailAddress=tnguyen999@dxc.com&ContactTelephone=1111&ExistUser=tnguyen327.u1
                DBAskDataContext db = new DBAskDataContext();
                string Password = GeneratePassword(10);                 
               int res=  db.usp_CreateUserFromExistUser(Firstname, LastName, UserName , EmailAddress, ContactTelephone , Password, ExistUser );  //"tnguyen327.u1"
                
                db.SubmitChanges();             // db.Foods.InsertOnSubmit(food);
                return Password;
            }
            catch(Exception ex)
            {
                return "Error:" + ex.Message;
            }
        }

    }
    /*
    public class PropertyController : ApiController
    {
        [Authorize]
        [HttpGet]
        public IHttpActionResult GetProperty(int propertyID)
        {
            int clientID =  OwinContextExtensions.GetClientID();
            try
            {
                //var result = Service or DB Call(clientID, propertyID)
                return Json(new
                {
                    PropertyName = string.Format("Property - {0}", propertyID),
                    Success = true
                });
            }
            catch (Exception ex)
            {
                return Content(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }

   */
}
