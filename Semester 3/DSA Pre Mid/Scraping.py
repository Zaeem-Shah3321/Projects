from selenium import webdriver
from bs4 import BeautifulSoup
import pandas as pd
from selenium.webdriver.chrome.service import Service
from selenium.webdriver.common.by import By
import time
import os
import re
import keyboard

service = Service(
    executable_path=r"F:\DSA\Week 3\chromedriver-win64\chromedriver-win64/chromedriver.exe"
)
options = webdriver.ChromeOptions()
options.add_argument('--ignore-certificate-errors')
options.add_argument('--ignore-ssl-errors')

driver = webdriver.Chrome(service=service, options=options)

driver.get("https://www.shopclues.com/mens-clothing.html?page=2")
driver.set_page_load_timeout(30)  # 30 seconds timeout

csv_file = "daab.csv"
file_exists = os.path.exists(csv_file)

# Write header if the file does not exist
if not file_exists:
    with open(csv_file, "a", encoding="utf-8") as f:
        f.write('"Product","Price","Discount","Pattern","Color"\n')

# Function to load more items and write data to CSV directly
def load_more_items():
    while True:
        try:
            # Locate the "Load More" button
            load_more_button = driver.find_element(By.CSS_SELECTOR, "a#moreProduct.btn.btn_effect")
            load_more_button.click()
            time.sleep(5)  # Wait for new items to load
            
            # Check for keyboard input to stop scraping
            if keyboard.is_pressed('a'):  # If 'a' is pressed
                print("Stopping the scraping as 'a' was pressed.")
                break
            
            # Now parse the page content
            content = driver.page_source
            soup = BeautifulSoup(content, features="html.parser")

            for item in soup.find_all(class_='column col4'):
                product = item.find(class_='prod_name')
                price = item.find(class_='p_price')
                discount = item.find(class_='prd_discount')  
                old_price = item.find(class_='old_prices')

                if product and price:
                    product_name = product.get_text(strip=True)
                    product_price = price.get_text(strip=True)
                    old_price_text = old_price.get_text(strip=True) if old_price else "0"

                    # Clean price and remove commas, but don't re-add them
                    cleaned_price = product_price.replace("₹", "").replace(",", "").strip()
                    cleaned_old_price = old_price_text.replace("₹", "").replace(",", "").strip()

                    if discount:
                        discount_text = discount.get_text(strip=True)
                        # Extract numeric part of the discount using regex
                        discount_numeric = re.search(r'\d+', discount_text)
                        product_discount = discount_numeric.group() + '% OFF' if discount_numeric else '0% OFF'
                    else:
                        product_discount = '0% OFF'  # Store '0% OFF' if discount is not found

                    # Extract 'prints & patterns' and 'color family'
                    hover_info = item.find(class_='hover')  # The div where the ul resides
                    pattern = None  # Initialize as None
                    color = None  # Initialize as None

                    if hover_info:
                        ul = hover_info.find('ul')
                        if ul:
                            li_items = ul.find_all('li')
                            for li in li_items:
                                if "prints & patterns" in li.get_text():
                                    pattern = li.get_text().split(':')[-1].strip()
                                if "color family" in li.get_text():
                                    color = li.get_text().split(':')[-1].strip()

                    # Assign default values only if not found
                    if pattern is None:
                        pattern = "printed"
                    if color is None:
                        color = "multicolor"

                    # Enclose each entry in double quotes
                    product_name = f'"{product_name}"'
                    cleaned_price = f'"{cleaned_price}"'  # Use cleaned price without commas
                    product_discount = f'"{product_discount}"'  # Now it will be '0% OFF' if not found
                    cleaned_old_price = f'"{cleaned_old_price}"'
                    pattern = f'"{pattern}"'  # Will be "Plain" if not found
                    color = f'"{color}"'  # Will be "Any Color" if not found

                    # Write data directly to CSV
                    with open(csv_file, "a", encoding="utf-8") as f:
                        f.write(f'{product_name},{cleaned_price},{product_discount},{pattern},{color}\n')

        except Exception as e:
            print("No more items to load or an error occurred:", e)
            break

load_more_items()

driver.quit()
