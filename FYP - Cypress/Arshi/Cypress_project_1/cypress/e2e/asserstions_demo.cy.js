//asserstions are checkpionts or verification
//These are implicit assertion as they are built-in (should,and)
//contain ---> refer to text
//have --->look for attributes
//and for chained assertion
it("Asserstions Demo", () => {
  cy.visit("https://example.cypress.io");
  cy.contains("get").click();
  cy.get("#query-btn")
    .should("contain", "Button")
    .and("have.class", "query-btn")
    .and("be.visible")
    .and("be.enabled");

  //EXPICIT ASSERTION (expect,assert)
  //if answer is true we wont be seeing anything in locks
  expect(true).to.be.true;
  //   expect(true).to.be.false;

  //   assert.equal(4, 5, "NOT EQUAL");
  //   assert.equal(4, "4", "NOT EQUAL");
  assert.equal(4, "4", "NOT EQUAL");
  assert.strictEqual(4, "4", "NOT EQUAL");
});
