import { storeToRefs } from 'pinia';
import useGameStore from '../store/index';

export default function selectCity(id) {
  const store = useGameStore();
  const { cities } = storeToRefs(store);
  console.log(cities.value);
  const foundCity = cities.value[id];

  // set isSelected property on the chosen city
  foundCity.isSelected = true;

  // check result
  if (cities.value[id].isCorrect) {
    alert('You won!');
    window.location.replace('/');
  } else {
    alert('Try again!');
  }
}
