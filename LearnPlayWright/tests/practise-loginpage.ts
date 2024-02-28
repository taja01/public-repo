import { type Locator, type Page } from "@playwright/test";

export class PractiseLoginPage{
    readonly page: Page;
    readonly userNameField: Locator;
    readonly passwordField: Locator;
    readonly submitButton: Locator;

    constructor(page: Page){
        this.page = page;
        this.userNameField = page.locator("#username");
        this.passwordField = page.locator("#password");
        this.submitButton = page.locator("#submit");
    }
}