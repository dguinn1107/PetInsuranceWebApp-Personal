<template>
  <div class="row g-0 flex-grow-1">
    <div class="col-md-7 p-0">
      <img
        src="@/assets/petting-dog.jpg"
        class="img-fluid w-100 h-100"
        style="object-fit: cover;"
        alt="Petting Dog"
      />
    </div>
    <div class="col-md-5 bg-primary d-flex align-items-center">
      <QuoteForm />
    </div>
  </div>
</template>

<script setup>
import QuoteForm from '@/components/QuoteForm.vue';
</script>

<style scoped>
.quote-form input,
.quote-form select {
  padding: 0.75rem;
  border: none;
  border-radius: 4px;
}
</style>