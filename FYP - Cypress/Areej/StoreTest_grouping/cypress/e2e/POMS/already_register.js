export class register {
  e = "#email";
  p = "#passwd";
  c = "#SubmitLogin > span";

  email(m) {
    cy.get(this.e).type(m);
  }
  password(pass) {
    cy.get(this.p).type(pass);
  }
  enter() {
    cy.get(this.c).click();
  }
}
