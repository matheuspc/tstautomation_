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
        public static void Main(string[] args)
        {
            //Inicia uma instância do navegador chrome
            IWebDriver driver = new ChromeDriver();

            //Direciona o navegador para o endereço escolhido
            driver.Navigate().GoToUrl("http://demo.redmine.org");

            //Acessa a opção para cadastro de novo usuário
            driver.FindElement(By.PartialLinkText("Cadastre-se")).Click();

            //Preenche o formulário de criação do usuário
            driver.FindElement(By.Id("user_login")).SendKeys("xxylfas");
            driver.FindElement(By.Id("user_password")).SendKeys("Teste@2019");
            driver.FindElement(By.Id("user_password_confirmation")).SendKeys("Teste@2019");
            driver.FindElement(By.Id("user_firstname")).SendKeys("xxylfas");
            driver.FindElement(By.Id("user_lastname")).SendKeys("asfasd");
            driver.FindElement(By.Id("user_mail")).SendKeys("xxylfas.pc@live.com");


            //Envia informações para criação do usuário
            driver.FindElement(By.Name("commit")).Click();

            //Acessa a aba projetos
            driver.FindElement(By.PartialLinkText("Projetos")).Click();

            //Criar novo projeto
            driver.FindElement(By.PartialLinkText("Novo projeto")).Click();

            //Preenche dados para criação do novo projeto
            var projectName = "New Test Project II";
            driver.FindElement(By.Id("project_name")).SendKeys(projectName);
            driver.FindElement(By.Id("project_description")).SendKeys("This is a new project example for automation test.");
            driver.FindElement(By.Id("project_identifier")).SendKeys("ntp");

            //Deixa apenas a tarefa Bug selecionada
            var listaTarefas = driver.FindElements(By.Name("project[tracker_ids][]"));
            listaTarefas[1].Click();
            listaTarefas[2].Click();

            //Clicar no botão para criação do projeto
            driver.FindElement(By.Name("continue")).Click();

            //Acessa a aba projetos
            driver.FindElement(By.PartialLinkText("Projetos")).Click();

            //Acessa o projeto criado previamente
            driver.FindElement(By.PartialLinkText(projectName)).Click();

            //Acessar aba nova tarefa
            driver.FindElement(By.PartialLinkText("Nova tarefa")).Click();








        }
       
    }
}
