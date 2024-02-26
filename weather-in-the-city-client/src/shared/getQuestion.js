import useGameStore from '../store/index';

export default async function getQuestion() {
  const store = useGameStore();
  await store.getGameData();
}
