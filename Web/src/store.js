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
  async saveSettings (state) {
    let settings = state.settings
    let query =
      `mutation{addElevateItem(firstname:"${settings.firstname}",lastname:"${settings.lastname}",number:${settings.number},colour:"${settings.colour}",text:"${settings.text}"){result{id}}}`
    let result = await Api(query)
    if (result.addElevateItem !== null) {
      state.settings = {}
    }
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
