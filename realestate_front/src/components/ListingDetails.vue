<template>
  <!-- Button trigger modal -->
  <div class="col-6">
    <div class="card border-0">
      <div class="d-flex justify-content-between p-3">
        <h5 class="card-header bg-none text-start color-secondary">
          <router-link to="/listings"> <i class="fa fa-chevron-left"></i> Go Back </router-link>
        </h5>
        <router-link to="/listings">
          <button class="btn btn-primary" @click="deleteListing">Delete</button>
        </router-link>
      </div>
      <img :src="`/images/${listingInfo.listingId}.webp`" class="card-img-top" alt="..." />
      <div class="card-body text-start">
        <div class="d-flex w-100 justify-content-between align-items-center">
          <h5 class="card-title">{{ listingInfo.address }}</h5>
          <!-- Button trigger modal -->
          <button
            type="button"
            class="btn btn-dark"
            data-bs-toggle="modal"
            data-bs-target="#exampleModal"
          >
            Modify Listing
          </button>
        </div>
        <p class="card-text">Monthly Rent: ${{ listingInfo.rentalPrice }}</p>
        <p class="card-text">Description: {{ listingInfo.description }}</p>
        <div class="d-flex w-75 justify-content-between">
          <p class="card-text">Washroom: {{ listingInfo.washroomNo }}</p>
          <p class="card-text">Bedroom: {{ listingInfo.bedroomNo }}</p>
          <p class="card-text">Parking: {{ listingInfo.parkingNo }}</p>
        </div>
        <p class="card-text">
          <small class="text-body-secondary">Listed: {{ listingInfo.listingTime }}</small>
        </p>
      </div>
    </div>
  </div>
  <!-- Modal -->
  <div
    class="modal fade"
    id="exampleModal"
    tabindex="-1"
    aria-labelledby="exampleModalLabel"
    aria-hidden="true"
  >
    <div class="modal-dialog">
      <div class="modal-content">
        <div class="modal-header">
          <h1 class="modal-title fs-5" id="exampleModalLabel">Modify Listing Information</h1>
          <button
            type="button"
            class="btn-close"
            data-bs-dismiss="modal"
            aria-label="Close"
          ></button>
        </div>
        <div class="modal-body">
          <div class="fixed fixed-right my-4">
            <div class="sticky sticky-top">
              <div class="input-group mb-3">
                <input
                  type="text"
                  class="form-control"
                  placeholder="Address"
                  aria-label="Address"
                  aria-describedby="basic-addon1"
                  v-model="listingInfo.address"
                />
              </div>

              <div class="input-group mb-3">
                <input
                  type="text"
                  class="form-control"
                  placeholder="Beds"
                  aria-label="Bed"
                  aria-describedby="basic-addon2"
                  v-model="listingInfo.bedroomNo"
                />

                <input
                  type="text"
                  class="form-control"
                  placeholder="Baths"
                  aria-label="Bath"
                  aria-describedby="basic-addon2"
                  v-model="listingInfo.washroomNo"
                />
                <input
                  type="text"
                  class="form-control"
                  placeholder="Parking"
                  aria-label="Parking"
                  aria-describedby="basic-addon2"
                  v-model="listingInfo.parkingNo"
                />
              </div>

              <div class="input-group mb-3">
                <span class="input-group-text">$</span>
                <input type="text" class="form-control" v-model="listingInfo.rentalPrice" />
              </div>

              <div class="input-group">
                <span class="input-group-text">Description</span>
                <textarea
                  class="form-control"
                  aria-label="description"
                  v-model="listingInfo.description"
                ></textarea>
              </div>
            </div>
          </div>
        </div>
        <div class="modal-footer">
          <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
          <button type="button" class="btn btn-primary" @click="modifyListingInformation">
            Modify
          </button>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
import axios from "axios";
export default {
  props: {
    size: String,

    name: [],
    listingId: Number,
  },
  name: "UserListing",
  data() {
    return {
      listingInfo: [],
      listedTime: Date,
    };
  },
  async beforeMount() {
    await this.getListingInformation();
  },
  mounted() {
    //Populate values for input elements in modal
    this.address = this.listingInfo.address;
  },
  methods: {
    async deleteListing() {
      const result = await axios.delete(`https://localhost:7046/api/listing/${this.listingId}`, {
        withCredentials: true,
      });
      this.listingInfo = result.data;
    },
    async getListingInformation() {
      try {
        //Get all listings in home page
        const result = await axios.get(`https://localhost:7046/api/listing/${this.listingId}`, {
          withCredentials: true,
        });
        this.listingInfo = result.data;

        console.log(result);
      } catch (err) {
        console.log("There is an error");
        console.log(err);
      }
    },
    async modifyListingInformation() {
      try {
        //Get all listings in home page
        const result = await axios.put(
          `https://localhost:7046/api/listing/${this.listingId}`,
          {
            landlordId: 0,
            houseTypeId: 0,
            houseType: {
              houseTypeId: 0,
              type: "string",
            },
            address: this.listingInfo.address,
            totalArea: Number(this.listingInfo.totalArea),
            bedroomNo: Number(this.listingInfo.bedroomNo),
            washroomNo: Number(this.listingInfo.washroomNo),
            parkingNo: Number(this.listingInfo.parkingNo),
            description: this.listingInfo.description,
            rentalPrice: Number(this.listingInfo.rentalPrice),
            validDays: 30,
          },
          {
            withCredentials: true,
          }
        );
        this.listingInfo = result.data;
        this.getListingInformation();

        console.log(result);
      } catch (err) {
        console.log("There is an error");
        console.log(err);
      }
    },
  },
};
</script>
