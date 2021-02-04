import { Environment } from '@abp/ng.core';

const baseUrl = 'http://localhost:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Ims',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'https://localhost:44395',
    /* issuer: 'https://23v9c19764.oicp.vip', */
    redirectUri: baseUrl,
    clientId: 'Ims_App',
    responseType: 'code',
    scope: 'offline_access Ims',
  },
  apis: {
    default: {
      url: 'https://localhost:44395',
      /* url: 'https://23v9c19764.oicp.vip', */
      rootNamespace: 'Kuanfang.Ims',
    },
  },
} as Environment;
