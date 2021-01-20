import { Environment } from '@abp/ng.core';

const baseUrl = 'http://192.168.31.160:4200';

export const environment = {
  production: false,
  application: {
    baseUrl,
    name: 'Ims',
    logoUrl: '',
  },
  oAuthConfig: {
    issuer: 'http://192.168.31.160:44395',
    redirectUri: baseUrl,
    clientId: 'Ims_App',
    responseType: 'code',
    scope: 'offline_access Ims',
  },
  apis: {
    default: {
      url: 'http://192.168.31.160:44395',
      rootNamespace: 'Kuanfang.Ims',
    },
  },
} as Environment;
