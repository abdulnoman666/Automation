export class prac_page {
  users = ":nth-child(1) > :nth-child(2) > input";
  passs = ":nth-child(2) > :nth-child(2) > input";
  clicks = ":nth-child(3) > td > input";
  user(u) {
    cy.get(this.users).type(u);
  }
  pass(p) {
    cy.get(this.passs).type(p);
  }
  click() {
    cy.get(this.clicks).click();
  }
}
