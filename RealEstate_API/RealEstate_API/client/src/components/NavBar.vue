<template>
  <nav class="navbar navbar-expand-lg bg-body-primary">
    <div class="container">
      <router-link to="/">
        <img src="../assets/Logo_small.png" alt="" class="navbar_logo" />
      </router-link>

      <div class="d-flex gap-2 d-md-flex">
        <button class="btn navbar__btnSignup" type="button" to="/signup">Sing Up</button>
        <router-link to="/login" type="button" class="btn btn-outline-primary navbar__btnLogin"
          >Login</router-link
        >
      </div>
      <!-- <div class="collapse navbar-collapse" id="navbarSupportedContent">
        <ul class="navbar-nav me-auto mb-2 mb-lg-0">
          <li class="nav-item">
            <router-link to="/">Home</router-link>
          </li>
          <li class="nav-item">
            <router-link to="/login">Login</router-link>
          </li>
        </ul>
      </div>-->
    </div>
  </nav>
</template>

<script>
export default {
  props: {
    msg: String,
  },
};
</script>
