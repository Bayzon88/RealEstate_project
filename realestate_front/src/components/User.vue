<template>
  <div class="card border-0 bg-light">
    <img
      src="../assets/images/alvaro.png"
      class="card-img-top m-auto"
      alt="..."
      style="width: 75px"
    />
    <div class="card-body">
      <h5 class="card-title">Alvaro Beltran</h5>
      <p class="card-text">Full Stack Web Developer MERN | Vue.js | Asp.NET</p>
    </div>
  </div>
</template>

<script>
export default {
  name: "UserInfo",
  props: {
    name: String,
    email: String,
    phone: Number,
  },
};
</script>
