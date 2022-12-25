export class login {
  user = "#username ";
  pass = "#password";
  username(e) {
    cy.get('input[type="email" i]').type(e);
  }
  password(p) {
    cy.get(this.pass).type(p);
  }
  click() {
    cy.get("#login").click();
  }
}
