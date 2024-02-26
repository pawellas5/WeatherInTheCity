import { storeToRefs } from 'pinia';
import getQuestion from '@/shared/getQuestion';
import useGameStore from '../store/index';

export default async function selectCity(id) {
  const store = useGameStore();
  const { cities } = storeToRefs(store);
  const foundCity = cities.value[id];

  // set isSelected property on the chosen city
  foundCity.isSelected = true;

  // check result
  if (cities.value[id].isCorrect) {
    alert('You won!');
    await getQuestion(); // to the next question
  } else {
    alert('Try again!');
  }
}
