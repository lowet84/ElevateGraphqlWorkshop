<template>
  <div class="phone-viewport">

    <md-toolbar>
      <md-button class="md-icon-button" @click="toggleLeftSidenav">
        <md-icon>menu</md-icon>
      </md-button>

      <h2 class="md-title" style="flex: 1">{{$store.state.activePage}}</h2>
    </md-toolbar>

    <md-sidenav class="md-left" ref="leftSidenav">
      <md-toolbar class="md-large">
        <div class="md-toolbar-container">
          <h3 class="md-title">Listen!</h3>
        </div>
      </md-toolbar>

      <md-list>
        <md-list-item @click="goto('')">
          <md-icon>view_list</md-icon>
          <span>Enter info</span>
        </md-list-item>
      </md-list>
    </md-sidenav>

  </div>
</template>

<script>
export default {
  data () {
    return {
    }
  },
  methods: {
    goto (target) {
      this.$refs.leftSidenav.close()
      this.$router.push('/' + target)
    },
    toggleLeftSidenav () {
      this.$refs.leftSidenav.toggle()
    }
  }
}
</script>

<!-- Add "scoped" attribute to limit CSS to this component only -->
<style scoped>

</style>
