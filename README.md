# Server Monitor
Aplicação desktop desenvolvida em C# na plataforma .NET para monitoramento de servidores e ativos via protocolo ICMP.
A aplicação permite adição de paineis de monitoramento individuais por ativo. É possivel configurar um IP, uma Descrição, e o tamanho do pacote a ser enviado.
O painel exibirá a resposta do comando ICMP em uma lista com as cores de um semáforo: 
Resposta em menos de 100 milisergundos = Verde.
Resposta em mais de 100 milisegundos = Amarelo.
Tempo Esgotado = Vermelho.
