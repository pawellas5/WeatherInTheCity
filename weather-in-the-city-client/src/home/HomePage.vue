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
    padding-top:4rem;
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

  @media screen and (max-width: 1024px ){
    .main{
      padding-top:2rem;
    }

    .btn{
    width:500px;
    height:70px;
  }
    .cities{
  flex-direction: column;
  }

}

@media screen and (max-width: 1024px ) and (orientation: landscape){

    .btn{
    width:200px;
    height:80px;
    font-size: 1.5rem;
  }
    .cities{
  flex-direction: row;
  }
  .otherInfo div{
    font-size: 1.5rem;
  }
  .temperature{
    font-size: 8rem ;
  }

}
@media screen and (max-width: 932px ) and (orientation: landscape){

.btn{
width:150px;
height:40px;
font-size: 0.8rem;
}

.otherInfo div{
font-size: 0.8rem;
}
.temperature{
font-size: 4rem ;
}

}
@media screen and (max-width: 740px ) and (orientation: landscape){

.btn{
width:140px;
height:20px;
font-size: 0.6rem;
}
.otherInfo div{
font-size: 0.6rem;
}
.temperature{
font-size: 3rem ;
}

}

@media screen and (max-width: 540px ){
    .main{
      padding-top:2rem;
      font-size: 1.2rem;
    }
    .temperature{
      font-size: 5rem;
    }
    .btn{
    width:200px;
    height:50px;
    font-size: 1.2rem;
  }
    .cities{
  flex-direction: column;
  }

}

@media screen and (max-width: 375px ){
    .main{
      padding-top:2rem;
      font-size: 1.1rem;
    }
    .temperature{
      font-size: 5rem;
    }
    .btn{
    width:180px;
    height:35px;
    font-size: 1.1rem;
  }

}

@media screen and (max-width: 280px ){
    .main{
      font-size: 0.9rem;
    }
    .temperature{
      font-size: 4.8rem;
    }
    .btn{
    width:180px;
    height:25px;
    font-size: 0.9rem;
  }
}

  </style>
