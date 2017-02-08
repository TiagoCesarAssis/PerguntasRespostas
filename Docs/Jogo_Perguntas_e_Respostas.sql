--Cria o banco de dados
create database db_PerguntasERespostas

--Usa o banco de dados
use db_PerguntasERespostas

--Cria a tabela tb_Jogador
create table tb_Jogador(
	id int identity primary key,
	nome varchar(100) not null
)
--Seleciona da tabela tb_Jogador
select * from tb_Perguntas

--Insere na tabela tb_Jogador
insert into tb_Jogador(nome) values('Amanda')
insert into tb_Jogador(nome) values('Fernanda')

--Cria a tabela tb_Perguntas
create table tb_Perguntas(

--Colunas da tabela tb_Perguntas
id        int identity primary key,
pergunta           varchar(max),
resposta_correta   varchar(max),
id_jogador int,
data    datetime default getdate()
)
--Insere na tabela tb_Perguntas a resposta correta
insert into tb_Perguntas(pergunta,resposta_correta)
values('Qual a capital do Paraná?','Curitiba')

--Seleciona na tabela tb_Jogador
select * from tb_Perguntas

--Deleta o id=10 da tabela tb_Jogador
delete from tb_Jogador where id = 10

--Insere na tabela tb_Jogador o nome "Ramon"
insert into tb_Jogador(nome) values('Ramon')

--Deleta da tabela tb_Jogador
delete from tb_Jogador

--truncate= limpa os dados da tabela e reinicia a numeração do id
truncate table tb_Jogador
truncate table tb_Perguntas

--Alteração na tabela tb_Jogador, inserindo a coluna id_Jogador
alter table tb_Perguntas add id_Jogador int

--Alteração na tabela tb_Perguntas, inserindo a coluna id_Jogador
alter table tb_Jogador drop column id_Jogador

--Faz a junção das tabelas tb_Jogador com a tabela tb_Perguntas onde tb_Jogador = tb_Perguntas.id_Jogador
select * from tb_Jogador join tb_Perguntas on tb_Jogador.id = tb_Perguntas.id_Jogador

select * from tb_Jogador
select * from tb_Perguntas


--Seleciona o último id inserido NA TABELA ATIVA
select @@IDENTITY