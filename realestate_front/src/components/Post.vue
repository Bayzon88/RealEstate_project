<template>
  <!-- <div class="card d-flex flex-column">
    <img src="../assets/logo.png" class="card-img-top" alt="..." width="1rem" />
    <div class="card-body">
      <h5 class="card-title">Card title</h5>
      <p class="card-text">
        Some quick example text to build on the card title and make up the bulk of the card's
        content.
      </p>
    </div>
    <ul class="list-group list-group-flush">
      <li class="list-group-item">An item</li>
      <li class="list-group-item">A second item</li>
      <li class="list-group-item">A third item</li>
    </ul>
    <div class="card-body">
      <a href="#" class="card-link">Card link</a>
      <a href="#" class="card-link">Another link</a>
    </div>
  </div> -->
  <div class="container d-flex flex-column custom-post">
    <div class="row p-2">
      <div class="col-2">
        <img src="../assets/logo.png" class="card-img-top" alt="..." />
      </div>
      <div class="col-9">
        <div class="card-body">
          <h5 class="card-title text-start">{{ postInfo.name }}</h5>
          <p class="card-text">
            Some quick example text to build on the card title and make up the bulk of the card's
            content.
          </p>
        </div>
      </div>
    </div>
  </div>
</template>

<script>
export default {
  props: {
    size: String,
    postInfo: null,
    name: [],
  },
  name: "UserPost",
  data() {
    return {
      postData: [],
    };
  },
  mounted() {
    //Adjust bootstrap "col" size throguh props
    document.querySelector(".custom-post").classList.add(`col-${this.size}`);
  },
};
</script>
