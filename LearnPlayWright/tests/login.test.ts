import { chromium, test } from "@playwright/test";
import { PractiseLoginPage } from "./practise-loginpage";


test('getting started should contain table of contents', async ({ page }) => {
   console.log(process.env.ALMA)
   console.log(process.env.URL)
   console.log(process.env.ENV)

   // const practiseLoginPage = new PractiseLoginPage(page)

   // await practiseLoginPage.page.goto("https://practicetestautomation.com/practice-test-login/")

   // await practiseLoginPage.userNameField.fill(process.env.ALMA)
   // await practiseLoginPage.passwordField.fill("Password123")

   // await practiseLoginPage.submitButton.click()

   // await practiseLoginPage.page.waitForURL("**\/logged-in-successfully/")
})