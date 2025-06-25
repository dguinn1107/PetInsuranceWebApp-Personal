<template>
  <div class="modal-backdrop fade show custom-backdrop"></div>
  <div class="modal d-block custom-modal" tabindex="-1">
    <div class="modal-dialog modal-dialog-centered">
      <div class="modal-content modal-alfa">
        <button type="button" class="close-btn" @click="$emit('close')">&times;</button>
        <div class="modal-body">
          <div class="logo-container">
            <img src="@/assets/alfa-logo.png" alt="Alfa Logo" />
          </div>
          <p class="modal-text">Alfa Insurance only insures dogs below the age of 15</p>
        </div>
      </div>
    </div>
  </div>
</template>

<script setup>
const emit = defineEmits(['close']);
</script>

<style scoped>
/* Ensure backdrop covers entire viewport */
.custom-backdrop {
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  z-index: 1040;
}

/* Center modal above everything */
.custom-modal {
  position: fixed;
  top: 0;
  left: 0;
  width: 100%;
  height: 100%;
  z-index: 1050;
  display: flex;
  align-items: center;
  justify-content: center;
}

.modal-alfa {
  background-color: #21759b;
  color: #fff;
  border: none;
  border-radius: 8px;
  position: relative;
  z-index: 1051;
  width: 90%;
  max-width: 500px;
  padding: 2rem 1.5rem;
  text-align: center;
}

.logo-container {
  background-color: #fff;
  padding: 12px;
  border-radius: 4px;
  display: inline-block;
  margin-bottom: 1rem;
}

.close-btn {
  position: absolute;
  top: 1px;
  right: 1px;
  background: transparent;
  color: #fff;
  border: none;
  font-size: 1.5rem;
  line-height: 1;
  cursor: pointer;
}

.modal-text {
  margin-top: 0rem;
}
</style>
