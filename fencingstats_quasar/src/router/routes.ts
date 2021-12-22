import { RouteRecordRaw } from 'vue-router';

const routes: RouteRecordRaw[] = [
  {
    path: '/',
    component: () => import('layouts/MainLayout.vue'),
    children: [{ path: '', component: () => import('pages/Index.vue') }],
  },
 
  
  // Always leave this as last one,
  // but you can also remove it
  {
    path: '/:catchAll(.*)*',
    component: () => import('pages/Error404.vue'),
  },
  {
    path: '/:catchAll(.*)*',
    component: () => import('pages/login.vue'),
  },
  {
    path: '/:catchAll(.*)*',
    component: () => import('pages/register.vue'),
  },
  

];

export default routes;
