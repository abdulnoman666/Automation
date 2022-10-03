const { defineConfig } = require("cypress");

module.exports = defineConfig({
  e2e: {
    // If we make changes in file in cypress it will not automatically run
    // watchForFileChanges: false;

    setupNodeEvents(on, config) {
      // implement node event listeners here
    },
  },
});
