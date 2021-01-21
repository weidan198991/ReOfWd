const ENV = {
  dev: {
    apiUrl: 'http://s239r19764.wicp.vip:23180',
    oAuthConfig: {
      issuer: 'http://s239r19764.wicp.vip:23180',
      clientId: 'Ims_App',
      clientSecret: '1q2w3e*',
      scope: 'offline_access Ims',
    },
    localization: {
      defaultResourceName: 'Ims',
    },
  },
  prod: {
    apiUrl: 'http://s239r19764.wicp.vip:23180',
    oAuthConfig: {
      issuer: 'http://s239r19764.wicp.vip:23180',
      clientId: 'Ims_App',
      clientSecret: '1q2w3e*',
      scope: 'offline_access Ims',
    },
    localization: {
      defaultResourceName: 'Ims',
    },
  },
};

export const getEnvVars = () => {
  // eslint-disable-next-line no-undef
  return __DEV__ ? ENV.dev : ENV.prod;
};
