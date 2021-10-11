<template src="./App.html"></template>
<style src="./App.css"></style>



<script>

    import Home from './components/Home.vue'
    import Hello from './components/Hello.vue'



    export default {
        name: 'App',
        components: {
            Home,
            Hello
        },
        data() {
            return {
                message: 'Welcome to Vue.js'
            }
        }
    }

</script>

