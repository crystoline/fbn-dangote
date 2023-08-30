using DangoteSAP3.ViewModels;
using DangoteSAP3.ActionFilters;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DangoteSAP3.Controllers
{

    [ValidationActionFilter]
    public class AuthenticationController : ApiController
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public string WsdlUsername { get; }
        public string WsdlPassword { get; }

        public AuthenticationController()
        {
             WsdlUsername = ConfigurationManager.AppSettings["WsdlUsername"];
             WsdlPassword = ConfigurationManager.AppSettings["WsdlPassword"];
        }


        /// <summary>
        /// Login
        /// </summary>
        /// <param name="loginData"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/v1/authentication/login")]
        public IHttpActionResult Login(LoginRequestViewModel loginData)
        {
            
    
            var soapService = new DangoteLoginService.si_full_auth_absClient("HTTP_Port");
            soapService.ClientCredentials.UserName.UserName = WsdlUsername;
            soapService.ClientCredentials.UserName.Password = WsdlPassword;

            try
            {
                var data = new DangoteSAP3.DangoteLoginService.dt_full_auth_in
                {
                    username = loginData.Username,
                    password = loginData.Password,
                    full_synch = "1"
                };

                logger.Debug("Data sent to login endpoint", JsonConvert.SerializeObject(data));

                var resposne = soapService.si_full_auth_abs( data);
                
                logger.Info("Service call successfull\\n\r Data sent to Client: \n\r {Data}", JsonConvert.SerializeObject(resposne));
                return Ok(resposne);
            }
            catch(WebException e)
            {
                logger.Error(e);
                return InternalServerError(new Exception(e.Message));
            }
            catch (Exception e)
            {
                logger.Error(e);
                return InternalServerError(new Exception("Unknown error occurred"));
            }
            
            
        }

        /// <summary>
        /// Reset Password
        /// </summary>
        /// <param name="resetPasswordRequest"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/v1/authentication/reset-password")]
        public IHttpActionResult ResetPassword(ResetPasswordRequestViewModel resetPasswordRequest)
        {

            var soapService = new DangoteResetPasswordService.si_pass_reset_absClient("HTTP_Port1");

            soapService.ClientCredentials.UserName.UserName = WsdlUsername;
            soapService.ClientCredentials.UserName.Password = WsdlPassword;

            try
            {
                var data = new DangoteResetPasswordService.dt_pass_rest_in
                {
                    username = resetPasswordRequest.Username,
                    password = resetPasswordRequest.Password,
                    new_password = resetPasswordRequest.NewPassword,
                    new_password_confirmation = resetPasswordRequest.NewPasswordConfirmation
                };
                logger.Debug("Data sent to login endpoint", JsonConvert.SerializeObject(data));
                DangoteResetPasswordService.dt_pass_rest_out resposne = soapService.si_pass_reset_abs(data);
                logger.Info("Service call successfull\\n\r Data sent to Client: \n\r {Data}", JsonConvert.SerializeObject(resposne));
                return Ok(resposne);
            }
            catch (WebException e)
            {
                logger.Error(e);
                return InternalServerError(new Exception(e.Message));
            }
            catch (Exception e)
            {
                logger.Error(e);
                return InternalServerError(new Exception("Unknown error occurred"));
            }
        }
    }
}