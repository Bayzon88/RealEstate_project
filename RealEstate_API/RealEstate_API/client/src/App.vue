<template>
  <Navbar></Navbar>
  <router-view />
  <Footer />
</template>

<script>
import Navbar from "./components/NavBar.vue";
import Footer from "./components/Footer-Comp.vue";
//import axios from "axios";

export default {
  name: "App",
  components: { Navbar, Footer },
  //async mounted() {
  //  try {
  //    let result = axios.get("https://localhost:7046/api/account");
  //    console.log(result);
  //  } catch (err) {
  //    console.log(err);
  //  }
  //},
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
