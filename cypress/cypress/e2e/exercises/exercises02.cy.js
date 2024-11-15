import HomePage from "../pages/saucedemo/exercises/homePage";
import ProductsOverviewPage from "../pages/saucedemo/exercises/productsOverviewPage";
import ShoppingCartPage from "../pages/saucedemo/exercises/shoppingCartPage";
import CheckoutPage from "../pages/saucedemo/exercises/checkoutPage";
import orderConfirmationPageExercise from "../pages/saucedemo/exercises/orderConfirmationPage";

describe('Exercises 02', () => {

    it('should order an item from the Sauce Demo store', () => {

        /**
         * TODO: Improve the login sequence code by using methods from the HomePage class.
         *   The methods have been defined and implemented for you already.
         */
        //cy.visit('https://www.saucedemo.com')


        new HomePage()
            .visit()
            .loginAs('standard_user', 'secret_sauce')

        /**
         * TODO: Improve adding a product to the cart and going to the cart overview
         *   by using methods from the ProductsOverviewPage class.
         *   The methods have been defined and implemented for you already.
         */


        new ProductsOverviewPage()
            .addBackpackToCart()
            .gotoShoppingCart()

        /**
         * TODO: Improve starting the checkout process by using the correct
         *   method from the ShoppingCartPage class. The method has been defined
         *   for you already, but the right action(s) need(s) to be added still.
         */
        new ShoppingCartPage()
            .gotoCheckout()

        /**
         * TODO: Improve the checkout process by using the correct
         *   method from the CheckoutPage class. The method has been defined
         *   for you already, but the right action(s) need(s) to be added still.
         */
        new CheckoutPage()
            .checkoutOrder()
        /**
         * TODO: Create a new class OrderConfirmationPage and add a method that returns
         *   the order confirmation message. Use that method instead of the direct call
         *   to cy.get() used here.
         *   Don't forget to import your new class here by adding it to the imports at
         *   the top of the file!
         */
        new orderConfirmationPageExercise().confirmOrderMessage()
            .should('be.visible')
            .should('have.text', 'Thank you for your order!')
    })
})