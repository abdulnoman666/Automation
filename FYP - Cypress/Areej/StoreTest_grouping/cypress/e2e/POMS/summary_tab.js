export class sum_tab {
  validation() {
    cy.get("thead > tr > .cart_product").should("be.visible");
    cy.get("thead > tr > .cart_description").should("be.visible");
    cy.get("thead > tr > .cart_avail").should("be.visible");
    cy.get("thead > tr > .cart_unit").should("be.visible");
    cy.get("thead > tr > .cart_quantity").should("be.visible");
    cy.get("thead > tr > .cart_total").should("be.visible");
    cy.get(".button-exclusive").should("be.visible");
    cy.get(".cart_navigation > .button > span").should("be.visible");
    cy.get(
      ":nth-child(1) > .address > :nth-child(1) > .page-subheading"
    ).should("be.visible");
    cy.get(
      ":nth-child(2) > .address > :nth-child(1) > .page-subheading"
    ).should("be.visible");
    cy.get("#product_3_13_0_755067 > .cart_delete").should("be.visible");
    // cy.get("#\33 _13_0_0 > .icon-trash").should("be.visible");
  }
}
