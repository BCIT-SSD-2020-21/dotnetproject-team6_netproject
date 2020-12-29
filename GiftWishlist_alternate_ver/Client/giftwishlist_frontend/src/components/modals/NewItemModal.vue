<template>
  <solar-modal>
    <template v-slot:header>Add new item</template>

    <template v-slot:body>
      <ul>
        <li>
          <label for="isTaxable">Is this item taxable?</label>
          <input type="checkbox" id="isTaxable" v-model="newItem.isTaxable">
        </li>

        <li>
          <label for="itemName">Name</label>
          <input type="text" id="itemName" v-model="newItem.name">
        </li>

        <li>
          <label for="itemDesc">Description</label>
          <input type="text" id="itemDesc" v-model="newItem.description">
        </li>

        <li>
          <label for="itemPrice">Price (USD)</label>
          <input type="number" id="itemPrice" v-model="newItem.price">
        </li>
      </ul>
    </template>

    <template v-slot:footer>
      <solar-button type="button" @click.native="save" aria-label="save new item">Save Item</solar-button>
      <solar-button type="button" @click.native="close" aria-label="close modal">Close</solar-button>
    </template>
  </solar-modal>
</template>

<script lang="ts">
import { Component, Prop, Vue } from "vue-property-decorator";
import SolarButton from "@/components/Button.vue";
import SolarModal from "@/components/modals/Modal.vue";
import { IItemWishlist, IItem } from "@/types/Item";

@Component({
  name: "NewItemModal",
  components: { SolarButton, SolarModal }
})
export default class NewItemModal extends Vue {
  newItem: IItem = {
    "id": 0,
    "name": "",
    "description": "",
    "price": 0,
    "imageUrl": "",
    "imageThumbnailUrl": ""
  };

  close() {
    this.$emit("close");
  }

  save() {
    this.$emit('save:item', this.newItem);
  }
}
</script>

<style scoped lang="scss">
  .newItem {
    list-style: none;
    padding: 0;
    margin: 0;

    input {
      width: 100%;
      height: 1.8rem;
      margin-bottom: 1.2rem;
      font-size: 1.1rem;
      line-height: 1.3rem;
      padding: 0.2rem;
      color: #555;
    }

    label {
      font-weight: bold;
      display: block;
      margin-bottom: 0.3rem;
    }
  }
</style>
