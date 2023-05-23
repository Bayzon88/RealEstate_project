<template>
  <div class="col-6">
    <UserInfo v-for="(user, index) in users" :key="index" :userInfo="user" />
  </div>
</template>

<script>
import axios from "axios";
import UserInfo from "../components/UserInfo.vue";
export default {
  components: { UserInfo },
  name: "HomePage",
  data() {
    return {
      users: [],
      isLoading: true,
    };
  },
  async mounted() {
    try {
      //Get all users
      const result = await axios.get("https://localhost:7046/api/Account");
      this.users = await result.data;
      this.isLoading = false;
    } catch (err) {
      console.log("There is an error");
      console.log(err);
    }
  },
};
</script>
