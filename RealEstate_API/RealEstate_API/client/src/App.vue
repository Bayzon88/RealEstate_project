<template>
    <Navbar></Navbar>
    <Login></Login>
</template>

<script>
    import Navbar from "./components/NavBar.vue";
    import Login from "./views/Login.vue";

    export default {
        name: 'App',
        components: { Navbar, Login },
    }
</script>

<style>
    #app {
        font-family: Avenir, Helvetica, Arial, sans-serif;
        -webkit-font-smoothing: antialiased;
        -moz-osx-font-smoothing: grayscale;
        text-align: center;
        color: #2c3e50;
        margin-top: 60px;
    }
</style>
