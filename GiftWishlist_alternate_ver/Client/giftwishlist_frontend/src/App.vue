<template>
  <div id="app">
<!--    <div class="app-menu">-->
<!--      <side-menu />-->
<!--    </div>-->
    <div class="app-content">
      <router-view />
    </div>
  </div>
</template>

<script lang="ts">
import { Component, Vue } from "vue-property-decorator";
import SideMenu from "@/components/SideMenu.vue";

@Component({
  name: "App",
  components: {
    SideMenu
  }
})
export default class App extends Vue {}
</script>

<style lang="scss">
  @import "./src/assets/scss/global.scss";

</style>
