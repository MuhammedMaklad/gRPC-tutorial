using Grpc.Core;
using gRPC_Demo.Protos;

namespace gRPC_Demo.Services
{
	public class TelemetryTrackingService : TrackingService.TrackingServiceBase
	{
		private readonly ILogger<TelemetryTrackingService> logger;
		public TelemetryTrackingService(ILogger<TelemetryTrackingService> logger) {
			this.logger = logger;
		}

		public override Task<TrackingResponse> SendMessage(TrackingMessage request, ServerCallContext context) {

			logger.LogInformation($"New Message -> DeviceId :{request.DeviceId}\t" +
			$"Location : {request.Location.Lat}, {request.Location.Long}\t" +
			$"Speed : {request.Speed}");

			return Task.FromResult(new TrackingResponse {
				Success = true
			});
		}
	}
}
