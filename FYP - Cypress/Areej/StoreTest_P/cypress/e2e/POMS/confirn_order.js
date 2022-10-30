export class confirm_order {
  click() {
    cy.get("#cart_navigation > .button > span").click();
    cy.get(".box").should("be.visible");
  }
}
