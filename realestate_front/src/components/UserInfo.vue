<template>
  <div class="container d-flex flex-column custom-post py-3 listing">
    <div class="row p-2">
      <div class="col-4 d-flex align-items-center">
        <img
          :src="`/images/users/${userInfo.userName}.png`"
          class="card-img-top"
          alt="user image"
        />
      </div>
      <div class="col-8">
        <div class="card-body">
          <h4 class="card-title text-start m-0">Username: {{ userInfo.userName }}</h4>
          <p class="card-text text-start m-0">Email: {{ userInfo.email }}</p>
        </div>
      </div>
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
    userInfo: null,
  },
};
</script>
