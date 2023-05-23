import { createRouter, createWebHistory } from "vue-router";
//Define routes here to use in app.vue
import Home from "../views/Home.vue";
import SignUp from "../views/SignUp.vue";
import Login from "../views/Login.vue";
import Listings from "../views/Listings.vue";
import ListingDetails from "../components/ListingDetails.vue";

const routes = [
  {
    //Home: feed of all the listings available, ordered by date
    path: "/",
    name: "home",
    component: Home,
  },
  {
    //Sign up page for a new user
    path: "/signup",
    name: "signup",
    component: SignUp,
  },
  {
    //Login page
    path: "/login",
    name: "login",
    component: Login,
  },
  {
    //Listings page
    path: "/listings",
    name: "listings",
    component: Listings,
  },
  {
    //Listing Details Page
    path: "/listings/:listingId",
    props: (route) => ({ listingId: route.params.listingId }),
    component: ListingDetails,
  },
];

const router = createRouter({
  history: createWebHistory(process.env.BASE_URL),
  routes, //Array of all the routes
});
export default router;
