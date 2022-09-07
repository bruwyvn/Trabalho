Curitiba, 2022/2
Universidade Positivo
Análise de Sistemas/Sistemas de Informação/Engenharia de Software
Desenvolvimento de Software Visual
Prof. Jean Diogo (jean.diogo@up.edu.br)

## Especificação do Trabalho
### API Web

Nesta disciplina temos por objetivo compreender o funcionamento de uma aplicação web desde o back-end (parte da aplicação executada no máquina do servidor) até o front-end(parte da aplicação executada na máquina do cliente), bem como a API (interface deprogramação) através da qual ambas as partes da aplicação se comunicam. No primeirobimestre estudamos como funciona o back-end e como este pode ser implementado através dalinguagem de programação C# em um paradigma orientado a objetos. O back-end de umaaplicação web é responsável por processar as requisições dos clientes e armazenar dados queprecisem ser persistentes, o que geralmente é feito através de um banco de dados.

Vimos também que em muitos cenários é desejável que a API do serviço satisfaça pelomenos quatro operações básicas: criar, ler, atualizar e deletar (também abreviadas comoCRUD). No caso de uma API web, estas operações podem ser realizadas através dos métodosdo protocolo HTTP, dentre eles o GET, POST, PUT, DELETE etc.

Neste trabalho você deverá colocar em prática os conhecimentos adquiridosimplementando (1) o backend de um serviço web qualquer e (2) uma API para comunicaçãocom este serviço. Sua aplicação deverá representar qualquer tipo de serviço web,excetuando-se serviços do tipo e-commerce, já vistos em aula. O serviço deverá serinstanciado no localhost de sua máquina através das ferramentas disponíveis na SDK .NETapresentada em aula. O armazenamento deverá ser feito através do sistema de banco dedados apresentado em aula.

A modelagem do serviço deverá prever pelo menos duas entidades (tal como emnosso serviço de e-commerce tinhamos a entidade "usuário" e a entidade "mercadoria"). Paracada entidade devem ser implementados as operações CRUD (tal como para a entidade"usuário" tínhamos as operações "cadastrar", "logar", "atualizar" e "remover" e para a entidade"mercadoria" tínhamos as operações "cadastrar", "listar", "atualizar" e "remover"). As operaçõesdeverão poder ser acessadas através dos métodos GET e/ou POST utilizados no navegador ouem algum testador de API (como o Postman).

Os trabalhos deverão ser realizados em equipes de três pessoas. A defesa do trabalhoocorrerá durante a aula especificada no calendário do Blackboard da turma. A equipe deverátrazer todo o código e terá cerca de 10 minutos para explicar seu funcionamento e executá-lodurante a avaliação, demonstrando todos os métodos solicitados. Apenas os membrospresentes no dia da defesa serão pontuados e a pontuação de cada membro será dadaindividualmente para garantir que todos tenham participado no desenvolvimento.Os códigos desenvolvidos durante as aulas e disponibilizados pelo professor noBlackboard poderão ser utilizados como base do trabalho, mas as classes das entidadesenvolvidas na aplicação deverão ser originais. 

Dúvidas devem ser encaminhadas ao e-mail doprofessor ou postadas no Blackboard. É fortemente recomendável que as equipes informem aoprofessor com antecedência qual será o serviço implementado (e as entidades envolvidas) paraaprovação prévia. Aplicações que não cumpram todos os requisitos do trabalho serãopontuadas apenas parcialmente
