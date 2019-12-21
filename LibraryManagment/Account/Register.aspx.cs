using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using LibraryManagment.Models;
using LibraryManagment.LibraryData.Model;
using LibraryManagment.LibraryData.Services;
using LibraryManagment.LibraryData.Utils;

namespace LibraryManagment.Account
{
    public partial class Register : Page
    {
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            KlientService klientService = new KlientService();
            DegaService degaService = new DegaService();
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var signInManager = Context.GetOwinContext().Get<ApplicationSignInManager>();
            var user = new ApplicationUser() { UserName = Username.Text, Email = Email.Text };
            IdentityResult result = manager.Create(user, Password.Text);
            if (result.Succeeded)
            {
                // For more information on how to enable account confirmation and password reset please visit https://go.microsoft.com/fwlink/?LinkID=320771
                //string code = manager.GenerateEmailConfirmationToken(user.Id);
                //string callbackUrl = IdentityHelper.GetUserConfirmationRedirectUrl(code, user.Id, Request);
                //manager.SendEmail(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>.");

                Klient klient = new Klient();
                klient.Id = RandomIdGenerator.generateId();
                klient.Emri = FirstName.Text;
                klient.Mbiemri = LastName.Text;
                klient.Username = Username.Text;
                klient.Email = Email.Text;
                klient.Password = Password.Text;
                klient.Adresa = Address.Text;
                klient.NumerTelefoni = Int32.Parse(Phone.Text);
                klient.Dega = degaService.gjejMeId(1);

                klientService.shto(klient);


                signInManager.SignIn( user, isPersistent: false, rememberBrowser: false);
                IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            }
            else 
            {
                ErrorMessage.Text = result.Errors.FirstOrDefault();
            }
        }
    }
}