public class Startup
{
    public void Configuration(IAppBuilder app)
    {
        app.MapSignalR();
    }
}