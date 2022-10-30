export class cart_dropdown {
  cart = '[title="View my shopping cart"]';
  cart_click() {
    cy.get(this.cart).click();

    //assertion about cart is empty
    cy.get("#columns").should("contain.text", "Your shopping cart is empty");
  }
}
