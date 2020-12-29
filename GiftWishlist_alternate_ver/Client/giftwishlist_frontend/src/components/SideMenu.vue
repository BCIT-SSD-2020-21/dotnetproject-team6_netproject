<template>
<div class="side-menu-container">
    <router-link to="/">
        <img id="imgLogo" src="../assets/images/solar_coffee_logo.png" alt="Solar Coffee logo">
    </router-link>
    <h1>Management Portal</h1>
    <solar-button id="menuWishlist" is-full-width @button:click="goToRoute('/wishlist')">Wishlist</solar-button>
</div>
</template>

<script lang="ts">
import { Component, Vue } from 'vue-property-decorator';
import SolarButton from '@/components/Button.vue'

@Component({
    name: 'SideMenu',
    components: { SolarButton }
})

export default class SideMenu extends Vue {
    goToRoute(route: string){
        this.$router.push(route);
    }
 }
</script>

<style scoped lang="scss">
    @import "./src/assets/scss/global.scss";

#imgLogo {
    width: 100%;
}

h1 {
    font-size: 1.2rem;
    margin: 1rem 0;
}

.side-menu-container {
    background-color: #fcfcfc;
    height: 100vh;
    width: $menu-width;
    display: flex;
    flex-direction: column;
    padding: 0.8rem;
    box-shadow: 0 1px 1px rgba(0,0,0,0.12), 0 1px 1px rgba(0,0,0,0.24);
    box-sizing: border-box;
}

</style>
