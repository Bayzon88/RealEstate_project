<template>
  <div class="col-6">
    <!-- Create new Listing  using Modal -->

    <!-- Conditional Rendering for the listings  -->
    <div v-if="isLoading" v-bind="isLoading">Loading ...</div>
    <div v-else v:bind="isLoading" class="border-1">
      <UserListing
        v-for="(listingData, index) in listings"
        :key="index"
        :listingInfo="listingData"
      />
    </div>
    <RouterView />
  </div>
</template>

<script>
import axios from "axios";
import UserListing from "../components/Listing.vue";
// import ListingDetails from "../components/ListingDetails.vue";
export default {
  components: { UserListing },
  name: "ListingsPage",
  data() {
    return {
      listings: [],
      isLoading: true,
    };
  },
  methods: {
    async getListings() {
      try {
        //Get all listings in home page
        const result = await axios.get("https://localhost:7046/api/listing", {
          withCredentials: true,
        });
        this.listings = await result.data;
        console.log(this.listings);
        this.isLoading = false; //API call finish loading
      } catch (err) {
        console.log("There is an error");
        console.log(err);
      }
    },
  },
  async mounted() {
    await this.getListings(); //make axios call to get all listings
  },
};
</script>
