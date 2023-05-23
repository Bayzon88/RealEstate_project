<template>
  <span class="container custom-navbar flex-col fixed fixed-left bg-light">
    <div class="row sticky sticky-top bg-light">
      <router-link to="/">
        <img src="../assets/Logo_small.png" alt="" class="navbar_logo" />
      </router-link>
      <UserInfo class="mt-5" />
      <div class="d-flex flex-column mt-2">
        <ul class="navbar-nav">
          <li class="nav-item">
            <router-link to="/" type="button" class="nav-link active navbar__btnLogin"
              >Users</router-link
            >
          </li>
          <li class="nav-item">
            <router-link to="/Listings" type="button" class="nav-link active navbar__btnListings"
              >Listings</router-link
            >
          </li>
          <li class="nav-item">
            <router-link
              to="/"
              type="button"
              class="nav-link active navbar__btnLogin"
              @click="logOut"
              >Log out</router-link
            >
          </li>
        </ul>
      </div>
    </div>
  </span>
</template>

<script>
import UserInfo from "../components/User.vue";
import { removeToken } from "../router/authentication";
export default {
  components: { UserInfo },
  props: {
    size: String,
    setLogged: null, //conditional rendering for authenticated users
  },
  methods: {
    logOut() {
      removeToken("jwtToken"); //remove jwtToken in cookies
      this.$props.setLogged();
      // this.$router.push("/home");
      // this.$router.go("/"); //reload page
    },
  },
  mounted() {
    //Adjust bootstrap "col" size throguh props
    document.querySelector(".custom-navbar").classList.add(`col-${this.size}`);
  },
};
</script>
