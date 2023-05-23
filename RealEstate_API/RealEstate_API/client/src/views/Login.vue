<template>
  <div class="container d-flex justify-content-between">
    <div class="my-5 mx-auto p-0 login__loginForm">
      <form action="https://localhost:7046/api/Account" method="get" class="container">
        <div class="mb-3">
          <label for="exampleInputEmail1" class="form-label">Email address</label>
          <input
            type="email"
            class="form-control"
            id="exampleInputEmail1"
            aria-describedby="emailHelp"
          />
          <div id="emailHelp" class="form-text">We'll never share your email with anyone else.</div>
        </div>
        <div class="mb-3">
          <label for="exampleInputPassword1" class="form-label">Password</label>
          <input type="password" class="form-control" id="exampleInputPassword1" />
        </div>

        <button type="submit" class="btn btn-primary login__loginForm--btnLogin w-100">
          Submit
        </button>
      </form>
      <div class="container">
        <button type="submit" class="btn btn-secondary my-4 w-100">Skip Login</button>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  name: "LoginPage",
  props: {
    msg: String,
  },
};
</script>
