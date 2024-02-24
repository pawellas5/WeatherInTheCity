<template>
    <div class="main">
      <div class="weather">
        <div class="temperature">
          7&deg;C
        </div>
        <div class="otherInfo">
          <div>Condition: Light Drizzle</div>
          <div>Pressure: 100.7 kpa</div>
          <div>Humidity: 100%</div>
          <div>Wind: 8km/h</div>
        </div>

      </div>
      <div class="cities">
        <button class="btn">Bruksela</button>
        <button class="btn">Londyn</button>
        <button class="btn">Rio de Janeiro</button>
        <button class="btn">Toronto</button>

      </div>
    </div>
    <!-- <button class="btn" @click="getGameData">
      Click
    </button> -->
  </template>

<script>
import { storeToRefs } from 'pinia';
import useGameStore from '../store/index';

export default {
  name: 'HomePage',
  methods: {
    getGameData() {
      this.store.getGameData();
    },
  },
  setup() {
    const store = useGameStore();
    const { weather, cities } = storeToRefs(store);
    return {
      store,
      weather,
      cities,
    };
  },
};
</script>

  <style scoped>

.weather{
  background-color: #e9eaed;
  width:100%;
  height:50%;
  display:flex;

}

.temperature{
  height:100%;
  width:50%;
  /* background-color: red; */
  display: flex;
  justify-content: center;
  align-items: center;
  font-size: 10rem;
  color:#ff7900;

}
.otherInfo{
  height:100%;
  width:50%;
  /* background-color: blue; */
  display: flex;
  flex-direction: column;
  justify-content: space-evenly;
  align-items: center;

}

.otherInfo div{
  /* background-color: yellow; */
  width:60%;
  text-align: left;
  color:#ff7900

}

.cities{
  background-color:white;
  width:100%;
  height:50%;
  display: flex;
  justify-content: space-evenly;
  align-items: center;
}
  .main{
    width:100%;
    height: 100%;
    /* background-color: #1d1f20; */
    background-color: white;
    /* background-color: white; */
    color:white;
    font-size:2rem;
    text-align:left;
    padding-top:4rem;;
  }
  .btn{
    width:250px;
    height:100px;
    border-radius: 2rem;
    border:0;
    background-color: #ff7900;
    color:white;
    font-size: 2rem;
  }
  .btn:hover{
    cursor:pointer;
    background-color:#ff9300;

  }

  </style>
