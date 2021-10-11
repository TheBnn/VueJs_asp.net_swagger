import Vue from 'vue'
import VueRouter from "vue-router"

Vue.use(VueRouter)


import Home from "@/components/Home.vue"
import Hello from "@/components/Hello.vue"

const routes = [
    {
        path: "/",
        name: "Home",
        component: Home,
    },
    {
        path: "/Hello",
        name: "Hello",
        component: Hello,
    },
]


export default new VueRouter({
    routes: routes
})