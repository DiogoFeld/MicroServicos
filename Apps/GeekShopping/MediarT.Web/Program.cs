using MassTransit;
using MediarT.Application.Command;
using MediarT.Application.Consumer;
using MediarT.Application.Handlers;
using MediarT.Core.Entities;
using System.Reflection;

namespace MediarT.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();


            // Register MediatR
            var assemblies = new Assembly[]
            {
                Assembly.GetExecutingAssembly(),
                typeof(ProcessRequestClientHandler).Assembly
            };
            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblies(assemblies));

            //MassTransit 
            builder.Services.AddMassTransit(config =>
            {
                //Mark this as consumer
                config.AddConsumer<RequestClientConsumer>();

                config.UsingRabbitMq((ct, cfg) =>
                {
                    cfg.Host(builder.Configuration["EventBusSettings:HostAddress"]);
                    cfg.ReceiveEndpoint("client-request-queue", c =>
                    {
                        c.ConfigureConsumer<RequestClientConsumer>(ct);
                    });
                });
            });


            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
