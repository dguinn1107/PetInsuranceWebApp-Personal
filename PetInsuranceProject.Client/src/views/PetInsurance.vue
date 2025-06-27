<template>
  <section class="container my-5">
    <!-- Get a Quote Bar -->
    <div class="d-flex align-items-center mx-auto mb-5" style="width:1200px; height:88px; background: #f6f6f6;">
      <!-- Left Icon -->
      <div style="width:134px; height:88px; display:flex; align-items:center; justify-content:center;">
        <div style="width:88px; height:88px; border-radius:50%; background:#287D9F; display:flex; align-items:center; justify-content:center;">
          <img
          src="@/assets/images/AlfieHangOver.png"
          alt="Quote Icon"
          style="width:134px; height:88px;" />
        </div>
      </div>
      <!-- Text -->
      <div class="d-flex align-items-center" style="width:276px; height:50px;">
        <span>Switch to Alfa for insurance savings.</span>
      </div>
      <!-- Spacer -->
      <div class="flex-grow-1"></div>
      <!-- Auto Dropdown -->
      <div style="width:156px; height:31px;">
        <select v-model="insuranceType" class="form-control" style="width:100%; height:100%;">
          <option value="Auto">Auto</option>
          <option value="Homeowners">Homeowners</option>
          <option value="Renters">Renters</option>
          <option value="Pet">Pet</option>
        </select>
      </div>
      <!-- Zip Code -->
      <div class="ml-3" style="width:156px; height:31px;">
        <input v-model="zipCode" type="text" placeholder="Zip Code" class="form-control" style="width:100%; height:100%;" />
      </div>
      <!-- Get a Quote Button -->
      <div class="ml-3" style="width:136px; height:40px;">
        <button @click.prevent="getQuote" class="btn btn-primary" style="width:100%; height:100%;">Get a Quote</button>
      </div>
    </div>

    <!-- Pet Insurance Intro -->
    <div class="text-center mb-5">
      <h1 class="display-4">Pet Insurance with Alfa®</h1>
      <p class="lead">Pet insurance…</p>
    </div>

    <!-- Image and Why Pet Insurance -->
    <div class="row mb-5">
      <div class="col-md-6 text-center" style="width:635px; height:620px;">
        <img
          src="@/assets/images/petting-dog.jpg"
          alt="Petting a Dog"
          class="img-fluid rounded"
          style="width:100%; height:100%; object-fit:cover;"
        />
      </div>
      <div class="col-md-6 d-flex align-items-center" style="width:445px; height:620px;">
        <div>
          <h3>Why get pet insurance?</h3>
          <p>
            When your pet is sick or injured, the last thing you want to do is worry
            about money. Insurance helps you get the best care without worrying about
            the cost.
          </p>
        </div>
      </div>
    </div>

    <!-- Coverage Highlights -->
    <div class="row text-center mb-5">
      <div class="col-md-4 mb-4">
        <div class="p-4 border rounded">
          <i class="fas fa-paw fa-3x mb-3"></i>
          <h5 class="font-weight-bold">Injury</h5>
          <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque nec.</p>
        </div>
      </div>
      <div class="col-md-4 mb-4">
        <div class="p-4 border rounded">
          <i class="fas fa-heartbeat fa-3x mb-3"></i>
          <h5 class="font-weight-bold">Illness</h5>
          <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque nec.</p>
        </div>
      </div>
      <div class="col-md-4 mb-4">
        <div class="p-4 border rounded">
          <i class="fas fa-thermometer-half fa-3x mb-3"></i>
          <h5 class="font-weight-bold">Wellness</h5>
          <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque nec.</p>
        </div>
      </div>
    </div>

    <!-- Homeowners plus pets banner -->
    <div class="bg-light py-5 text-center mb-5">
      <h2>Homeowners plus pets</h2>
      <p class="mb-0">Pet insurance is available with an Alfa homeowners policy</p>
    </div>

    <!-- Detailed Coverage Cards -->
    <div class="row mb-5">
      <div class="col-md-6 mb-4">
        <div class="card h-100">
          <div class="card-body">
            <h5 class="card-title">Injury and Illness Coverage</h5>
            <p class="card-text">Lorem ipsum dolor sit amet. Tincidunt lectus purus nec.</p>
          </div>
        </div>
      </div>
      <div class="col-md-6 mb-4">
        <div class="card h-100">
          <div class="card-body">
            <h5 class="card-title">Injury and Illness + Wellness Coverage</h5>
            <p class="card-text">Lorem ipsum dolor sit amet. Tincidunt lectus purus nec.</p>
          </div>
        </div>
      </div>
    </div>

    <!-- Find an Agent Row -->
    <div class="row align-items-center py-4 bg-primary text-white rounded">
      <div class="col-md-8">
        <h4>Find an Agent:</h4>
      </div>
      <div class="col-md-4">
        <form class="form-inline" @submit.prevent="findAgent">
          <input
            v-model="agentZip"
            type="text"
            class="form-control mr-2"
            placeholder="Zip Code"
          />
          <button type="submit" class="btn btn-light">Go</button>
        </form>
      </div>
    </div>
  </section>
</template>

<script>
export default {
  name: 'PetInsuranceSections',
  data() {
    return {
      insuranceType: 'Pet',
      zipCode: '',
      agentZip: ''
    };
  },
  methods: {
    getQuote() {
      // implement quote logic
    },
    findAgent() {
      // implement agent search logic
    }
  }
};
</script>

<style scoped>
/* All sizing & layout handled via inline styles and Bootstrap */
</style>
