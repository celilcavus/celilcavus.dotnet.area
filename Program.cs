using celilcavus.models;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllersWithViews();

builder.Services.AddScoped<List<User>,List<User>>();

builder.Services.AddMvc(options=>{
    options.EnableEndpointRouting = false;
});
var app = builder.Build();



app.MapAreaControllerRoute(
    name:"User",
    areaName:"User",
    pattern:"{controller}/{action}/{id?}"
);
app.MapControllers();


app.Run();
