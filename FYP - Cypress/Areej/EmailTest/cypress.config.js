const path = require("path");
const gmail = require("gmail-tester");
const { defineConfig } = require("cypress");

module.exports = defineConfig({
  e2e: {
    setupNodeEvents(on, config) {
      // implement node event listeners here
      on("task", {
        "gmail:check": async args => {
          const { from, to, subject } = args;
          const email = await gmail.check_inbox(
            path.resolve(__dirname, "credentials.json"), // credentials.json is inside plugins/ directory.
            path.resolve(__dirname, "gmail_token.json"), // gmail_token.json is inside plugins/ directory.
            subject,
            from,
            to,
            10,                                          // Poll interval (in seconds)
            30                                           // Maximum poll interval (in seconds). If reached, return null, indicating the completion of the task().
          );
          return email;
        }
      });
    },
  },
});
