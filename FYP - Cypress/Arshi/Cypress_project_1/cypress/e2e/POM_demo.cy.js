//POM objs and methods seperate from test script
import { Loginpage } from "./pages/login_page";
const loginpage = new Loginpage();
it("POM DEMO", () => {
  cy.visit("https://practicetestautomation.com/practice-test-login/");
  loginpage.enterUsername("student");
  loginpage.enterPassword("Password123");
  loginpage.clickLogin();

  //   cy.get("#username").type("student");
  //   cy.get("#password").type("Password123");
  //   cy.get("#submit").click();
});
