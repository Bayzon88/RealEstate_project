<template>
  <div class="col-3 fixed fixed-right my-4 bg-light">
    <div class="sticky sticky-top">
      <p class="text-medium fs-4">Create New Listing</p>
      <div class="input-group mb-3">
        <input
          type="text"
          class="form-control"
          placeholder="Address"
          aria-label="Address"
          aria-describedby="basic-addon1"
          v-model="address"
        />
      </div>

      <div class="input-group mb-3">
        <input
          type="text"
          class="form-control"
          placeholder="Beds"
          aria-label="Bed"
          aria-describedby="basic-addon2"
          v-model="bedroom"
        />

        <input
          type="text"
          class="form-control"
          placeholder="Baths"
          aria-label="Bath"
          aria-describedby="basic-addon2"
          v-model="washroom"
        />
        <input
          type="text"
          class="form-control"
          placeholder="Parking"
          aria-label="Parking"
          aria-describedby="basic-addon2"
          v-model="parkingNo"
        />
      </div>

      <div class="input-group mb-3">
        <span class="input-group-text">$</span>
        <input
          type="text"
          class="form-control"
          aria-label="Amount (to the nearest dollar)"
          placeholder="Monthly Rent"
          v-model="rentalPrice"
        />
      </div>

      <div class="input-group">
        <span class="input-group-text">Description</span>
        <textarea class="form-control" aria-label="description" v-model="description"></textarea>
      </div>
      <router-link to="/listings">
        <button class="btn btn-secondary my-4" @click="createListing">Create Listing</button>
      </router-link>
    </div>
  </div>
</template>

<script>
import axios from "axios";
export default {
  props: {
    size: String,
    postInfo: null,
    name: [],
  },
  name: "NewListing",
  data() {
    return {
      address: "",
      totalArea: "",
      bedroom: "",
      washroom: "",
      parkingNo: "",
      description: "",
      rentalPrice: "",
    };
  },
  methods: {
    async createListing() {
      //Create new Listing
      try {
        let result = await axios.post(
          "https://localhost:7046/api/Listing",
          {
            landlordId: 0,
            houseTypeId: 0,
            houseType: {
              houseTypeId: 0,
              type: "string",
            },
            address: this.address,
            totalArea: Number(this.totalArea),
            bedroomNo: Number(this.bedroom),
            washroomNo: Number(this.washroom),
            parkingNo: Number(this.parkingNo),
            description: this.description,
            rentalPrice: Number(this.rentalPrice),
            validDays: 30,
          },
          {
            withCredentials: true,
          }
        );
        console.log(result);
      } catch (err) {
        console.log("There is an error");
        console.log(err);
      }
    },
  },
  mounted() {},
};
</script>
