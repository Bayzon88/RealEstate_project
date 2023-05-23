<template>
  <link
    rel="stylesheet"
    href="https://use.fontawesome.com/releases/v5.2.0/css/all.css"
    integrity="sha384-hWVjflwFxL6sNzntih27bfxkr27PmbbK/iSvJ+a4+0owXq79v+lsFkW54bOGbiDQ"
    crossorigin="anonymous"
  />
  <footer
    class="text-center text-white position-fixed w-100 fixed-bottom"
    style="background-color: #f1f1f1"
  >
    <div class="container pt-2">
      <section class="m-auto">
        <!-- Facebook -->
        <a
          class="btn btn-link btn-floating btn-lg text-dark m-1"
          href="#!"
          role="button"
          data-mdb-ripple-color="dark"
          ><i class="fab fa-facebook-f"></i
        ></a>

        <!-- Twitter -->
        <a
          class="btn btn-link btn-floating btn-lg text-dark m-1"
          href="#!"
          role="button"
          data-mdb-ripple-color="dark"
          ><i class="fab fa-twitter"></i
        ></a>

        <!-- Linkedin -->
        <a
          class="btn btn-link btn-floating btn-lg text-dark m-1"
          href="https://www.linkedin.com/in/alvarobeltran/"
          role="button"
          data-mdb-ripple-color="dark"
          ><i class="fab fa-linkedin"></i
        ></a>
        <!-- Github -->
        <a
          class="btn btn-link btn-floating btn-lg text-dark m-1"
          href="#!"
          role="button"
          data-mdb-ripple-color="dark"
          ><i class="fab fa-github"></i
        ></a>
      </section>
      <!-- Section: Social media -->
    </div>
    <!-- Grid container -->

    <div class="text-center text-dark p-3" style="background-color: rgba(0, 0, 0, 0.2)">
      Developer by Alvaro Beltran - 2023
    </div>
  </footer>
</template>

<script>
export default {
  data() {
    return {
      footerMsg: "This is footer",
    };
  },
  footerMsg: "Developed by Alvaro Beltran 2023",
  props: {
    msg: String,
  },
};
</script>
