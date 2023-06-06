<script>
import axios from "axios";
import { Memo, Medal, School, Sunrise } from "@element-plus/icons-vue";

export default {
  methods: {
    handleOpen: (key, keyPath) => {
      console.log(key, keyPath);
    },
    handleClose: (key, keyPath) => {
      console.log(key, keyPath);
    },
  },
  components: {},
};
</script>

<template>
  <div class="common-layout">
    <el-container>
      <el-header class="headertag">
        <img src="/src/img/logo.png" />
      </el-header>
      <el-container>
        <el-aside>
          <el-row class="tac">
            <el-col :span="17">
              <h5 class="mb-2">
                <br />
                <br />
                <p class="menutag">Site Menu</p>
              </h5>
              <el-menu
                default-active="2"
                class="el-menu-vertical-demo"
                @open="handleOpen"
                @close="handleClose"
              >
                <el-sub-menu index="1">
                  <template #title>
                    <el-icon><School /></el-icon>
                    <span>Overview</span>
                  </template>
                  <el-menu-item-group title="Overview">
                    <el-menu-item index="1-1">
                      <router-link to="/src/components/Carousel.vue"
                        >Display</router-link
                      >
                    </el-menu-item>
                    <el-menu-item index="1-2">
                      <router-link to="/src/components/Intro.vue"
                        >Intro</router-link
                      >
                    </el-menu-item>
                    <el-menu-item index="1-3">
                      <router-link to="/src/components/Logos.vue"
                        >Logos</router-link
                      >
                    </el-menu-item>
                  </el-menu-item-group>
                </el-sub-menu>
                <el-sub-menu index="2">
                  <template #title>
                    <el-icon><Sunrise /></el-icon>
                    <span>Students</span>
                  </template>
                  <el-menu-item-group title="Students">
                    <el-menu-item index="1-1">
                      <router-link to="/src/components/StudentList.vue">
                        StudentList
                      </router-link>
                    </el-menu-item>
                  </el-menu-item-group>
                </el-sub-menu>
                <el-sub-menu index="3">
                  <template #title>
                    <el-icon><Medal /></el-icon>
                    <span>Research Results</span>
                  </template>
                  <el-menu-item-group title="Research Results">
                    <el-menu-item index="1-1">
                      <router-link to="/src/components/ResearchResultsList.vue"
                        >ResearchResultList</router-link
                      >
                    </el-menu-item>
                  </el-menu-item-group>
                </el-sub-menu>
                <el-sub-menu index="4">
                  <template #title>
                    <el-icon><Memo /></el-icon>
                    <span>Related Resources</span>
                  </template>
                  <el-menu-item-group title="Related Resources">
                    <el-menu-item index="1-1">
                      <router-link to="/src/components/ResourceList.vue"
                        >ResourceList</router-link
                      >
                    </el-menu-item>
                    <el-menu-item index="1-2">
                      <router-link to="/src/components/ResourceEdit.vue"
                        >Edit</router-link
                      >
                    </el-menu-item>
                  </el-menu-item-group>
                </el-sub-menu>
              </el-menu>
            </el-col>
            <el-col> </el-col>
          </el-row>
        </el-aside>
        <el-main width="400px">
          <router-view></router-view>
        </el-main>
      </el-container>
    </el-container>
    <el-footer>
      <el-divider content-position="left"></el-divider>
      <div class="Nav">
        <h4>Quick Navigation</h4>
        <el-divider content-position="left"
          >Shaan'xi Normal University School of Computer Science</el-divider
        >
        <div>
          <el-link href="https://bb.snnu.edu.cn" type="default"
            >BlackBoard</el-link
          >
          <el-link href="https://cet.neea.edu.cn/" type="default"
            >CETtest</el-link
          >
          <el-link href="https://ccs.snnu.edu.cn/" type="default"
            >SNNU CSS</el-link
          >
          <el-link
            href="https://v1.chaoxing.com/backSchool/toLogin"
            type="default"
            >XUEXITONG</el-link
          >
        </div>
      </div>
      <div class="Contact">
        <h4>Contact</h4>
        <h6>
          Address: No. 620, West Chang'an Street, Chang'an District, Xi'an,
          Shaanxi Province
        </h6>
        <h6>Postcode: 710119</h6>
        <h6>Telephone:029-85310161</h6>
        <h6>Fax: 029-85310661</h6>
      </div>
      <div class QRcode>
        <h3>Wechat</h3>
        <img src="/src/img/WeChat.jpg" alt="Contact Us" />
      </div>
    </el-footer>
  </div>
</template>

<style scoped>
.menutag {
  font-size: large;
}
.el-link {
  margin-right: 8px;
}
.el-link .el-icon--right.el-icon {
  vertical-align: text-bottom;
}
</style>
