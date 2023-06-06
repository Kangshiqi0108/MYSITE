<script>
export default {
  data() {
    return {
      superurl: [
        {
          url: "",
          img: "/src/img/p1.jpg",
        },
        {
          url: "",
          img: "/src/img/92.jpg",
        },
        {
          url: "",
          img: "/src/img/p2.jpg",
        },
        {
          url: "",
          img: "/src/img/12.jpg",
        },
      ],
    };
  },
};
</script>
<template>
  <div class="carousel">
    <el-carousel :interval="4000" type="card" height="240px">
      <el-carousel-item v-for="(item, index) in superurl" :key="index">
        <img :src="item.img" />
      </el-carousel-item>
    </el-carousel>
  </div>
</template>
