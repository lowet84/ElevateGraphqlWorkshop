import Vue from 'vue'
import Vuex from 'vuex'
import Api from './api'

Vue.use(Vuex)

const state = {
  activePage: '-',
  settings: {}
}

const mutations = {
  setActivePage (state, page) {
    state.activePage = page
  },
  saveSettings (state) {
    console.log(state.settings)
    let query =
      'mutation{saveSettings(}'
    Api(query)
  }
}

const actions = {
}

// getters are functions
const getters = {
}

export default new Vuex.Store({
  state,
  getters,
  actions,
  mutations
})
