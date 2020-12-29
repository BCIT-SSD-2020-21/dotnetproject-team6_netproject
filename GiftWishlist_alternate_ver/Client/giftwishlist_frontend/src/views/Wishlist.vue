<template>

	<div class="mx-auto" style="max-width: 1080px;">
		<solar-button @click.native="showNewItemModal" id="addNewBtn">Add New Item</solar-button>

		<div class="row no-gutters row-cols-1 row-cols-sm-1 row-cols-md-2 row-cols-lg-3 row-cols-xl-3 mx-auto">
			<div class="col filtr-item" data-category="1">
				<div class="card">
					<div class="card-body">
						<p>My 2020 Wishlist<br></p>
						<div class="d-flex align-items-lg-end align-items-xl-end">
							<div class="tag tag-private" style="text-align: center;"><span>Private</span></div>
						</div>
					</div>
				</div>
			</div>
			<div class="col filtr-item" data-category="1">
				<div class="card">
					<div class="card-body">
						<p>SecretSanta - Coworkers Ltd<br></p>
						<div class="d-flex align-items-lg-end align-items-xl-end">
							<div class="tag tag-group" style="text-align: center;"><span>Group</span></div>
						</div>
					</div>
				</div>
			</div>
		</div>
		<div>
			<div class="row no-gutters row-cols-2 footer">
				<div class="col text-center"><button  class="btn" type="button">Search</button></div>
				<div class="col text-center"><button class="btn" type="button" data-toggle="modal" data-target="#modal-1">Create</button>
				</div>
			</div>
		</div>
		<new-item-modal v-if="isNewItemVisible" @save:product="saveNewItem" @close="closeModals" />

	</div>
</template>


<script lang="ts">

import { Component, Vue } from "vue-property-decorator";
import { IItemWishlist, IItem } from "@/types/Item";
import SolarButton from "@/components/Button.vue";
import NewItemModal from "@/components/modals/NewItemModal.vue";
import { WishlistService } from "@/services/wishlist-service";
import { ItemService } from "@/services/item-service";

const wishlistService = new WishlistService();
const itemService = new ItemService();

@Component({
  name: "Wishlist",
  components: { SolarButton, NewItemModal }
})
export default class Wishlist extends Vue {
  isNewItemVisible: boolean = false;
  isShipmentVisible: boolean = false;

  wishlist: IItemWishlist[] = [];


	async saveNewItem(newItem: IItem) {
		await itemService.save(newItem);
		this.isNewItemVisible = false;
		await this.initialize;
	}

	async deleteItem(itemId: number){
		await itemService.delete(itemId);
		await this.initialize();
	}



  applyColor(current: number, target: number) {
	if (current <= 0) {
	  return "red";
	} if (Math.abs(target-current) > 8) {
	  return "yellow";
	}
	return "green";
  }

  closeModals() {
	this.isShipmentVisible = false;
	this.isNewItemVisible = false;
  }

  showNewItemModal() {
	this.isNewItemVisible = true;
  }

  async initialize(){
	this.wishlist = await wishlistService.getWishlist();
  }

  async created() {
	await this.initialize();
  }
}
</script>
