class ShoppingCartPage {

    gotoCheckout() {
        /**
         * TODO: implement the method so that it actually navigates to the checkout page.
         */
        cy.get('button#checkout').click()

        cy.get('input#first-name').type('Jane')
        cy.get('input#last-name').type('Doe')
        cy.get('input#postal-code').type('90210')
        cy.get('input#continue').click()
        cy.get('button#finish').click()
    }
}

export default ShoppingCartPage