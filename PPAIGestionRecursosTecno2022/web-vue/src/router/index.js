import Vue from 'vue'
import VueRouter from 'vue-router'
import HelloWorld from '@/components/HelloWorld'
import InicioSesion from '@/components/IniciarSesion'
import MantenimientoCorrectivo from '../components/MantenimientoCorrectivo/MantenimientoCorrectivo.vue'

Vue.use(VueRouter)

const routes = [
    {
        path: '/HelloWorld',
        name: 'HelloWorld',
        component: HelloWorld
    },
    {
        path: '/InicioSesion',
        name: 'InicioSesion',
        component: InicioSesion
    },
    {
        path: '/MantenimientoCorrectivo',
        name: 'MantenimientoCorrectivo',
        component: MantenimientoCorrectivo
    }
]

const router = new VueRouter({
    mode: 'history',
    base: process.env.BASE_URL,
    routes
  })
  
  export default router