﻿namespace MyTemplate.Application.WeatherForecasts;

public record WeatherForecastVm(
    Guid Id,
    DateTime Date,
    int TemperatureC,
    int TemperatureF,
    string? Summary);
