const api =import.meta.env.weather_api

const weatherData = fetch(api)
.then((response) => response.json())
.then((data) => console.log(data))
.catch((err) => console.log(err))