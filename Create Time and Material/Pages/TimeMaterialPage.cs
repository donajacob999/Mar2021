using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Time_and_Material.Pages
{
    class TimeMaterialPage
    {
        public void createTM(IWebDriver driver)
        {
            //***************CREATE NEW RECORD **********

            //Identify and click the Create New Button
            Thread.Sleep(1000);
            IWebElement create_new_button = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
            create_new_button.Click();

            //Validate the Time and Materials page ????

            //Identify and click the Time dropdown
            Thread.Sleep(1500);
            IWebElement typecode = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            typecode.Click();
            IWebElement time = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
            time.Click();

            //Identify and enter the code
            IWebElement code = driver.FindElement(By.Id("Code"));
            code.SendKeys("dona1234");

            //Identify and enter Description
            IWebElement description = driver.FindElement(By.Id("Description"));
            description.SendKeys("dona_time_record");

            //Identify and enter Price per unit
            //There is 2 child under the parent tag, so to avoid exception below 2 steps are added
            IWebElement price = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            price.Click();

            IWebElement price_per_unit = driver.FindElement(By.XPath("//*[@id='Price']"));
            price_per_unit.SendKeys("999");

            // Select Files...

            //Identify and click Save
            IWebElement save = driver.FindElement(By.Id("SaveButton"));
            save.Click();
            Thread.Sleep(1000);

            // Validate the newly created record - go to last page and validate the lately created record
            IWebElement last_page_button = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
            Thread.Sleep(500);
            last_page_button.Click();
            Thread.Sleep(1500);
            IWebElement last_record_description = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
            if (last_record_description.Text == "dona_time_record")
            {
                Console.WriteLine("New record created successfully, TEST PASSED");
            }
            else
            {
                Console.WriteLine("No new record created, TEST FAILED ");
            }

        }
        public void editTM(IWebDriver driver)
        {
            //***************EDITING RECORD - Here editing the typecode, code, description and price for very first record **********
            Thread.Sleep(5000);
            //Identify and go to fist page of records
            IWebElement first_page = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[1]/span"));
            first_page.Click();

            //Identify and click the first edit button
            Thread.Sleep(2000);
            IWebElement edit = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[5]/a[1]"));
            Thread.Sleep(1000);
            edit.Click();

            //Identify and change the dropdown
            IWebElement edit_typecode = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[1]"));
            if (edit_typecode.Text == "Time")
            {
                edit_typecode.Click();
                Thread.Sleep(1000);
                IWebElement edit_material = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[1]"));
                edit_material.Click();
            }
            else
            {
                edit_typecode.Click();
                Thread.Sleep(1000);
                IWebElement edit_time = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
                edit_time.Click();
            }

            //Identify and rewrite the code
            Thread.Sleep(1000);
            IWebElement edit_code = driver.FindElement(By.Id("Code"));
            edit_code.Clear();
            edit_code.SendKeys("EDITED_CODE");

            //Identify and rewrite the description 
            IWebElement edit_description = driver.FindElement(By.Id("Description"));
            edit_description.Clear();
            edit_description.SendKeys("EDITED_description");


            //Identify and rewite the price perunit
            Thread.Sleep(500);
            IWebElement edit_price = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]"));
            edit_price.Click();
            Thread.Sleep(1000);
            IWebElement edit_price_perunit = driver.FindElement(By.XPath("//*[@id='Price']"));
            edit_price_perunit.Clear();
            Thread.Sleep(500);
            edit_price.Click();
            edit_price_perunit.SendKeys("1845");

            //Identify and click Save
            IWebElement edit_save = driver.FindElement(By.XPath("//*[@id='SaveButton']"));
            edit_save.Click();
            Thread.Sleep(2000);

            //Validate the edited record

            IWebElement edited_first_element_description = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[1]/td[3]"));
            Thread.Sleep(1000);
            if (edited_first_element_description.Text == "EDITED_description")
            {
                Console.WriteLine("Edited successfully, TEST PASSED");
            }
            else
            {
                Console.WriteLine("Edit unsuccessful, TEST FAILED");
            }
            
        }
        public void deleteTM(IWebDriver driver)
        {
            //***************DELETING RECORD - Deleting the first record from the table
            //After editing the pointer will be on first page of record
            Thread.Sleep(1000);

            //Identify and click the second delete button from first page of items
            IWebElement delete_button = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[2]/td[5]/a[2]"));
            delete_button.Click();
            Thread.Sleep(1000);

            //Identify and click OK on the popup dialog box
            driver.SwitchTo().Alert().Accept();
            Console.WriteLine("Deleted successfully");

            //verify the item is deleted


            //if(total_item_count == total_item_count-1)
            //{
            //  Console.WriteLine("Deleted succesfully");

            //}

        }
    }
}
