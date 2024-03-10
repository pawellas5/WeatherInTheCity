import { useGameDataStore } from '../store/index';

export default async function getQuestion() {
  const store = useGameDataStore();
  await store.getGameData();
}
