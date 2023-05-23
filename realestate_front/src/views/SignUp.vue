<template>
  <div class="container d-flex justify-content-between">
    <div class="my-2 mx-auto p-0 login__loginForm">
      <img src="../assets/Logo_small.png" class="mb-5" />
      <form class="container" @submit.prevent="login">
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
          <label for="email" class="form-label">Email address</label>
          <input
            type="email"
            class="form-control"
            id="username"
            aria-describedby="username"
            v-model="email"
          />
          <div id="email" class="form-text">We'll never share your email with anyone else.</div>
        </div>
        <div class="mb-3">
          <label for="password" class="form-label">Password</label>
          <input type="password" class="form-control" id="password" v-model="password" />
        </div>
        <div class="mb-3">
          <label for="phone" class="form-label">Phone</label>
          <input type="phone" class="form-control" id="phone" v-model="phone" />
        </div>
        <div class="mb-3">
          <label for="gender" class="form-label">Gender</label>
          <input type="text" class="form-control" id="gender" v-model="gender" />
        </div>

        <button
          type="submit"
          class="btn btn-primary login__loginForm--btnLogin w-100"
          @click="signUp"
        >
          Sign Up
        </button>
        <button
          type="submit"
          class="btn btn-primary login__loginForm--btnLogin w-100 my-2"
          @click="createAdmin"
        >
          Create Admin
        </button>
      </form>
      <div class="container my-2">
        <p class="fw-medium text-dark">Already Registered?</p>
        <router-link to="/login">
          <button type="submit" class="btn btn-secondary w-100" @click="this.$props.setLogin">
            Go to Login
          </button>
        </router-link>
      </div>
    </div>
  </div>
  <h1></h1>
</template>

<script>
import axios from "axios";

export default {
  name: "LoginPage",
  props: {
    setLogin: null,
  },
  data() {
    return {
      isLogged: Boolean,
      username: "",
      email: "",
      password: "",
      phone: "",
      gender: "",
      setLoginFunc: null,
    };
  },
  methods: {
    async signUp() {
      try {
        //Bypass Login for showing purposes
        //TODO: Remove in production
        let result = await axios.post(
          "https://localhost:7046/api/account/signup",
          {
            username: this.username,
            password: this.password,
            email: this.email,
            phone: this.phone,
            gender: this.gender,
          },
          {
            withCredentials: true,
          }
        );
        this.$props.setLogin();
        console.log(result);
      } catch (err) {
        console.log("There is an error");
        console.log(err);
      }
    },
    async createAdmin() {
      try {
        //Bypass Login for showing purposes
        //TODO: Remove in production
        let result = await axios.post(
          "https://localhost:7046/api/account/signup",
          {
            username: "admin",
            password: "Admin1234",
            email: "admin@admin.com",
            phone: "1234",
            gender: "admin",
          },
          {
            withCredentials: true,
          }
        );
        this.$props.setLogin();
        console.log(result);
      } catch (err) {
        console.log("There is an error");
        console.log(err);
      }
    },
  },
  mounted() {},
};
</script>
