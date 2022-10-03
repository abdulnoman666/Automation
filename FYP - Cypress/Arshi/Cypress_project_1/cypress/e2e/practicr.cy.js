/// <reference types = "cypress"/>

it("google search", () => {
  cy.visit("https://google.com");
  // cy.get(".gLFyf").type("web {Enter}");
  cy.get(":nth-child(1) > .gb_d").click();
  cy.get(".feature__buttons > :nth-child(1) > .button > .mobile-tablet-only")
    .should("contain", "Get Gmail")
    .should("be.visible");
  expect(true).to.be.true;
  assert.strictEqual(2, 2, "not");
});
