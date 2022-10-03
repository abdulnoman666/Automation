/// <reference types = "cypress"/>
it("write file", () => {
  cy.writeFile("writemyfile.txt", "Heloo this is write file\n");
  cy.writeFile("writemyfile.txt", "Heloo this is ", { flag: "a+" });
});
