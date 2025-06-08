
using gRPC_Demo.Services;

namespace gRPC_Demo
{
	public class Program
	{
		public static void Main(string[] args) {
			var builder = WebApplication.CreateBuilder(args);

			// Add services to the container.

			builder.Services.AddControllers();

			// Add Grpc Services to the container.
			builder.Services.AddGrpc();

			// to enable refection for types exist in grpc
			builder.Services.AddGrpcReflection();

			// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
			builder.Services.AddEndpointsApiExplorer();
			builder.Services.AddSwaggerGen();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (app.Environment.IsDevelopment()) {
				app.UseSwagger();
				app.UseSwaggerUI();
			}

			app.UseHttpsRedirection();

			app.UseAuthorization();


			app.MapControllers();
			app.MapGrpcService<TelemetryTrackingService>();

			// endpoint to enable reflection for grpc service for communication
			if (app.Environment.IsDevelopment()) {
				// Enable gRPC reflection in development mode
				app.MapGrpcReflectionService();
			}

			app.Run();
		}
	}
}
