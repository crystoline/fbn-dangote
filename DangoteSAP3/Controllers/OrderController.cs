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
    /// <summary>
    /// 
    /// </summary>
    [ValidationActionFilter]
    public class OrderController : ApiController
    {

        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();

        public string WsdlUsername { get; }
        public string WsdlPassword { get; }
        public OrderController()
        {
            WsdlUsername = ConfigurationManager.AppSettings["WsdlUsername"];
            WsdlPassword = ConfigurationManager.AppSettings["WsdlPassword"];
        }

        /// <summary>
        /// Get product price
        /// </summary>
        /// <param name="getPriceDetails"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/v1/order/get-price")]
        public IHttpActionResult GetPrice([FromBody]  DangoteOrderGetPriceService.dt_price_in getPriceDetails)
        {
            var soapService = new DangoteOrderGetPriceService.si_price_abs_syncClient("HTTP_Port4");
            soapService.ClientCredentials.UserName.UserName = WsdlUsername;
            soapService.ClientCredentials.UserName.Password = WsdlPassword;
            // soapService.PreAuthenticate = true;

            try
            {
                logger.Debug("Data sent to endpoint", JsonConvert.SerializeObject(getPriceDetails));
                DangoteOrderGetPriceService.dt_price_out resposne = soapService.si_price_abs_sync(getPriceDetails);
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

        /// <summary>
        /// Down payment with ATC
        /// </summary>
        /// <param name="downPayment"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/v1/order/down-payment-with-atc")]
        public IHttpActionResult PaymentWithAtc([FromBody]  DangoteOrderDownPaymentService.dt_atm_dp_in downPayment)
        {
            var soapService = new DangoteOrderDownPaymentService.si_atm_dp_bapi_abs_syncClient("HTTP_Port5");
            soapService.ClientCredentials.UserName.UserName = WsdlUsername;
            soapService.ClientCredentials.UserName.Password = WsdlPassword;
            // soapService.PreAuthenticate = true;

            try
            {
                logger.Debug("Data sent to endpoint", JsonConvert.SerializeObject(downPayment));

                DangoteOrderDownPaymentService.dt_doc_out resposne = soapService.si_atm_dp_bapi_abs_sync(downPayment);
                logger.Info("Service call successfull\\n\r Data sent to Client: \n\r {Data}", JsonConvert.SerializeObject(downPayment));
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