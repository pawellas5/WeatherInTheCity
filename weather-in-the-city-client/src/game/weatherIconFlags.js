import { computed } from 'vue';

export default function setWeatherFlags(weather) {
  const desc = computed(() => weather.value.weather[0].description.toLowerCase());
  const isClearSky = computed(() => desc.value.includes('clear sky'));
  const isDrizzle = computed(() => desc.value.includes('drizzle'));
  const isMistOrFog = computed(() => desc.value.includes('mist') || desc.value.includes('fog'));
  const isOvercastClouds = computed(() => desc.value.includes('overcast clouds'));
  const isRain = computed(() => desc.value.includes('rain'));
  const isScatteredOrBrokenClouds = computed(() => desc.value.includes('scattered clouds') || desc.value.includes('broken clouds'));
  const isSnow = computed(() => desc.value.includes('snow'));
  const isStorm = computed(() => desc.value.includes('storm'));
  return {
    isClearSky,
    isDrizzle,
    isMistOrFog,
    isOvercastClouds,
    isRain,
    isScatteredOrBrokenClouds,
    isSnow,
    isStorm,
  };
}
