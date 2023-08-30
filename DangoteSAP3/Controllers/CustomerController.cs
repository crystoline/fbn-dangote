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
    public class CustomerController : ApiController
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public string WsdlUsername { get; }
        public string WsdlPassword { get; }

        public CustomerController()
        {
            WsdlUsername = ConfigurationManager.AppSettings["WsdlUsername"];
            WsdlPassword = ConfigurationManager.AppSettings["WsdlPassword"];
        }

        [HttpPost]
        [Route("api/v1/customer/get-details")]
        public IHttpActionResult GetDetails([FromBody] CustomerDetailsRequestViewModel detailsRequest)
        {
         
            var soapService = new DangoteCustomerDetailsService.si_atm_cust_abs_syncClient("HTTP_Port2");
            soapService.ClientCredentials.UserName.UserName = WsdlUsername;
            soapService.ClientCredentials.UserName.Password = WsdlPassword;
            // soapService.PreAuthenticate = true;

            try
            {
                var data = new DangoteCustomerDetailsService.dt_atm_cust_in
                {
                    comp_code = detailsRequest.CompCode,
                    cust_num = detailsRequest.CustNum,
                    cc_area = detailsRequest.CcArea,
                    sales_org = detailsRequest.SalesOrg,
                    access_token = detailsRequest.AccessToken,
                };
                logger.Debug("Data sent to endpoint", JsonConvert.SerializeObject(data));
                DangoteCustomerDetailsService.dt_atm_cust_out resposne = soapService.si_atm_cust_abs_sync(data);
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

        [HttpPost]
        [Route("api/v1/customer/down-payment")]
        public IHttpActionResult DownPayment([FromBody] DangoteCustomerDownPaymentATCService.dt_bank_in downPayment)
        {
            var soapService = new DangoteCustomerDownPaymentATCService.si_bank_abs_syc_v2Client("HTTP_Port3");
            soapService.ClientCredentials.UserName.UserName = WsdlUsername;
            soapService.ClientCredentials.UserName.Password = WsdlPassword;
            // soapService.PreAuthenticate = true;

            try
            {
                
                logger.Debug("Data sent to endpoint", JsonConvert.SerializeObject(downPayment));
                DangoteCustomerDownPaymentATCService.dt_bank_out resposne = soapService.si_bank_abs_syc_v2(downPayment);
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