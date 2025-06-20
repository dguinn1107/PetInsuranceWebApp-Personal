import { fileURLToPath, URL } from 'node:url';
import { defineConfig } from 'vite';
import vue from '@vitejs/plugin-vue';
import fs from 'fs';
import path from 'path';
import child_process from 'child_process';
import { env } from 'process';

// Setup HTTPS certificate directory and files
const baseFolder =
    env.APPDATA && env.APPDATA !== ''
        ? `${env.APPDATA}/ASP.NET/https`
        : `${env.HOME}/.aspnet/https`;
const certName = "petinsuranceproject.client";
const certFile = path.join(baseFolder, `${certName}.pem`);
const keyFile = path.join(baseFolder, `${certName}.key`);

if (!fs.existsSync(baseFolder)) fs.mkdirSync(baseFolder, { recursive: true });
if (!fs.existsSync(certFile) || !fs.existsSync(keyFile)) {
  const result = child_process.spawnSync(
    'dotnet',
    [
      'dev-certs',
      'https',
      '--export-path',
      certFile,
      '--format',
      'Pem',
      '--no-password',
    ],
    { stdio: 'inherit' }
  );
  if (result.status !== 0) throw new Error("Could not create certificate.");
}

// Backend API target (must match launch URL)
const target = 'http://localhost:5089';

export default defineConfig({
  plugins: [vue()],
  resolve: {
    alias: {
      '@': fileURLToPath(new URL('./src', import.meta.url))
    }
  },
  server: {
    https: false,
    port: parseInt(env.DEV_SERVER_PORT || '58096'),
    proxy: {
      '^/api': {
        target,
        secure: false,
        changeOrigin: true
      }
    }
  }
});