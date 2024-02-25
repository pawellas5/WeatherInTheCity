<template>
    <div class="main">
      <div  v-if="weather" class="weather">
        <div class="temperature">
          {{Math.round(weather.main.temp)}}&deg;C
        </div>
        <div class="otherInfo">
          <div>Description: {{ weather.weather[0].description }}</div>
          <div>Pressure: {{ weather.main.pressure }} kpa</div>
          <div>Humidity: {{weather.main.humidity}}%</div>
          <div>Wind: {{weather.wind.speed}} km/h</div>
        </div>

      </div>
      <div v-if="cities" class="cities">
        <button class="btn">

          <div class=cityName>
            {{cities[0].cityName}}
          </div>
          <div class=countryName>
            ({{cities[0].countryName}})
          </div>

        </button>

        <button class="btn">

          <div class=cityName>
            {{cities[1].cityName}}
          </div>
          <div class=countryName>
            ({{cities[1].countryName}})
          </div></button>

        <button class="btn">

          <div class=cityName>
            {{cities[2].cityName}}
          </div>
          <div class=countryName>
            ({{cities[2].countryName}})
          </div>

        </button>

        <button class="btn">

          <div class=cityName>
            {{cities[3].cityName}}
          </div>
          <div class=countryName>
            ({{cities[3].countryName}})
          </div>

        </button>

      </div>
    </div>

  </template>

<script>
import { storeToRefs } from 'pinia';
import useGameStore from '../store/index';

export default {
  name: 'HomePage',

  setup() {
    const store = useGameStore();
    store.getGameData();
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
.cities .btn{

  display: flex;
  flex-direction: column;
  justify-content: center;
  align-items: center;
}
.cityName{
 height: 60%;
 padding-top:1rem;
}
.countryName{
  height:40%;
  font-size:1.4rem;
}

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

@media screen and (max-width: 932px ){

  .cities .btn{
    padding:0.5rem 0 0.5rem 0;
    height:90px;
}
.cityName{
 padding:0;
 height:100%;

}
.countryName{
  height:100%;
  font-size:1.5rem;
}

}

@media screen and (max-width: 768px ){
.temperature{
  font-size:8rem;
}
.cities .btn{
  padding:0.5rem 0 0.5rem 0;
  height:75px;
}
.countryName{
font-size:1.5rem;
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

  .cities .btn{
    width:220px;
    height:50px;
    font-size: 1.2rem;
  }
    .main{
      padding-top:2rem;
      font-size: 1.2rem;
    }
    .temperature{
      font-size: 5rem;
    }
  .countryName{
    font-size: 1rem;
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
      font-size: 4rem;
    }

  .cities .btn{
    padding:0.5rem 0 0.5rem 0;
    height:45px;
    width:200px;
}

.countryName{
  font-size:0.9rem;
}

}

@media screen and (max-width: 280px ){
    .main{
      font-size: 0.9rem;
    }
    .temperature{
      font-size: 3.5rem;
    }

  .cities .btn{
    width:220px;
    height:40px;
  }
  .countryName{
    font-size: 0.8rem;
  }
  .cityName{
    font-size:0.9rem;
  }
}

  </style>
