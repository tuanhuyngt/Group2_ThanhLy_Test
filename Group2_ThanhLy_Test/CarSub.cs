using Group2_ThanhLy_Test.BaseClass;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace Group2_ThanhLy_Test
{
    public class CarSub : BaseTest
    {
        IWebElement ele;
        string str;
        IWebElement txtNguoiMua, txtLyDo, txtSotien, btnLuu, pLoaiTimKiem, liMa, liBienSo, liNamSX, liHang;

        void GetElement()
        {
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-car/app-car-management-group5/div/div/div[1]/div/ul/li[4]"));
            ele.Click();
            Thread.Sleep(200);
            txtNguoiMua = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-car-sub/app-car-sub-group2/div/div[2]/div/div[1]/form/div/div[1]/div[1]/input"));
            txtLyDo = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-car-sub/app-car-sub-group2/div/div[2]/div/div[1]/form/div/div[2]/textarea"));
            txtSotien = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-car-sub/app-car-sub-group2/div/div[2]/div/div[1]/form/div/div[1]/div[2]/input"));
            btnLuu = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-car-sub/app-car-sub-group2/div/div[2]/div/div[1]/div/div/div/form/div/div/ul/li[2]"));
            pLoaiTimKiem = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-car-sub/app-car-sub-group2/div/div[2]/div/div[2]/p-multiselect"));
            liMa = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-car-sub/app-car-sub-group2/div/div[2]/div/div[2]/p-multiselect/div/div[4]/div[2]/ul/li[1]"));
            liBienSo = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-car-sub/app-car-sub-group2/div/div[2]/div/div[2]/p-multiselect/div/div[4]/div[2]/ul/li[3]"));
            liNamSX= webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-car-sub/app-car-sub-group2/div/div[2]/div/div[2]/p-multiselect/div/div[4]/div[2]/ul/li[6]"));
            liHang = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-car-sub/app-car-sub-group2/div/div[2]/div/div[2]/p-multiselect/div/div[4]/div[2]/ul/li[5]"));
        }

        [Test, Category("CarSearch"), Order(1)]
        public void txtTimKiemMaCheck()
        {
            this.NagativeToManagement();
            this.GetElement();
            pLoaiTimKiem.Click();
            Thread.Sleep(300);
            liMa.Click();
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-car-sub/app-car-sub-group2/div/div[2]/div/form/div/input"));
            ele.SendKeys("2");
            ele.SendKeys(Keys.Enter);
            Thread.Sleep(500);
        }
        [Test, Category("CarSearch"), Order(2)]
        public void txtTimKiemBienSoCheck()
        {
            pLoaiTimKiem.Click();
            Thread.Sleep(300);
            liMa.Click();
            Thread.Sleep(300);
            liBienSo.Click();
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-car-sub/app-car-sub-group2/div/div[2]/div/form/div/input"));
            ele.SendKeys("8");
            ele.SendKeys(Keys.Enter);
            Thread.Sleep(400);
        }
        [Test, Category("CarSearch"), Order(3)]
        public void txtTimKiemNamSXCheck()
        {
            pLoaiTimKiem.Click();
            Thread.Sleep(300);
            liBienSo.Click();
            Thread.Sleep(300);
            liNamSX.Click();
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-car-sub/app-car-sub-group2/div/div[2]/div/form/div/input"));
            ele.SendKeys("2018");
            ele.SendKeys(Keys.Enter);
            Thread.Sleep(400);
        }
        [Test, Category("CarSearch"), Order(4)]
        public void txtTimKiemHangCheck()
        {
            pLoaiTimKiem.Click();
            Thread.Sleep(300);
            liNamSX.Click();
            Thread.Sleep(300);
            liHang.Click();
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-car-sub/app-car-sub-group2/div/div[2]/div/form/div/input"));
            ele.SendKeys("Kia");
            ele.SendKeys(Keys.Enter);
            Thread.Sleep(400);
        }

        [Test, Category("RightInputCarSub"), Order(5)]
        public void txtNguoiMuaCheck()
        {
            this.NagativeToManagement();
            this.GetElement();
            txtNguoiMua.SendKeys("Tuấn Huy");
            str = txtNguoiMua.GetAttribute("value");
            Assert.AreEqual("Tuấn Huy", str);
        }
        [Test, Category("RightInputCarSub"), Order(6)]
        public void txtSoTienCheck()
        {
            txtSotien.SendKeys("2oio000000000");
            str = txtSotien.GetAttribute("value");
            Assert.AreEqual("2000000000", str);
        }
        [Test, Category("RightInputCarSub"), Order(7)]
        public void txtLyDoCheck()
        {
            txtLyDo.SendKeys("Đây là lý do");
            str = txtLyDo.GetAttribute("value");
            Assert.AreEqual("Đây là lý do", str);
        }
        [Test, Category("RightInputCarSub"), Order(8)]
        public void modalXacNhanCheck()
        {
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-car-sub/app-car-sub-group2/div/div[2]/div/div[3]/div/p-table/div/div/table/tbody/tr[2]/td[1]/label"));
            ele.Click();
            btnLuu.Click();
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-car-sub/app-car-sub-group2/div/p-dialog/div/div[2]"));
            str = ele.Text;
            Assert.AreEqual("Xác nhận thanh lý xe?", str);
        }

        [Test, Category("RightInputCarSub"), Order(9)]
        public void cancelXacnhan()
        {
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-car-sub/app-car-sub-group2/div/p-dialog/div/div[3]/p-footer/button[2]"));
            ele.Click();
        }
        [Test, Category("RightInputCarSub"), Order(10)]
        public void confirmXacNhanCheck()
        {
            btnLuu.Click();
            ele = webDriver.FindElement(By.XPath("/html/body/app-root/ng-component/div/div/div[2]/app-car-sub/app-car-sub-group2/div/p-dialog/div/div[3]/p-footer/button[1]"));
            ele.Click();
            ele = webDriver.FindElement(By.ClassName("toast-message"));
            str = ele.Text;
            Assert.AreEqual("Thanh lý thành công", str);
        }
    }
}