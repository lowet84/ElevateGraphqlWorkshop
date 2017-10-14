<template>
  <div id="app">
    <div>
      <listen-menu />
      <router-view class="main"></router-view>
    </div>
  </div>
</template>

<script>
export default {
  name: 'app',
  created () {
  }
}
</script>

<style>
.main {
  margin: 10px;
}
</style>
