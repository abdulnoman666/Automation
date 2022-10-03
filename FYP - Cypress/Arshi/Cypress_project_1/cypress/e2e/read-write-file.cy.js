//const { data } = require("cypress/types/jquery");
before(function () {
  cy.fixture("example.json").as("test_data");
});

//then is func that is used to chain.enables to work
//with output from the previous command
it("Read Files using Fixture", () => {
  cy.fixture("example.json").then((data) => {
    cy.log(data.name);
    cy.log(data.email);
    cy.log(data.body);
    // cy.fixture("example.json").its("name").assert("eq", "example.json");
  });

  //   cy.log(this.test_data.email);
});

it("Read file using readfile", () => {
  cy.readFile("./cypress/fixtures/example.json").then((data) => {
    cy.log(data.name);
  });
});
