import { useGameDataStore } from '../store/index';

export default function getQuestion(gameId = null) {
  const store = useGameDataStore();
  return store.getGameData(gameId);
}
