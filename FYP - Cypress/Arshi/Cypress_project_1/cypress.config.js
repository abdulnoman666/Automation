const { defineConfig } = require("cypress");

module.exports = defineConfig({
  e2e: {
    // If we make changes in file in cypress it will not automatically run
     watchForFileChanges: false, // this will disable the automatic rerun of the test if any change is made in the script
    screenshotOnRunFailure: false,
    video: false,

    setupNodeEvents(on, config) {
      // implement node event listeners here
    },
  },
});
