import { useGameDataStore } from '../store/index';

export default function getQuestion() {
  const store = useGameDataStore();
  return store.getGameData();
}
