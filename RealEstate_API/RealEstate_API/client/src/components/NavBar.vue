<template>
  <nav class="navbar navbar-expand-lg bg-body-primary">
    <div class="container">
      <img src="../assets/Logo_small.png" alt="" class="navbar_logo" />

      <!-- <div class="d-flex gap-2 d-md-flex">
        <button class="btn navbar__btnSignup" type="button">Sing Up</button>
        <button type="button" class="btn btn-outline-primary navbar__btnLogin">Login</button>
      </div> -->
      <!-- <div class="collapse navbar-collapse" id="navbarSupportedContent">
        <ul class="navbar-nav me-auto mb-2 mb-lg-0">
          <li class="nav-item">
            <router-link to="/">Home</router-link>
          </li>
          <li class="nav-item">
            <router-link to="/login">Login</router-link>
          </li>
        </ul>
      </div> -->
    </div>
  </nav>
  <router-view />
</template>

<script>
export default {
  name: "HelloWorld",
  props: {
    msg: String,
  },
};
</script>
