<template>
  <div v-if="login" v:bind="login">
    <Login :setLogin="setLogin" :setLogged="setLogged" />
  </div>
  <div v-else><SignUp :setLogin="setLogin" @click="setLogin" /></div>
</template>

<script>
// import axios from "axios";
import Login from "./Login.vue";
import SignUp from "./SignUp.vue";

export default {
  name: "LoginPage",
  components: { Login, SignUp },
  props: {
    setLogged: null,
  },
  data() {
    return {
      login: false,
      setLogin: () => (this.login = !this.login), //passing function as props to update login state
    };
  },
  methods: {},
};
</script>
