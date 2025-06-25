<template>
  <header aria-label="website header" class="v2-nav">
    <nav
      id="minor-nav"
      class="container-lg position-relative bg-white d-flex justify-content-end align-items-center gap-4 py-2"
      aria-label="utility navigation"
    >
      <div class="d-none d-lg-block">
        <a
          tabindex="0"
          class="d-flex flex-lg-column justify-content-end align-items-center gap-1 text-dark py-2 text-decoration-none"
          role="button"
          data-bs-toggle="popover"
          data-bs-trigger="focus"
          data-bs-custom-class="popover-contact-us"
          data-bs-container="body"
          data-bs-placement="bottom"
          data-bs-content="&lt;div class='text-center fs-8'&gt;&lt;div class='popover-content__row'&gt;Call us at &lt;a href='tel:1-800-964-2532'&gt;1-800-964-2532&lt;/a&gt;&lt;/div&gt;&lt;div class='popover-content__row'&gt;Mon – Fri, 6:00 am – 10:00 pm CST&lt;/div&gt;&lt;div class='popover-content__row'&gt;Saturday, 7:00 am – 9:00 pm CST&lt;/div&gt;&lt;div class='popover-content__row'&gt;Sunday, Closed&lt;/div&gt;&lt;/div&gt;"
          data-bs-html="true"
        >
          <i class="fa-solid fa-phone-alt" aria-hidden="true"></i>
          <span>Contact Us</span>
        </a>
      </div>

      <a
        class="d-flex flex-lg-column justify-content-end align-items-center text-dark py-2 gap-1 text-decoration-none"
        id="login_button"
        role="button"
        aria-label="toggle log in box"
        tabindex="0"
        data-bs-toggle="modal"
        data-bs-target="#modal-container"
      >
        <div class="login__image">
          <svg xmlns="http://www.w3.org/2000/svg" width="15" height="15" viewBox="0 0 22 22" fill="none">
            <path d="M11 21C16.5228 21 21 16.5229 21 11C21 5.47715 16.5228 1 11 1C5.47715 1 1 5.47715 1 11C1 16.5229 5.47715 21 11 21Z" stroke="black" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"/>
            <path d="M11.0002 11.8186C12.8762 11.8186 14.397 10.2979 14.397 8.42193C14.397 6.54597 12.8762 5.02522 11.0002 5.02522C9.12428 5.02522 7.60352 6.54597 7.60352 8.42193C7.60352 10.2979 9.12428 11.8186 11.0002 11.8186Z" stroke="black" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"/>
            <path d="M4.07129 18.0948C4.07129 14.8968 6.21043 12.2017 9.12726 11.3795M12.8268 11.3667C15.7672 12.1733 17.9289 14.88 17.9289 18.0949" stroke="black" stroke-width="2" stroke-linecap="round" stroke-linejoin="round"/>
          </svg>
        </div>
        <span>Log In</span>
      </a>
    </nav>

    <nav class="main-nav navbar navbar-expand-lg p-0">
      <div class="container-lg justify-content-lg-start position-relative">
        <a
          class="navbar-brand v2-nav__logo me-5 align-self-stretch"
          href="https://www.alfainsurance.com/"
          aria-label="company logo"
        >
          <img
            src="@/assets/images/alfa-logo.png"
            class="img-fluid py-4"
            alt="Alfa Insurance Logo"
          />
        </a>

        <div class="-desktop-nav justify-content-start align-items-baseline gap-4 d-none d-lg-flex">
          <ul class="navbar-nav">
            <li class="nav-item dropdown">
              <a
                class="nav-link dropdown-nav-link font-bold py-4 px-0 text-black-50"
                href="https://www.alfainsurance.com/insurance"
                role="button"
                aria-expanded="false"
              >
                Insurance
              </a>
              <ul class="dropdown-menu rounded-0">
                <li class="dropdown-item">
                  <a
                    class="w-100 h-100 d-block text-decoration-none sub-nav-link"
                    href="https://www.alfainsurance.com/insurance/auto-insurance"
                    >Auto</a
                  >
                </li>
                <li class="dropdown-item">
                  <a
                    class="w-100 h-100 d-block text-decoration-none sub-nav-link"
                    href="https://www.alfainsurance.com/insurance/home-and-property-insurance"
                    >Home and Property</a
                  >
                </li>
                <li class="dropdown-item">
                  <a
                    class="w-100 h-100 d-block text-decoration-none sub-nav-link"
                    href="https://www.alfainsurance.com/insurance/life-insurance"
                    >Life</a
                  >
                </li>
                <li class="dropdown-item">
                  <a
                    class="w-100 h-100 d-block text-decoration-none sub-nav-link"
                    href="https://www.alfainsurance.com/insurance/farm-insurance"
                    >Farm</a
                  >
                </li>
                <li class="dropdown-item">
                  <a
                    class="w-100 h-100 d-block text-decoration-none sub-nav-link"
                    href="https://www.alfainsurance.com/insurance/business-and-commercial-insurance"
                    >Business &amp; Commercial</a
                  >
                </li>
                <li class="dropdown-item">
                  <a
                    class="w-100 h-100 d-block text-decoration-none sub-nav-link"
                    href="https://www.alfahealth.net/"
                    >Health</a
                  >
                </li>
                <li class="dropdown-item">
                  <a
                    class="w-100 h-100 d-block text-decoration-none sub-nav-link"
                    href="https://www.alfainsurance.com/insurance/other-insurance"
                    >Other</a
                  >
                </li>
              </ul>
            </li>
          </ul>
          <ul class="navbar-nav">
            <li class="nav-item dropdown">
              <a
                class="nav-link dropdown-nav-link font-bold py-4 px-0 text-black-50"
                href="https://www.alfainsurance.com/claims/start-your-claim"
                role="button"
                aria-expanded="false"
              >
                Claims
              </a>
              <ul class="dropdown-menu rounded-0">
                <li class="dropdown-item">
                  <a
                    class="w-100 h-100 d-block text-decoration-none sub-nav-link"
                    href="https://www.alfainsurance.com/claims/start-your-claim"
                    >Start Your Claim</a
                  >
                </li>
                <li class="dropdown-item">
                  <a
                    class="w-100 h-100 d-block text-decoration-none sub-nav-link"
                    href="https://www.alfainsurance.com/claims/understanding-claims-process"
                    >Claims Process</a
                  >
                </li>
                <li class="dropdown-item">
                  <a
                    class="w-100 h-100 d-block text-decoration-none sub-nav-link"
                    href="https://www.alfainsurance.com/claims/severe-storm-center"
                    >Severe Storm Center</a
                  >
                </li>
              </ul>
            </li>
          </ul>
          <ul class="navbar-nav">
            <li class="nav-item dropdown">
              <a
                class="nav-link dropdown-nav-link font-bold py-4 px-0 text-black-50"
                href="https://www.alfainsurance.com/news-and-insights"
                role="button"
                aria-expanded="false"
              >
                Tools &amp; Tips
              </a>
              <ul class="dropdown-menu rounded-0">
                <li class="dropdown-item">
                  <a
                    class="w-100 h-100 d-block text-decoration-none sub-nav-link"
                    href="https://ipn2.paymentus.com/ropp/alfa"
                    >Make a Payment</a
                  >
                </li>
                <li class="dropdown-item">
                  <a
                    class="w-100 h-100 d-block text-decoration-none sub-nav-link"
                    href="https://www.alfainsurance.com/myalfa-account-support/payment-options"
                    >Payment Options</a
                  >
                </li>
                <li class="dropdown-item">
                  <a
                    class="w-100 h-100 d-block text-decoration-none sub-nav-link"
                    href="https://www.alfainsurance.com/myalfa-account-support"
                    >MyAlfa Account Support</a
                  >
                </li>
                <li class="dropdown-item">
                  <a
                    class="w-100 h-100 d-block text-decoration-none sub-nav-link"
                    href="https://www.alfainsurance.com/news-and-insights"
                    >News and Insights</a
                  >
                </li>
                <li class="dropdown-item">
                  <a class="w-100 h-100 d-block text-decoration-none sub-nav-link" href="https://www.alfainsurance.com/faq"
                    >FAQs</a
                  >
                </li>
                <li class="dropdown-item">
                  <a
                    class="w-100 h-100 d-block text-decoration-none sub-nav-link"
                    href="https://www.alfainsurance.com/mobile-app"
                    >Mobile App</a
                  >
                </li>
              </ul>
            </li>
          </ul>
          <ul class="navbar-nav">
            <li class="nav-item dropdown">
              <a
                class="nav-link dropdown-nav-link font-bold py-4 px-0 text-black-50"
                href="https://www.alfainsurance.com/about-alfa"
                role="button"
                aria-expanded="false"
              >
                About Alfa
              </a>
              <ul class="dropdown-menu rounded-0">
                <li class="dropdown-item">
                  <a
                    class="w-100 h-100 d-block text-decoration-none sub-nav-link"
                    href="https://www.alfainsurance.com/about-alfa/the-alfa-difference"
                    >The Alfa Difference</a
                  >
                </li>
                <li class="dropdown-item">
                  <a
                    class="w-100 h-100 d-block text-decoration-none sub-nav-link"
                    href="http://alfafarmers.org/"
                    target="_blank"
                    >Alabama Farmers Federation</a
                  >
                </li>
                <li class="dropdown-item">
                  <a
                    class="w-100 h-100 d-block text-decoration-none sub-nav-link"
                    href="https://www.alfainsurance.com/about-alfa/membership"
                    >Membership</a
                  >
                </li>
                <li class="dropdown-item">
                  <a
                    class="w-100 h-100 d-block text-decoration-none sub-nav-link"
                    href="https://www.alfainsurance.com/about-alfa/careers"
                    >Careers</a
                  >
                </li>
                <li class="dropdown-item">
                  <a
                    class="w-100 h-100 d-block text-decoration-none sub-nav-link"
                    href="https://www.alfainsurance.com/about-alfa/contact-us"
                    >Contact Us</a
                  >
                </li>
              </ul>
            </li>
          </ul>
          <div
            class="nav-item bg-primary d-flex flex-column align-items-center p-4 position-relative d-lg-none"
          >
            <a
              class="position-absolute top-50 start-50 translate-middle w-100 h-100"
              href="https://www.alfainsurance.com/about-alfa/contact-us"
            ></a>
            <span class="font-bold text-white fs-5">Contact Us</span>
            <a
              class="position-absolute top-50 start-50 translate-middle w-100 h-100"
              href="https://www.alfainsurance.com/about-alfa/contact-us"
              data-text="1-800-964-2532"
            ></a>
            <span class="text-white fs-6">1-800-964-2532</span>
          </div>
          <div
            class="nav-item bg-primary d-flex flex-column align-items-center p-4 position-relative d-lg-none"
          >
            <figure class="mb-0" style="max-width: 25px">
              <img
                src=""
                alt="Login"
                class="img-fluid"
              />
            </figure>
            <a
              class="position-absolute top-50 start-50 translate-middle w-100 h-100"
              href="https://www.alfainsurance.com/myalfa/login"
              data-text="Log In"
            ></a>
            <span class="font-bold text-white fs-6">Log In</span>
          </div>
        </div>
      </div>
    </nav>
  </header>
</template>

<style lang="scss">
.main-nav.navbar {
  border-bottom: 3px solid #c30717;

  @media (min-width: 992px) {
    border-top: 1px solid #ccc;
  }
}

@media (min-width: 992px) {
  #minor-nav .login__image {
    height: 15px;
  }
}
</style>
