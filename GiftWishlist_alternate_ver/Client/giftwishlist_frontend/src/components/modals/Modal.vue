<template>
  <transition name="modal-fade">
    <div class="modal fade" role="dialog" tabindex="-1" id="modal-1" style="padding: 8px;">
      <div class="modal-dialog" role="document">
        <div class="modal-content">
          <div class="container" style="background: #16a2b8;">
            <div class="modal-header" style="border-bottom-style: none;padding: 0;padding-left: 16px;">
              <h4 class="modal-title">Create Wishlist</h4><button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">×</span></button>
            </div>
            <div class="modal-body" style="text-align: left;padding-bottom: 30px;">
              <form id="form" style="font-family: Quicksand, sans-serif;width: 320px;">
                <div class="form-group"><label>Name (*)</label><input class="form-control formum" type="text" placeholder="BestWishListEver"></div>
                <div class="form-group"><label>Password</label><input class="form-control formum" type="password" placeholder="password" required=""></div>
                <div class="form-group"><label>Due Date</label><input class="form-control" type="date"></div>
              </form>
            </div>
            <div class="modal-footer" style="border-top-style: none;"><label class="w-100" style="text-align: left;">*Required</label>
              <div class="d-flex align-items-center w-100"><button class="btn" type="button" data-dismiss="modal">Cancel</button>
                <div class="d-flex flex-grow-1 justify-content-end"><button class="btn" type="button">Create</button></div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </div>

  </transition>
</template>

<script lang="ts">
import Vue from "vue";
import Component from "vue-class-component";

@Component({
  name: "SolarModal",
  components: {}
})
export default class SolarModal extends Vue {
  close() {
    this.$emit("close");
  }
}
</script>

<style scoped lang="scss">
  @import "./src/assets/scss/global.scss";

.modal-backdrop {
  position: fixed;
  top: 0;
  bottom: 0;
  left: 0;
  right: 0;
  background-color: rgba(0, 0, 0, 0.6);
  display: flex;
  justify-content: center;
  align-items: center;
}

.modal {
  background: #fff;
  box-shadow: 2px 2px 20px 1px;
  overflow-x: auto;
  display: flex;
  flex-direction: column;
  width: 640px;
  border-radius: 3px;
}

.modal-header {
  padding: 15px;
  display: flex;
  background-color: $solar-blue;
  color: #fff;
  font-size: 1.2rem;
  font-weight: bold;
  border-bottom: 1px solid #eee;
  justify-content: space-between;
}

.modal-footer {
  padding: 15px;
  display: flex;
  border-top: 1px solid #eee;
  justify-content: flex-end;
}

.modal-body {
  position: relative;
  padding: 2.4rem;
}

.modal-fade-enter,
.modal-fade-leave-active {
  opacity: 0;
}

.modal-fade-enter-active,
.modal-fade-leave-active {
  transition: opacity 0.5s ease;
}
</style>
