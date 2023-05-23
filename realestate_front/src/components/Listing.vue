<template>
  <!-- Button trigger modal -->

  <div class="container d-flex flex-column custom-post py-3 listing">
    <div class="row p-2">
      <div class="col-4 d-flex align-items-center">
        <img :src="`/images/${listingInfo.listingId}.webp`" class="card-img-top" alt="image" />
      </div>
      <div class="col-8">
        <div class="card-body">
          <h4 class="card-title text-start m-0">${{ listingInfo.rentalPrice }}</h4>
          <p class="card-text text-start m-0">
            {{ listingInfo.description }}
          </p>
          <p class="card-title text-start">{{ listingInfo.address }}</p>
          <div class="d-flex justify-content-between" style="width: 75px">
            <p class="card-title text-start">
              <i class="fa fa-bed"></i>
              {{ listingInfo.bedroomNo }}
            </p>
            <p class="card-title text-start">
              <i class="fa fa-bath"></i>
              {{ listingInfo.washroomNo }}
            </p>
          </div>
          <p class="card-title text-end">
            <router-link
              :to="`/listings/${listingInfo.listingId}`"
              class="btn btn-secondary"
              @click="goToTop"
              >More</router-link
            >
          </p>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import ListingDetails from "./ListingDetails.vue";
export default {
  props: {
    size: String,
    listingInfo: null,
    name: [],
  },
  name: "UserListing",
  data() {
    return {
      price: this.listingInfo.rentalPrice,
    };
  },
 
  beforeMount() {},
  mounted() {
    //Adjust bootstrap "col" size throguh props
    document.querySelector(".custom-post").classList.add(`col-${this.size}`);

    this.$router.addRoute([
      {
        path: `/listings/:listingId`,
        components: ListingDetails,
        props: { listingInfo: this.listingInfo },
      },
    ]);
  },
};
</script>
