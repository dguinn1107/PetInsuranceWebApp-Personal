<template>
  <div class="container">
    <h1>Quick Pet Insurance Quote</h1>
    <form @submit.prevent="getQuote">
      <input v-model="form.name" placeholder="Your Name" required />
      <input v-model="form.email" type="email" placeholder="Your Email" required />
      <input v-model="form.petName" placeholder="Pet Name" required />

      <select v-model="form.breed" required>
        <option disabled value="">Select Breed</option>
        <option v-for="breed in breeds" :key="breed">{{ breed }}</option>
      </select>

      <input
        type="number"
        v-model.number="form.age"
        placeholder="Pet Age"
        min="0"
        max="14"
        required
      />

      <button type="submit">Get Quote</button>
    </form>

    <div v-if="quote !== null" class="result">
      <h2>Estimated Monthly Premium:</h2>
      <p>${{ quote }}</p>
    </div>
  </div>
</template>

<script setup>
import { ref } from 'vue'
import axios from 'axios'

const form = ref({ name: '', email: '', petName: '', breed: '', age: 0 })
const breeds = [
  'Labrador Retriever', 'French Bulldog', 'German Shepherd',
  'Golden Retriever', 'Bulldog (English)', 'Beagle',
  'Shih Tzu', 'Chihuahua', 'Rottweiler', 'Poodle (Standard)'
]
const quote = ref(null)

const getQuote = async () => {
  try {
    const res = await axios.post('/api/quote', {
      ownerName: form.value.name,
      ownerEmail: form.value.email,
      petName: form.value.petName,
      petBreed: form.value.breed,
      petAge: form.value.age
    })
    quote.value = res.data.monthlyPremium
  } catch (error) {
    console.error(error)
    alert('Error retrieving quote. Is the server running?')
  }
}
</script>

<style scoped>
.container { max-width: 600px; margin: auto; padding: 2rem; }
input, select, button { width: 100%; margin-top: 0.5rem; padding: 0.6rem; }
.result { margin-top: 1.5rem; padding: 1rem; background: #e0f7fa; border-radius: 5px; }
</style>