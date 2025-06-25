<template>
  <div class="p-4 text-white w-100" style="max-width: 400px;">
    <h2>Get a Pet Insurance Quote</h2>
    <form @submit.prevent="onSubmit" class="quote-form">
      <div class="mb-3">
        <input v-model="form.name" type="text" class="form-control" placeholder="Your Name" required />
      </div>
      <div class="mb-3">
        <input v-model="form.email" type="email" class="form-control" placeholder="Your Email" required />
      </div>
      <div class="mb-3">
        <input v-model="form.petName" type="text" class="form-control" placeholder="Pet Name" required />
      </div>
      <div class="mb-3">
        <select v-model="form.breed" class="form-select" required>
          <option disabled value="">Select Breed</option>
          <option v-for="b in breeds" :key="b">{{ b }}</option>
        </select>
      </div>
      <div class="mb-3">
        <input
          v-model.number="form.age"
          type="number"
          class="form-control"
          placeholder="Pet Age"
          @input="checkAge"
          required
        />
      </div>
      <button type="submit" class="btn btn-light w-100">Get Started</button>
    </form>

    <div v-if="quote !== null" class="alert alert-light mt-3">
      Estimated monthly premium: <strong>${{ quote }}</strong>
    </div>
  </div>
</template>

<script setup>
import { ref, inject } from 'vue';
import axios from 'axios';

// Modal state from parent
const showModal = inject('showModal');

const form = ref({ name: '', email: '', petName: '', breed: '', age: null });
const breeds = [
  'Labrador Retriever', 'French Bulldog', 'German Shepherd',
  'Golden Retriever','Bulldog (English)','Beagle',
  'Shih Tzu','Chihuahua','Rottweiler','Poodle (Standard)'
];
const quote = ref(null);

const checkAge = () => {
  if (form.value.age > 14) {
    showModal.value = true;
    form.value.age = null;
  }
};

const onSubmit = async () => {
  const res = await axios.post('/api/quote', {
    ownerName: form.value.name,
    ownerEmail: form.value.email,
    petName: form.value.petName,
    petBreed: form.value.breed,
    petAge: form.value.age,
  });
  quote.value = res.data.monthlyPremium;
};
</script>
