<template>
  <div class="container d-flex justify-content-between">
    <div class="my-5 mx-auto p-0 login__loginForm">
      <img src="../assets/Logo_small.png" class="mb-5" />
      <form class="container" @submit.prevent="login" action="/listings">
        <div class="mb-3">
          <label for="username" class="form-label">Username</label>
          <input
            type="username"
            class="form-control"
            id="username"
            aria-describedby="username"
            v-model="username"
          />
        </div>
        <div class="mb-3">
          <label for="password" class="form-label">Password</label>
          <input type="password" class="form-control" id="password" v-model="password" />
        </div>

        <button type="submit" class="btn btn-primary login__loginForm--btnLogin w-100">
          Login
        </button>
      </form>
      <div class="container">
        <router-link to="/listings">
          <button type="submit" class="btn btn-secondary my-4 w-100" @click="skipLogin">
            Skip Login
          </button>
        </router-link>
      </div>
      <div class="container my-5">
        <p class="fw-medium text-dark">Don't have an account?</p>

        <router-link to="/signup">
          <button type="submit" class="btn btn-secondary w-100" @click="this.$props.setLogin">
            Go to Sign Up
          </button>
        </router-link>
      </div>
    </div>
  </div>
</template>

<script>
import axios from "axios";

export default {
  name: "LoginPage",
  props: {
    setLogin: null,
    setLogged: null,
  },
  data() {
    return {
      isLogged: Boolean,
      username: "",
      password: "",
    };
  },
  methods: {
    async skipLogin() {
      try {
        //Bypass Login for showing purposes
        //TODO: Remove in production
        let result = await axios.post(
          "https://localhost:7046/api/account/login",
          {
            username: "string",
            password: "Stringst",
            returnUrl: "string",
            rememberMe: true,
          },
          {
            withCredentials: true,
          }
        );
        console.log(result);
        this.$props.setLogged();
      } catch (err) {
        console.log("There is an error");
        console.log(err);
      }
    },
    async login() {
      try {
        //Bypass Login for showing purposes
        //TODO: Remove in production
        let result = await axios.post(
          "https://localhost:7046/api/account/login",
          {
            username: this.username,
            password: this.password,
            returnUrl: "string",
            rememberMe: true,
          },
          {
            withCredentials: true,
          }
        );
        console.log(result);
        this.$props.setLogged();
        this.$router.push("/listings"); //Go to listings
      } catch (err) {
        console.log("There is an error");
        console.log(err);
      }
    },
  },
};
</script>
