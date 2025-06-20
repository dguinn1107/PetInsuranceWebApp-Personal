<template>
  <header class="site-header">
    <nav class="navbar">
      <a href="https://www.alfainsurance.com/" target="_blank" rel="noopener" class="brand-link">
        <img src="@/assets/alfa-logo.png" alt="Alfa Insurance" class="logo" />
      </a>
    </nav>
  </header>

  <section class="hero">
    <div class="hero-image">
      <img src="@/assets/petting-dog.jpg" alt="Petting a Dog" />
    </div>
    <div class="hero-form">
      <h2>Get a Pet Insurance Quote</h2>
      <form @submit.prevent="getQuote" class="quote-form">
        <input v-model="form.name" type="text" placeholder="Your Name" required />
        <input v-model="form.email" type="email" placeholder="Your Email" required />
        <input v-model="form.petName" type="text" placeholder="Pet Name" required />
        <select v-model="form.breed" required>
          <option disabled value="">Select Breed</option>
          <option v-for="breed in breeds" :key="breed">{{ breed }}</option>
        </select>
        <input
          v-model="form.age"
          type="text"
          placeholder="Pet Age"
          @input="checkAge"
          required
        />
        <button type="submit" class="btn-get-quote">Get Started</button>
      </form>
      <div v-if="quote !== null" class="quote-result">
        <p>Your estimated monthly premium is <strong>${{ quote }}</strong></p>
      </div>
    </div>
  </section>

  <AgeModal v-if="showModal" @close="showModal = false" />
</template>

<script setup>
import { ref } from 'vue';
import axios from 'axios';
import AgeModal from '@/components/AgeModal.vue';

const form = ref({ name: '', email: '', petName: '', breed: '', age: '' });
const breeds = [
  'Labrador Retriever','French Bulldog','German Shepherd',
  'Golden Retriever','Bulldog (English)','Beagle',
  'Shih Tzu','Chihuahua','Rottweiler','Poodle (Standard)'
];
const quote = ref(null);
const showModal = ref(false);

const checkAge = (event) => {
  const age = parseInt(event.target.value, 10);
  if (age > 14) {
    showModal.value = true;
    form.value.age = '';
  }
};

const getQuote = async () => {
  if (!form.value.age) return;
  try {
    const res = await axios.post('/api/quote', {
      ownerName:  form.value.name,
      ownerEmail: form.value.email,
      petName:    form.value.petName,
      petBreed:   form.value.breed,
      petAge:     parseInt(form.value.age, 10)
    });
    quote.value = res.data.monthlyPremium;
  } catch (err) {
    console.error(err);
    alert(err.response?.data || 'Error retrieving quote.');
  }
};
</script>

<style scoped>
html, body, #app {
  height: 100vh;
  margin: 0;
  padding: 0;
  display: flex;
  flex-direction: column;
  background: #fff;
}
.site-header {
  flex: 0;
  width: 100%;
  box-shadow: 0 2px 4px rgba(0,0,0,0.1);
}
.hero {
  display: flex;
  flex: 1;
  width: 100%;
  margin: 0;
  padding: 0;
}
.hero-image {
  flex: 1;
  height: auto;
}
.hero-image img {
  width: 100%;
  height: 100%;
  object-fit: cover;
}
.hero-form {
  background: #21759b;
  color: #fff;
  padding: 2rem;
  flex: 1;
  display: flex;
  flex-direction: column;
  justify-content: center;
}
.quote-form {
  display: flex;
  flex-direction: column;
  gap: 1rem;
}
.quote-form input,
.quote-form select {
  padding: 0.75rem;
  border: none;
  border-radius: 4px;
}
.btn-get-quote {
  background: #fff;
  color: #21759b;
  padding: 0.75rem;
  border: none;
  border-radius: 4px;
  font-weight: bold;
  cursor: pointer;
}
.quote-result {
  margin-top: 1.5rem;
  background: rgba(255,255,255,0.2);
  padding: 1rem;
  border-radius: 4px;
}
</style>