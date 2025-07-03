Musica musica1 = new Musica();

musica1.Nome = "Bohemian Rhapsody";
musica1.Artista = "Queen";
musica1.Duracao = 354; // duração em segundos  
musica1.Disponivel = true; // Define a música como disponível
Console.WriteLine(musica1.DescricaoResumida); // Exibe a descrição resumida da música

Musica musica2 = new Musica();

musica2.Nome = "Imagine";
musica2.Artista = "John Lennon";
musica2.Duracao = 183; // duração em segundos
musica2.Disponivel = false; // Define a música como não disponível

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();