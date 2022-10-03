// provides autocomplete features
/// reference types = "cypress"/>

// evry thing inside 'it' is test if in arorow func it passes it is correct
it("Google Search", () => {
  cy.visit("https://google.com");
  cy.get(".gLFyf", { timeout: 6000 }).type("Automation step by step{Enter}");
  //   cy.contains("Google Search").click();
  cy.contains("Books").click();
});
