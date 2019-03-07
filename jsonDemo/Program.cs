using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace jsonDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Inicia uma instância do navegador chrome
            IWebDriver driver = new ChromeDriver();

            //Direciona o navegador para o endereço escolhido
            driver.Navigate().GoToUrl("https://demo.redmine.org/");

            //Acessa a opção para cadastro de novo usuário
            driver.FindElement(By.PartialLinkText("Cadastre-se")).Click();

            //Preenche o formulário de criação do usuário
            driver.FindElement(By.Id("user_login")).SendKeys("matheeuspc");
            driver.FindElement(By.Id("user_password")).SendKeys("Teste@2019");
            driver.FindElement(By.Id("user_password_confirmation")).SendKeys("Teste@2019");
            driver.FindElement(By.Id("user_firstname")).SendKeys("Matheus");
            driver.FindElement(By.Id("user_lastname")).SendKeys("Cardoso");
            driver.FindElement(By.Id("user_mail")).SendKeys("matheus.pc@live.com");

            //Envia informações para criação do usuário
            driver.FindElement(By.Name("commit")).Click();
        }
        
    }
}
