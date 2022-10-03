export class Loginpage {
  //These are locators so that if some other func want to use it they can be easily used

  username_textbox = "#username";
  password_textbox = "#password";
  Login_button = "#submit";
  enterUsername(username) {
    cy.get(this.username_textbox).type(username);
  }
  enterPassword(password) {
    cy.get(this.password_textbox).type(password);
  }
  clickLogin() {
    cy.get(this.Login_button).click();
  }
}
