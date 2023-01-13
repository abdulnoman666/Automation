describe("New user registration", async function() {
    it("Register Form: Email is delievered", function() {
      const test_id = new Date().getTime();
      const incoming_mailbox = `test+${test_id}@gmail.com`;
      cy
        .task("gmail:check", {
          from: "no-reply@domain.com",
          to: incoming_mailbox,
          subject: "Confirm your account"
        })
        .then(email => {
          assert.isNotNull(email, `Email was not found`);
        });
    });
  });