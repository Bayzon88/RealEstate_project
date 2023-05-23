import { createApp } from "vue";
import App from "./App.vue";

import router from "./router";
import "./assets/styles/styles.scss";

const app = createApp(App).use( router).mount("#app");
app;
