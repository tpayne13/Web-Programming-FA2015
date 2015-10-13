using Assignment6.Services;
using Microsoft.AspNet.Mvc;

namespace Assignment6.Filters
{
	public class RequestIdFilter : IActionFilter
    {
		private string localId;

		public RequestIdFilter()
		{
			localId = "local-id";
        }

		public string Id { get { return Id; } }

		public void OnActionExecuted(ActionExecutedContext context)
		{
			/*
			* TODO: This should use an IRequestIdGenerator, which is an interface that still needs to be created.
			*/
			ConsoleLogger.Instance.Log("Adding a request-id to the response: " + localId);
			context.HttpContext.Response.Headers.Add("request-id", new string[] { localId });
		}

		public void OnActionExecuting(ActionExecutingContext context)
		{
			// nothing to do here, but have to have this method because the interface requires it
		}
	}
}
