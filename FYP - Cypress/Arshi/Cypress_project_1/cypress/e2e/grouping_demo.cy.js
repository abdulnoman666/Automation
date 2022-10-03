import { Loginpage } from "./pages/login_page";
const loginpage = new Loginpage();
//t will run before every test
beforeEach(() => {
  cy.visit("https://practicetestautomation.com/practice-test-login/");
});
describe("All Login Tests", () => {
  //valid

  //by using describe we can use .only to run our choice of tests
  it("Login test 1", () => {
    loginpage.enterUsername("student");
    loginpage.enterPassword("Password123");
    loginpage.clickLogin();
    cy.get("#menu-item-20 > a").click();
  });

  //invalid
  it.skip("Login test 2", () => {
    loginpage.enterUsername("");
    loginpage.enterPassword("");
    loginpage.clickLogin();
    cy.get("#menu-item-20 > a").click();
  });
});
it("Login test 3", () => {
  loginpage.enterUsername("student");
  loginpage.enterPassword("Password123");
  loginpage.clickLogin();
  cy.get("#menu-item-20 > a").click();
});
