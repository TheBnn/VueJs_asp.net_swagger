<template>
    <div>{{loading}}</div>
</template>


<script lang="js">
    import Vue from 'vue';

    export default Vue.extend({
        data() {
            return {
                loading: false,
                post: null
            };
        }
    });
</script>