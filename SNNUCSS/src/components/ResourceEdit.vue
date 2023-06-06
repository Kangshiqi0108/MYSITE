<script >
import { reactive } from "vue";
import axios from "axios";
export default {
  data() {
    return {
      form: reactive({
        name: "",
        link: "",
      }),
    };
  },
  methods: {
    onsubmit() {
      axios({
        method: "post",
        url: "http://127.0.0.1:8000/exp/relr/",
        name: this.$data.name,
        link: this.$data.link,
      });
    },
  },
};
</script>
<template>
  <!---
  <el-form :model="form" label-width="120px">
    <el-form-item label="NAME">
      <el-input v-model="form.name" />
    </el-form-item>
    <el-form-item label="LINK (PK)">
      <el-input v-model="form.link" />
    </el-form-item>
    <el-form-item>
      <el-button type="primary" @click="onsubmit">Create</el-button>
    </el-form-item>
  </el-form> --->
  <p>Coming Soon</p>
</template>
