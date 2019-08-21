# NorisSolution
Solução exemplo com ASP.NET MVC , Entity Framework , estrategia ORM Code First

Objetivo : Demonstração de uso de tecnologias integradas a desenvolvimento Web ASP.NET MVC
Tecnologias e estrategias de arquitetura empregadas:
- SimpleInjector Container (DI) - Projeto : Noris.Contrato.Presentation
- Entity Framework (ORM) - Projeto : Noris.Contrato.DAL
- Estrategia Code First - Projeto : Noris.Contrato.DAL
- Auto Mapper - Mapeamento entre classes de Modelo e Views - Projeto : Noris.Contrato.Presentation
- Uso de Lambda Expressions e Linq - Projeto : Noris.Contrato.Service
- Teste unitarios - Projeto : Noris.Contrato.Teste

- Para rodar o projeto , seguir os passos nesta ordem :
1. Instalar Sql Server Express 2012 ou versão posterior
2. Abrir o arquivo Web.Config do projeto Noris.Contrato.Presentation e localizar a chave e mudar o parametro connectionString para sua string de conexao local.
