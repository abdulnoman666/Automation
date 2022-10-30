///<reference types= 'cypress'/>
import { register } from "./POMS/already_register";
import { cart_dropdown } from "./POMS/cart_dropdown";
import { woman_tab } from "./POMS/woman_tab";
import { checkout } from "./POMS/checkout_btn";
import { sum_tab } from "./POMS/summary_tab";
import { proceed_cchkbtn } from "./POMS/proceed_to_checkoutbtn";
import { comment } from "./POMS/adding_comments";
import { click_chkout_btn } from "./POMS/click_proceed_chkout_btn";
import { click_ckeckbox } from "./POMS/clik chkbox_proceed_to_checkout";
import { pay_bank } from "./POMS/paybank";
import { confirm_order } from "./POMS/confirn_order";
const reg = new register();
const cart = new cart_dropdown();
const women = new woman_tab();
const check_btn = new checkout();
const summary = new sum_tab();
const proceedbtn = new proceed_cchkbtn();
const cmnt = new comment();
const clk_chk_btn = new click_chkout_btn();
const clk_chk_box = new click_ckeckbox();
const bank = new pay_bank();
const confirm = new confirm_order();

describe("visiting site", () => {
  it("Sign_in", () => {
    cy.visit("http://automationpractice.com/index.php?controller=my-account");
    cy.get("#page").should("contain.text", "Authentication");

    reg.email("iamareej6@gmail.com");
    reg.password("123456789");
    reg.enter();
    cart.cart_click();
    women.click();
    women.adding_items();
    check_btn.click();
    summary.validation();
    proceedbtn.click();
    cmnt.coment();
    clk_chk_btn.click();
    clk_chk_box.click();
    bank.click();
    confirm.click();
  });
  // it("Clicking-Cart", () => {
  //   cart.cart_click();
  // });
  // it("Women Tab", () => {
  //   women.click();
  //   women.adding_items();
  // });
  // it("Checkout_button", () => {
  //   check_btn.click();
  // });
  // it("Summary_tab Validation", () => {
  //   summary.validation();
  // });
});
