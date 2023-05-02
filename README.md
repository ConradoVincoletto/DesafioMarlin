# Web API utilizando modelagem MVC CRUD - Marlin

Projeto realizado em ASP.NET Core Web API, para o desafio técnico da empresa Marlin, trata-se de um cadastro de Aluno e Turma.

# Visão Geral

Projeto consiste em realizar o cadastro do Aluno e da turma e vincular o Aluno classe e ao ano letivo.

## O Desafio

Principal desafio foi realizar o projeto utilizando o conceito DDD e Code First, e realizar as regras de negócio;

* Aluno deve ser cadastrado em no mínimo uma turma.
* O e-mail e o CPF não pode ser inválido.
* O Aluno pode se matricular em diversas turmas, mas não em duplicidade.
* O Aluno não pode ser excluído caso esteja vinculado a uma classe.
* A classe não pode ser excluída caso esteja vinculado a um aluno.
* Uma classe não pode ter mais que 5 alunos.

# O que eu aprendi?

* A trabalhar com SQL Server, estabelecer as ORM's, e fazer o diagrama no próprio SQL Server.
* Estabelecer as regras de negócio e colocá-las na sua controller.
* Acredito que não tenh desempenhado tão bem o papel do conceito DDD e code first no projeto, pois é algo extremamente novo, mas ter o contato com o conceito, e aprendido sobre, foi muito valioso.
* E ter aprendido a usar de forma correta das foreing keys na migration, por certo, deu tudo ok no diagrama e nas tabelas SQL.

## Autor

* LinkedIn --> [Conrado Vincoletto](www.linkedin.com/in/conradovincoletto)
