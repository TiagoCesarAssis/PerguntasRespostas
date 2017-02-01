create database db_PerguntasERespostas

use db_PerguntasERespostas

create table tb_Jogador(
	id int identity primary key,
	nome varchar(100) not null
)

select * from tb_Perguntas

insert into tb_Jogador(nome) values('Amanda')
insert into tb_Jogador(nome) values('Fernanda')

create table tb_Perguntas(

id        int identity primary key,
pergunta           varchar(max),
resposta_correta   varchar(max),
data    datetime default getdate()
)

insert into tb_Perguntas(pergunta,resposta_correta)
values('Qual a capital do Paraná?','Curitiba')

select * from tb_jogador

delete from tb_Jogador where id = 10

insert into tb_Jogador(nome) values('Ramon')

delete from tb_Jogador

--truncate= limpa os dados da tabela e reinicia a numeração do id
truncate table tb_Jogador

