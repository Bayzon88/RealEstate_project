<template>
  <div class="container text-center">
    <div class="row m-0 justify-content-between vh-100" v-if="isLogged" v-bind="isLogged">
      <Navbar size="3" :setLogged="setLogged" />
      <router-view class="col-6" />
      <NewListing />
    </div>
    <div v-if="!isLogged" v-bind="isLogged">
      <UserAuth :setLogged="setLogged" />
    </div>
  </div>

  <Footer />
</template>

<script>
import Navbar from "./components/NavBar.vue";
import Footer from "./components/Footer-Comp.vue";
import NewListing from "./components/NewListing.vue";
import UserAuth from "./views/UserAuth.vue";
import { getToken, removeToken } from "./router/authentication";

export default {
  name: "App",
  components: { Navbar, Footer, UserAuth, NewListing },
  data() {
    return {
      isLogged: false,
      setLogged: () => {
        this.isLogged = !this.isLogged;
      },
    };
  },
  methods: {
    killToken() {
      removeToken("jwtToken"); //Removes jwtToken cookie
    },
  },
  beforeMount() {
    console.log(this.isLogged);
    //check if token exists
    if (getToken().length > 0) {
      this.isLogged = true;
    }
  },
  created() {
    //Event listener: on closing window errase token
    window.addEventListener("beforeunload", () => {
      removeToken();
    });
  },
};
</script>

<style>
#app {
  font-family: Avenir, Helvetica, Arial, sans-serif;
  -webkit-font-smoothing: antialiased;
  -moz-osx-font-smoothing: grayscale;
  text-align: center;
  color: #2c3e50;
  margin-top: 60px;
}
</style>
