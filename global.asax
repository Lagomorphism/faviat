<%@ Application Language="C#" %>
<%@ Import Namespace="System.Web.Routing" %>

<script runat="server">

    void Application_Start(object sender, EventArgs e) 
    {
        // Code that runs on application startup
        RegisterRoute(RouteTable.Routes);
    }

    void RegisterRoute(RouteCollection routes)
    {
        routes.Ignore("{resource}.axd/{*pathInfo}");
        routes.MapPageRoute("home", "Home", "~/default.aspx");
        routes.MapPageRoute("myprofile", "MyProfile", "~/profile.aspx");
        routes.MapPageRoute("login", "Login", "~/login.aspx");
        routes.MapPageRoute("signup", "Signup", "~/signup.aspx");
        routes.MapPageRoute("forgot", "Forgot", "~/forgot.aspx");

        routes.MapPageRoute("defaultRoute", "{*value}", "~/default.aspx");
    }
    
    void Application_End(object sender, EventArgs e) 
    {
        //  Code that runs on application shutdown

    }
        
    void Application_Error(object sender, EventArgs e) 
    { 
        // Code that runs when an unhandled error occurs

    }

    void Session_Start(object sender, EventArgs e) 
    {
        // Code that runs when a new session is started

    }

    void Session_End(object sender, EventArgs e) 
    {
        // Code that runs when a session ends. 
        // Note: The Session_End event is raised only when the sessionstate mode
        // is set to InProc in the Web.config file. If session mode is set to StateServer 
        // or SQLServer, the event is not raised.

    }
       
</script>
