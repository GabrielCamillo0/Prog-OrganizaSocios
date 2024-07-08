

-- Banco de dados: `cadastro`

CREATE TABLE `cadastrouser` (
  `id` int(11) NOT NULL,
  `login` varchar(100) NOT NULL,
  `senha` varchar(100) NOT NULL
) ;

CREATE TABLE `extrato` (
  `id` int(11) NOT NULL,
  `descricao` varchar(150) DEFAULT 'sim',
  `saldo` double NOT NULL
) ;
