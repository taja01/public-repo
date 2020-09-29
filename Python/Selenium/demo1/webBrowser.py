from selenium import webdriver
driver = webdriver.Chrome()
driver.maximize_window()

driver.get("https://www.seleniumeasy.com/test/basic-first-form-demo.html")

single_input = driver.find_element_by_id("user-message")
single_input.send_keys("python")

single_button = driver.find_element_by_css_selector("#get-input .btn-default")
single_button.click()

message = driver.find_element_by_id("display")
assert "python" in message.text

driver.quit()
