import { createRouter, createWebHistory } from 'vue-router'
import PetInsurance from '../views/PetInsurance.vue'

const routes = [
  { path: '/', name: 'PetInsurance', component: PetInsurance }
]

const router = createRouter({
  history: createWebHistory(),
  routes
})

export default router
