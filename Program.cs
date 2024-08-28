namespace Assignment_01_MVC
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();
             
            app.UseRouting();
            app.UseStaticFiles();
            #region MyRegion
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapGet("/Home", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello In Home Page!");
            //    });



            //    endpoints.MapGet("/Products/{id:int?}", async context =>
            //    {
            //        var idData = context.Request.RouteValues["id"];

            //        if (idData is not null)
            //        {
            //            int id = Convert.ToInt32(context.Request.RouteValues["id"]);
            //            await context.Response.WriteAsync($"Hello In Products Page => {id}!");
            //        }
            //        else
            //            await context.Response.WriteAsync("Hello In Products Page!");



            //    });

            //    endpoints.MapGet("/Books/{id}/{author:alpha:minlength(4):maxlength(10}", async context =>
            //    {
            //        int id = Convert.ToInt32(context.Request.RouteValues["id"]);
            //        string author = context.Request.RouteValues["author"].ToString();
            //        await context.Response.WriteAsync($"Hello In Products Page => {id} ,{author}!");
            //    });

            //});
            //app.Run(async (HttpContext) =>
            //{

            //    await HttpContext.Response.WriteAsync("Not Found !!");

            //}); 
            #endregion

            app.MapControllerRoute(

                name: "default",
                pattern: "/{Controller=Home}/{action=Index}",
                defaults: new { controller = "Home" ,Action="Index"}
                
                );
            app.Run();
        }
    }
}
