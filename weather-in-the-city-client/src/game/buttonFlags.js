import { ref } from 'vue';
import { storeToRefs } from 'pinia';
import { useGameDataStore, useGameInfoStore } from '../store/index';

const isCorrect = ref([false, false, false, false]);
const isIncorrect = ref([false, false, false, false]);
const isGreyedOut = ref([false, false, false, false]);

function greyOutButtons() {
  // check which buttons are neither correct nor incorrect
  const arrCorrect = isCorrect.value;
  const arrIncorrect = isIncorrect.value;
  for (let i = 0; i < arrCorrect.length; i += 1) {
    if (arrCorrect[i] === false && arrIncorrect[i] === false) {
      isGreyedOut.value[i] = true;
    } else isGreyedOut.value[i] = false;
  }
  return isGreyedOut;
}
function resetBtnFlags() {
  isCorrect.value = [false, false, false, false];
  isIncorrect.value = [false, false, false, false];
  isGreyedOut.value = [false, false, false, false];
}

function setBtnFlags(id) {
  const gameDataStore = useGameDataStore();
  const gameInfoStore = useGameInfoStore();

  const { cities } = storeToRefs(gameDataStore);
  const foundCity = cities.value[id];
  // set isSelected property on the chosen city
  foundCity.isSelected = true;
  // check result
  if (cities.value[id].isCorrect) {
    isCorrect.value[id] = true;
    gameInfoStore.addPoint();
  } else {
    isIncorrect.value[id] = true;
    const correctId = cities.value.findIndex((el) => el.isCorrect === true);
    isCorrect.value[correctId] = true; // show the correct answer
  }
  greyOutButtons();
}
export {
  isCorrect, isIncorrect, isGreyedOut, setBtnFlags, resetBtnFlags,
};
