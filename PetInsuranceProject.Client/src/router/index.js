// src/router/index.js
import { createRouter, createWebHistory } from 'vue-router'
import PetInsurance from '@/views/PetInsurance.vue'
import QuickQuote   from '@/views/QuickQuote.vue'

const routes = [
  {
    path: '/',                // ← this must be the “home” route
    name: 'PetInsurance',
    component: PetInsurance,
  },
  {
    path: '/quick-quote',
    name: 'QuickQuote',
    component: QuickQuote,
  },
  // (remove any catch-all or redirect that points "/" to QuickQuote)
]

export default createRouter({
  history: createWebHistory(),
  routes,
})
