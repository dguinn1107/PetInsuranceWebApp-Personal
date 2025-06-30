<template>
  <section class="container my-5">
    <!-- Get a Quote Bar (full‐width 88px) -->
    <div class="get-quote-bar mb-1">
      <div class="get-quote-inner d-flex">
        <!-- Left Icon -->
        <div class="icon-wrapper d-flex justify-content-center">
          <div class="icon-circle d-flex align-items-center justify-content-center">
            <img
              src="@/assets/images/AlfieHangOver.png"
              alt="Quote Icon"
              class="icon-img"
            />
          </div>
        </div>

        <!-- Text -->
        <div class="d-flex align-items-center text-wrapper">
          <span>Switch to Alfa for insurance savings.</span>
        </div>

        <div class="flex-grow-1"></div>

        <!-- Auto Dropdown -->
        <div class="dropdown-wrapper">
          <select
            v-model="insuranceType"
            class="form-select"
          >
            <option value="Auto">Auto</option>
            <option value="Homeowners">Homeowners</option>
            <option value="Renters">Renters</option>
            <option value="Pet">Pet</option>
          </select>
          <i class="fas fa-chevron-down dropdown-icon"></i>
        </div>

        <!-- Zip Code -->
        <div class="ml-3 zip-wrapper">
          <input
            v-model="zipCode"
            type="text"
            placeholder="Zip Code"
            class="form-control"
          />
        </div>

        <!-- Get a Quote Button -->
        <div class="ml-3 button-wrapper">
          <button
            @click.prevent="getQuote"
            class="btn btn-primary"
          >
            Get a Quote
          </button>
        </div>
      </div>
    </div>

    <!-- Breadcrumb Trail -->
    <div class="breadcrumb-container">
      <a href="https://www.alfainsurance.com/" class="breadcrumb-link">Home</a>
      <span class="breadcrumb-separator">›</span>
      <a href="https://www.alfainsurance.com/insurance" class="breadcrumb-link">Insurance</a>
      <span class="breadcrumb-separator">›</span>
      <span class="breadcrumb-current">Pet Insurance</span>
    </div>

    <!-- Pet Insurance Intro -->
    <div class="pet-intro-container text-center mb-5">
      <h1 class="pet-insurance-title mb-2">Pet Insurance with Alfa®</h1>
      <div class="pet-intro-text">
        Whether you're a first-time pet parent or have years of experience caring
        for furry companions, you need pet insurance from a provider you can trust
        to protect your beloved animals. Alfa is here to guide you through the
        coverage options that fit your needs—so you can focus on the cuddles, not
        the costs.
      </div>
    </div>

    <!-- Image and Why Pet Insurance -->
    <div class="row mb-5">
      <div class="col-md-6 text-center image-container">
        <img
          src="@/assets/images/Dog_Image.png"
          alt="Petting a Dog"
          class="img-fluid rounded"
        />
      </div>
      <div class="col-md-6 d-flex align-items-center text-block">
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
/* Get a Quote Bar */
.get-quote-bar {
  width: 100%;
  height: 50px;
  background: #f6f6f6;
  position: relative;
  overflow: visible;
}

.get-quote-inner {
  width: 772px;
  height: 50px;
  margin: 0 auto;
  display: flex;
  align-items: center;
}

.icon-wrapper { width: 134px; height: 88px; }
.icon-circle {
  width: 88px;
  height: 88px;
  border-radius: 50%;
  background: #287D9F;
}
.icon-img { width: 134px; height: 88px; }
.text-wrapper { width: 276px; height: 50px; }

/* only disable native arrow on the pet dropdown */
.dropdown-wrapper {
  width: 156px;
  height: 31px;
  position: relative;
}
.dropdown-wrapper .form-select {
  -webkit-appearance: none;
  -moz-appearance: none;
  appearance: none;
  background-image: none;
  padding-right: 2rem;
}
.dropdown-icon {
  position: absolute;
  top: 50%;
  right: 0.5rem;
  transform: translateY(-50%);
  pointer-events: none;
}

.zip-wrapper { width: 156px; height: 31px; }
.button-wrapper { width: 136px; height: 40px; }

/* Breadcrumb */
.breadcrumb-container {
  width: 1140px;
  height: 47px;
  margin: 0 auto 2rem;
  padding: 16px 15px;
  display: flex;
  align-items: center;
  gap: 10px;
}
.breadcrumb-link,
.breadcrumb-separator,
.breadcrumb-current {
  font-family: 'Core Sans N';
  font-weight: 300;
  font-size: 12px;
  line-height: 125%;
}
.breadcrumb-link { color: #333; text-decoration: none; }
.breadcrumb-separator { color: #333; }
.breadcrumb-current { color: #757575; }

/* Intro */
.pet-intro-container { width: 100%; height: 216px; }
.pet-insurance-title {
  font-family: 'Core Sans N';
  font-weight: 300;
  font-size: 64px;
  color: #C30717;
}
.pet-intro-text {
  width: 1074px;
  height: 120px;
  margin: 0 auto;
  font-family: 'Core Sans N';
  font-weight: 300;
  font-size: 24px;
  line-height: 125%;
  text-align: center;
  color: #333;
  display: flex;
  align-items: center;
  justify-content: center;
}

/* Image & Why */
.image-container { width: 635px; height: 620px; }
.text-block { width: 445px; height: 620px; }

/* other Bootstrap‐based sections inherit their styling */
</style>
