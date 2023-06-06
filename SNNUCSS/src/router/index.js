import { createRouter, createWebHistory } from "vue-router";
import HomeView from "../views/HomeView.vue";
import Carousel from "../components/Carousel.vue";
import Intro from "../components/Intro.vue";
import Logos from "../components/Logos.vue";
import ResourceList from "../components/ResourceList.vue";
import ResourceEdit from "../components/ResourceEdit.vue";
import StudentList from "../components/StudentList.vue";
import ResearchResultsList from "../components/ResearchResultsList.vue";


const router = createRouter({
  history: createWebHistory(import.meta.env.BASE_URL),
  routes: [
    {
      path: "/",
      name: "home",
      component: HomeView,
    },
    {
      path: "/about",
      name: "about",
      // route level code-splitting
      // this generates a separate chunk (About.[hash].js) for this route
      // which is lazy-loaded when the route is visited.
      component: () => import("../views/AboutView.vue"),
    },
    {
      path: "/src/components/Carousel.vue",
      name: "Carousel",
      component: Carousel,
    },
    {
      path: "/src/components/Intro.vue",
      name: "Intro",
      component: Intro,
    },
    {
      path: "/src/components/Logos.vue",
      name: "Logos",
      component: Logos,
    },
    {
      path: "/src/components/ResourceList.vue",
      name: "ResourceList",
      component: ResourceList,
    },
    {
      path:"/src/components/ResourceEdit.vue",
      name:"ResourceEdit",
      component:ResourceEdit,
    },
    {
      path:"/src/components/StudentList.vue",
      name:"StudentList",
      component:StudentList,
    },
    {
      path:"/src/components/ResearchResultsList.vue",
      name:"ResearchResultsList",
      component:ResearchResultsList,
    },

    
  ],
});

export default router;
