<template>
  <section class="container my-5">
    <!-- Get a Quote Bar (full‐width 88px) -->
    <div class="get-quote-bar mb-1">
      <div class="get-quote-inner d-flex">
        <!-- Left Icon -->
        <div class="icon-wrapper d-flex justify-content-center">
            <img
              src="@/assets/images/AlfieHangOver.png"
              alt="Quote Icon"
              class="icon-img"
            />
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
          <router-link to="/quick-quote" class="btn btn-primary">
        Get a Quote
      </router-link>
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
    <div class="dog-why-section mb-5">
  <!-- Left: Dog Image -->
  <div class="dog-image-wrapper">
    <img
      src="@/assets/images/Dog_Image.png"
      alt="Petting a Dog"
      class="dog-img"
    />
  </div>
  <!-- Right: Why Pet Insurance text -->
  <div class="why-text-wrapper">
    <div class="why-title">Why get pet insurance?</div>
    <div class="why-paragraph">
      When your pet is sick or injured, the last thing you want to do is worry
      about money. Insurance gives you the freedom to make decisions based on
      what’s best for your pet—not your wallet.
    </div>
  </div>
</div>

    <!-- Coverage Highlights -->
    <div class="coverage-section">
  <div class="coverage-title">Our Pet Insurance Covers</div>
  <div class="coverage-container">
    <div class="coverage-item">
      <div class="coverage-icon">
        <img src="@/assets/images/injury.png" alt="Injury" />
      </div>
      <div class="coverage-item-title">Injury</div>
      <div class="coverage-item-desc">
        Unexpected accidents like broken bones, cuts, or swallowed
        objects, ensuring your pet gets the emergency care they need
        without delay.
      </div>
    </div>
    <div class="coverage-item">
      <div class="coverage-icon">
        <img src="@/assets/images/illness.png" alt="Illness" />
      </div>
      <div class="coverage-item-title">Illness</div>
      <div class="coverage-item-desc">
        Supports treatment for common and serious health conditions
        such as allergies, infections, or chronic diseases like
        diabetes or cancer.
      </div>
    </div>
   <div class="coverage-item">
      <div class="coverage-icon">
        <img src="@/assets/images/wellness.png" alt="Wellness" />
      </div>
      <div class="coverage-item-title">Wellness</div>
      <div class="coverage-item-desc">
        Focuses on preventive care, covering routine checkups,
        vaccinations, flea and tick prevention, and dental cleanings
        to keep your pet healthy year-round.
      </div>
    </div>
  </div>
</div>

    <!-- Homeowners plus pets banner -->
<section class="homeowners-banner">
  <!-- dark background layer -->
  <div class="banner-bg banner-bg-dark"></div>
  <!-- light‐blue overlay -->
  <div class="banner-bg banner-bg-light"></div>
  <!-- content on top -->
  <div class="banner-content">
    <div class="banner-title">Homeowners Plus Pets</div>
    <div class="banner-desc">
      Pet insurance is available with an Alfa homeowners policy
    </div>
    <div class="bundle-images">
      <img src="@/assets/images/house.png" alt="House" />
      <img src="@/assets/images/plus.png" alt="Plus" />
      <img src="@/assets/images/dog.png" alt="Dog" />
    </div>
  </div>
</section>

    <!-- Coverage Cards Section -->
<div class="coverage-cards">
  <div class="coverage-container">
    <!-- Card 1: Injury & Illness -->
    <div class="coverage-card">
      <div class="coverage-icons">
        <img src="@/assets/images/injury.png" alt="Injury Icon" />
        <img src="@/assets/images/illness.png" alt="Illness Icon" />
      </div>
      <div class="coverage-content">
        <div class="coverage-card-title">Injury and Illness Coverage</div>
        <div class="coverage-card-desc">
          This plan helps cover the cost of unexpected accidents and a wide range of illnesses—from broken bones and swallowed objects to infections, allergies, and chronic conditions. It’s designed to support your pet’s health when they need medical attention the most.
        </div>
      </div>
    </div>
    <!-- Card 2: Injury & Illness + Wellness -->
    <div class="coverage-card">
      <div class="coverage-icons">
        <img src="@/assets/images/injury.png" alt="Injury Icon" />
        <img src="@/assets/images/illness.png" alt="Illness Icon" />
        <img src="@/assets/images/skinnyplus.png" alt="Plus Icon" class="plus-icon" />
        <img src="@/assets/images/wellness.png" alt="Wellness Icon" />
      </div>
      <div class="coverage-content">
        <div class="coverage-card-title">Injury and Illness + Wellness Coverage</div>
        <div class="coverage-card-desc">
          This comprehensive plan includes everything in the Injury &amp; Illness coverage, plus routine and preventive care like annual exams, vaccinations, flea and tick prevention, and dental cleanings. It’s a proactive approach to keeping your pet healthy and happy year-round.
        </div>
      </div>
    </div>

  </div>
</div>

<!-- Find an Agent Banner -->
<section class="find-agent-section">
  <!-- map on the left -->
  <img
    src="@/assets/images/agentmap.png"
    alt="Agent Map"
    class="agent-map"
  />

  <!-- content on the right -->
  <div class="find-agent-content">
    <div class="agent-input-group">
      <label class="agent-label">Find an Agent:</label>
      <input
        v-model="agentZip"
        type="text"
        placeholder="Zip Code"
        class="agent-zip-input"
      />
    </div>
    <button @click.prevent="findAgent" class="go-button">Go</button>
  </div>
</section>
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
    },
    findAgent() {
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
.icon-img { width: 88px; height: 88px; }
.text-wrapper { width: 276px; height: 50px; }
.dropdown-wrapper, .zip-wrapper, .button-wrapper{
  display: flex;
  align-items: center;
}
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
.zip-wrapper {
  width: 156px;
  height: 31px;
}
.button-wrapper {
  width: 136px;
  height: 40px;
}
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
.dog-why-section {
  width: 1110px;
  height: 620px;
  margin: 0 auto 2rem;
  display: flex;
  gap: 30px;
}
/* Left side: fixed-size dog image */
.dog-image-wrapper {
  width: 635px;
  height: 620px;
  overflow: hidden;
}
.dog-image-wrapper .dog-img {
  width: 635px;
  height: 620px;
  object-fit: cover;
}
/* Right side: text, centered vertically & horizontally */
.why-text-wrapper {
  width: 445px;
  height: 620px;
  display: flex;
  flex-direction: column;
  align-items: center;
  justify-content: center;
  text-align: center;
  background: #D7E9F4;
}
/* Title styling */
.why-title {
  width: 365px;
  height: 35px;
  font-family: 'Core Sans N';
  font-weight: 400;
  font-size: 28px;
  line-height: 125%;
  letter-spacing: 0;
  color: #333333;
}
/* Paragraph styling */
.why-paragraph {
  width: 375px;
  height: 125px;
  font-family: 'Core Sans N';
  font-weight: 300;
  font-size: 20px;
  line-height: 125%;
  letter-spacing: 0;
  color: #333333;
  margin-top: 20px;
}
.coverage-section {
  width: 1110px;
  height: 440px;
  margin: 0 auto 2rem;
  padding: 24px 0;
  display: flex;
  flex-direction: column;
  gap: 40px;
}
.coverage-title {
  width: 410px;
  height: 45px;
  margin: 0 auto;
  font-family: 'Core Sans N';
  font-weight: 300;
  font-size: 36px;
  line-height: 125%;
  text-align: center;
  color: #333333;
}
.coverage-container {
  width: 1110px;
  height: 307px;
  margin: 0 auto;
  display: flex;
  gap: 30px;
}
.coverage-item {
  flex: 1;
  display: flex;
  flex-direction: column;
  align-items: center;
  gap: 16px;
}
.coverage-icon {
  width: 120px;
  height: 120px;
}
.coverage-icon img {
  width: 100%;
  height: 100%;
}
.coverage-item-title {
  font-family: 'Core Sans N';
  font-weight: 400;
  font-size: 24px;
  line-height: 125%;
  text-align: center;
  color: #333333;
}
.coverage-item-desc {
  font-family: 'Core Sans N';
  font-weight: 300;
  font-size: 20px;
  line-height: 125%;
  text-align: center;
  color: #333333;
}
   .homeowners-banner {
  position: relative;
  width: 1200px;
  height: 423px;
  margin: 2rem auto;
}
/* background layers: both fill the banner */
.banner-bg {
  position: absolute;
  top: 0;
  left: 0;
  width: 1200px;
  height: 423px;
  background-size: cover;
  background-position: center;
}
/* your two supplied PNGs */
.banner-bg-dark {
  background-image: url('@/assets/images/darkbackground.png');
  z-index: 0;
}
.banner-bg-light {
  background-image: url('@/assets/images/lightbackground.png');
  z-index: 1;
}
/* content wrapper */
.banner-content {
  position: absolute;
  top: 101px;
  left: 128px;
  width: 945px;
  display: flex;
  flex-direction: column;
  align-items: center;
  gap: 16px;
  z-index: 2;
}
/* title */
.banner-title {
  font-family: 'Core Sans N';
  font-weight: 900;
  font-size: 40px;
  line-height: 125%;
  text-align: center;
  color: #333333;
}
/* description */
.banner-desc {
  width: 945px;
  font-family: 'Core Sans N';
  font-weight: 300;
  font-size: 32px;
  line-height: 125%;
  text-align: center;
  color: #333333;
}
/* icons row */
.bundle-images {
  display: flex;
  align-items: center;
  gap: 16px;
}
.bundle-images img:nth-child(1) {
  width: 146px;
  height: 104px;
}
.bundle-images img:nth-child(2) {
  width: 21.44px;
  height: 21.44px;
}
.bundle-images img:nth-child(3) {
  width: 105px;
  height: 104px;
}
/* Coverage Cards Section */
.coverage-cards {
  width: 920px;
  height: 407px;
  margin: 0 auto 2rem;
}
.coverage-container {
  display: flex;
  gap: 30px;
  width: 100%;
  height: 100%;
}
/* Individual card styling */
.coverage-card {
  flex: 1 1 445px;
  max-width: 445px;
  height: 100%;
  border: 2px solid #999999;
  border-radius: 20px;
  padding: 24px;
  box-sizing: border-box;
  display: flex;
  flex-direction: column;
  gap: 30px;
}
/* Icons row */
.coverage-icons {
  display: flex;
  align-items: center;
  gap: 4px;
}
.coverage-icons img:not(.plus-icon) {
  width: 68px;
  height: 68px;
}
.coverage-icons .plus-icon {
  width: 20px;
  height: 20px;
}
/* Title + description */
.coverage-content {
  display: flex;
  flex-direction: column;
  gap: 24px;
}
.coverage-card-title {
  width: 397px;
  font-family: 'Core Sans N';
  font-weight: 600;
  font-size: 28px;
  line-height: 125%;
  letter-spacing: 0;
  color: #333333;
}
.coverage-card-desc {
  width: 397px;
  font-family: 'Core Sans N';
  font-weight: 300;
  font-size: 20px;
  line-height: 125%;
  letter-spacing: 0;
  color: #333333;
}
/* Find an Agent Banner */
.find-agent-section {
  position: relative;
  width: 1140px;
  height: 222px;
  margin: 2rem auto;
  background-color: #fafafa;
}
.agent-map {
  position: absolute;
  top: 0;
  left: 0;
  width: 268.05px;
  height: 222px;
  object-fit: cover;
}
.find-agent-content {
  position: absolute;
  top: 83px;
  left: 275.24px;
  width: 621.35px;
  height: 56px;
  display: flex;
  align-items: center;
  gap: 24px;
}
.agent-input-group {
  display: flex;
  align-items: center;
  gap: 24px;
  width: 487px;
  height: 35px;
}
.agent-label {
  font-family: 'Core Sans N';
  font-weight: 400;
  font-size: 28px;
  line-height: 125%; /* ~35px */
  color: #287D9F;
}
.agent-zip-input {
  width: 264px;
  height: 35px;
  font-family: 'Core Sans N';
  font-weight: 300;
  font-size: 16px;
  line-height: 150%;
  color: #333333;
  border: none;
  border-bottom: 1px solid #333333;
}
.agent-zip-input::placeholder {
  font-family: 'Core Sans N';
  font-weight: 300;
  font-size: 16px;
  line-height: 150%;
  color: #333333;
}
.go-button {
  width: 94px;
  height: 56px;
  border-radius: 5px;
  padding: 18px 36px;
  font-family: 'Core Sans N';
  font-weight: 400;
  font-size: 16px;
  line-height: 125%;
  color: #ffffff;
  background: #287D9F;
  border: none;
  cursor: pointer;
}
/* other Bootstrap‐based sections inherit their styling */
</style>