import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
	selector: 'app-fetch-data',
	templateUrl: './fetch-data.component.html'
})
export class FetchDataComponent {
	public Forecasts: WeatherForecast[];

	constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
		http.get<WeatherForecast[]>(baseUrl + 'api/SampleData/WeatherForecasts').subscribe(result => {
			this.Forecasts = result;
		}, error => console.error(error));
	}
}

interface WeatherForecast {
	DateFormatted: string;
	TemperatureC: number;
	TemperatureF: number;
	Summary: string;
}
