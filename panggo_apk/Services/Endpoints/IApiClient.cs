using Refit;

namespace panggo_apk.Services.Endpoints;

[Headers("Content-Type: application/json")]
public interface IApiClient
{
    [Get("/api/weatherforecast")]
    Task<ApiResponse<IImmutableList<WeatherForecast>>> GetWeather(CancellationToken cancellationToken = default);
}
