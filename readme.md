WebApiToolBox

For ASP.Net Web API projects.  Use to automatically generate a UI in the browser for testing the APIs.  
* Good for quickly testing your APIs as you develop them
* Good for QA teams that need to test your API 
* Good for using web app automation tools like web driver or phantomjs for testing the API

How to use:

1. Install the matthewcv.WebApiToolBox NuGet package into your Web API Project.
2. WebApiToolBox needs to configure itself and register some routes in your application. In your startup code where you register your Web API Routes include the WebApiToolBox namespace and call the UseWebApiToolBox() extension method from your HttpConfiguration.
    If you are hosting your project in IIS: ```GlobalConfiguration.Configuration.UseWebApiToolBox();```
	If you are self-hosting or using OWIN: 
	```
	    HttpConfiguration config = new HttpConfiguration();
        config.UseWebApiToolBox();
	```
	Do this before you register any other of your routes.
	The routes all start with _WebApiToolBox from the root of your application.
2.  If you are using MVC and have the Microsoft.AspNet.WebApi.HelpPage package installed:
    In your web app under /Ares/HelpPage/Views/Help there should be a view called Api.cshtml.  Add this code to the bottom of that file:
	```
  	@section scripts
	{
   		<script type="text/javascript" src="/_WebApiToolBox/scripts"></script>
	}
	```	
	Pay careful attention to the src attribute in that script element there.  If your API project is not at the root of the web host, you'll need to adjust it: ```<script type="text/javascript" src="/applicationName/_WebApiToolBox/scripts"></script>```
	Browse to one of the generated Help pages for an API.  The WebApiToolBox will initialize automatically and after a moment you will see a "Show UI" link at the bottom rigt of the window
	if you click it, a UI will be generated that matches the inputs for that API.  Fill them in and click the 'send request' button.
3.  You don't need to have MVC installed or HelpPages. While your applicatin is running, you can browse to /_WebApiToolBox from the root of your web application. It will show you a basic listing of your APIs and you can drill in to each one to see the UI.


