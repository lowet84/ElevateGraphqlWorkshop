<template>
  <div>
    <form novalidate @submit.stop.prevent="submit">
      <md-input-container>
        <label>First name</label>
        <md-input v-model="settings.firstname"></md-input>
      </md-input-container>

      <md-input-container>
        <label>Last name</label>
        <md-input v-model="settings.lastname"></md-input>
      </md-input-container>

      <md-input-container>
        <label>Any number (0-1000)</label>
        <md-input type="number" v-model="settings.number"></md-input>
      </md-input-container>

      <md-input-container>
        <label>Favourite colour</label>
        <md-input v-model="settings.colour"></md-input>
      </md-input-container>

      <md-input-container>
        <label>Free text</label>
        <md-input v-model="settings.text"></md-input>
      </md-input-container>
    </form>
    <md-button class="md-primary" @click="save">Submit</md-button>
  </div>
</template>

<script>
import { mapMutations, mapState } from 'vuex'
export default {
  data () {
    return {
      timer: null
    }
  },
  created () {
    this.setActivePage('Enter info')
  },
  computed: {
    ...mapState(['settings'])
  },
  methods: {
    ...mapMutations([
      'setActivePage', 'saveSettings']),
    save () {
      this.saveSettings()
    }
  }
}
</script>

<style scoped>

</style>
