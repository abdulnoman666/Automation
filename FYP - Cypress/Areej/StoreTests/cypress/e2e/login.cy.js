
describe("Testing Page", () =>{

before(()=> {
cy.visit("http://automationpractice.com/index.php?controller=my-account")

});
it("Test 1", () =>{
    cy.get('#email').type("iamareej6@gmail.com")
    cy.get('#passwd').type("123456789")
    cy.get('#SubmitLogin > span').click()
   
})

it("Cart DropDown", () =>{
    cy.get('[title="View my shopping cart"]').click()
    })

it("Women Tab", () =>{
    cy.get('.sf-menu > :nth-child(1) > [href="http://automationpractice.com/index.php?id_category=3&controller=category"]').click()
    cy.get('.first-in-line.last-item-of-tablet-line > .product-container > .right-block > .button-container > .ajax_add_to_cart_button > span').click()

})
it("checkout", () =>{
    cy.get('.button-container > .button-medium > span').click()

})

//it("change quantity", () => {

    //cy.get('.icon-plus').click()
    //cy.get('#cart_quantity_up_4_16_0_0 > span')
//})
it("proceed to checkout", () =>{
cy.get('.cart_navigation > .button > span').click()
})

it("proceed to checkout", () =>{
    cy.get('.cart_navigation > .button > span').click()
    })

})