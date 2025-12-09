# Happy Weather App

A modern Windows Forms application for viewing real-time weather information for cities worldwide. Built with .NET Framework 4.8, the app features a clean UI, asynchronous data fetching, and persistent user settings.

## Features

- **City & Country Selection:**  
  Choose from a comprehensive list of cities and countries, fetched live from an online API. The selection is presented in a searchable combo box for convenience.

- **Real-Time Weather Data:**  
  Displays current weather conditions including temperature, wind speed, humidity, and weather icons for the selected city.

- **Persistent Settings:**  
  Remembers your last selected location using application settings, so you can quickly view weather data for your favorite city on startup.

- **User-Friendly Interface:**  
  - Main dashboard shows city name, weather description, and icon.
  - Dedicated panels for temperature, wind, and humidity.
  - "Choose City" button opens a location selector form.
  - "Exit" button to close the application.

## How It Works

1. **Startup:**  
   On launch, the app loads your previously saved city and country from settings and fetches the latest weather data.

2. **Selecting a Location:**  
   - Click the "Choose City" button.
   - The location selector form (`FRM_Location`) loads a list of cities and countries from an online API.
   - Select a location and click "Save" to persist your choice.

3. **Fetching Weather Data:**  
   - The app uses the [WeatherStack API](https://weatherstack.com/) to retrieve current weather information for the selected location.
   - Weather data is displayed with relevant icons and metrics.

## Installation

1. **Requirements:**
   - Windows OS
   - .NET Framework 4.8
   - Internet connection (for API access)

## Configuration

- **WeatherStack API Key:**  
  Replace `XXXXXXXXXXXXXXXXXXXXXXX` in `Form1.cs` with your own WeatherStack API key.

- **Dependencies:**  
  - [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) for JSON parsing.

## Project Structure

- `Form1.cs` - Main form, handles weather data display and user interactions.
- `FRM_Location.cs` - Location selector form, fetches and displays city/country list.
- `Form1.Designer.cs` - UI layout and controls for the main form.
- `Form1.resx` - Resource file for UI elements and localization.

## Screenshots

*(Add screenshots of the main dashboard and location selector here)*

## Contributing

Pull requests are welcome. For major changes, please open an issue first to discuss what you would like to change.

## License

This project is licensed under the MIT License.

---

**Note:** 
Ensure you have a valid WeatherStack API key and internet access for full functionality.
