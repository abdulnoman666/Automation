export class comment {
  coment() {
    cy.get("#ordermsg > .form-control")
      .type("Comment added successfully")
      .should("be.enabled");
  }
}
