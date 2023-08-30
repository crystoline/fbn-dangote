using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace DangoteSAP3.ActionFilters
{
    public class ValidationActionFilter: ActionFilterAttribute, IActionFilter
    {
        private static readonly NLog.Logger logger = NLog.LogManager.GetCurrentClassLogger();
        public override void OnActionExecuting(HttpActionContext actionContext)
        {
           
            var modelState = actionContext.ModelState;
           
            if (!modelState.IsValid)
            {
                logger.Error("Invalid/Bad Request was send. \n\r {Data}", JsonConvert.SerializeObject(modelState));
                actionContext.Response = actionContext.Request.CreateErrorResponse(HttpStatusCode.BadRequest, modelState);
            }
        }
    }
}