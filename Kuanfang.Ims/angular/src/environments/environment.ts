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
    issuer: 'http://s239r19764.wicp.vip:23180',
    redirectUri: baseUrl,
    clientId: 'Ims_App',
    responseType: 'code',
    scope: 'offline_access Ims',
    requireHttps:false,
  },
  apis: {
    default: {
      url: 'http://s239r19764.wicp.vip:23180',
      rootNamespace: 'Kuanfang.Ims',
    },
  },
} as Environment;
