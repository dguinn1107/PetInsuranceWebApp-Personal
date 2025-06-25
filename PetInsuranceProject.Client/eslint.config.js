import { defineConfig, globalIgnores } from 'eslint/config'
import globals from 'globals'
import js from '@eslint/js'
import pluginVue from 'eslint-plugin-vue'
import skipFormattingConfig from '@vue/eslint-config-prettier/skip-formatting';

export default defineConfig([
  {
    name: 'app/files-to-lint',
    files: ['**/*.{js,mjs,jsx,vue}'],
  },

  globalIgnores(['**/dist/**', '**/dist-ssr/**', '**/coverage/**']),

  {
    languageOptions: {
      globals: {
        ...globals.browser,
      },
    },
  },

  js.configs.recommended,
  ...pluginVue.configs['flat/essential'],
])

// import pluginVue from 'eslint-plugin-vue';
// import eslint from '@eslint/js';
// import globals from 'globals';
// import skipFormattingConfig from '@vue/eslint-config-prettier/skip-formatting';

// export default [
//   ...pluginVue.configs['flat/essential'],
//   eslint.configs.recommended,
//   skipFormattingConfig,
//   {
//     rules: {
//       'vue/multi-word-component-names': 'off',
//     },
//     languageOptions: {
//       sourceType: 'module',
//       globals: {
//         ...globals.browser,
//         ...globals.node,
//       },
//     },
//   },
// ];
