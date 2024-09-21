
-- Criando o banco de dados
CREATE DATABASE JogosPS2;
USE JogosPS2;

-- Tabela de jogos
CREATE TABLE Jogo (
    JogoID INT PRIMARY KEY AUTO_INCREMENT,
    Titulo VARCHAR(255) NOT NULL,
    AnoLancamento INT NOT NULL,
    Plataforma VARCHAR(50) NOT NULL DEFAULT 'PlayStation 2',
    Descricao Varchar(1000) NOT NULL,
    Imagem varchar(200)
);

-- Tabela de gêneros
CREATE TABLE Genero (
    GeneroID INT PRIMARY KEY AUTO_INCREMENT,
    NomeGenero VARCHAR(100) NOT NULL
);

-- Tabela de desenvolvedores (inclui também publicadores)
CREATE TABLE Desenvolvedor (
    DesenvolvedorID INT PRIMARY KEY AUTO_INCREMENT,
    NomeDesenvolvedor VARCHAR(255) NOT NULL
);

-- Tabela de relação entre jogos e gêneros
CREATE TABLE JogoGenero (
    JogoID INT,
    GeneroID INT,
    PRIMARY KEY (JogoID, GeneroID),
    FOREIGN KEY (JogoID) REFERENCES Jogo(JogoID),
    FOREIGN KEY (GeneroID) REFERENCES Genero(GeneroID)
);

-- Tabela de relação entre jogos e desenvolvedores/publicadores
CREATE TABLE JogoDesenvolvedor (
    JogoID INT,
    DesenvolvedorID INT,
    PRIMARY KEY (JogoID, DesenvolvedorID),
    FOREIGN KEY (JogoID) REFERENCES Jogo(JogoID),
    FOREIGN KEY (DesenvolvedorID) REFERENCES Desenvolvedor(DesenvolvedorID)
);


INSERT INTO Genero (NomeGenero) VALUES 
('Ação'),
('Aventura'),
('RPG'),
('Tiro'),
('Plataforma'),
('Corrida'),
('Esportes'),
('Luta'),
('Vários'),
('Simulação');

-- Inserção de desenvolvedores
INSERT INTO Desenvolvedor (NomeDesenvolvedor) VALUES 
('Rockstar North'),  -- 1
('Konami'),  -- 2
('Square Enix'),  -- 3
('Polyphony Digital'), -- 4
('Team Ico'),  -- 5
('Capcom'),  -- 6
('Naughty Dog'),  -- 7
('Midway Games'),  -- 8
('Namco'),  -- 9
('EA Sports'),  -- 10
('Rockstar Games'),  -- 11
('Sony Computer Entertainment'),  -- 12
('Electronic Arts'),  -- 13
('Ubisoft'),  -- 14
('Comunidade'),  -- 15
('SEGA'),  -- 16
('Santa Monica Studios'),  -- 17
('Radical Entertainment'); -- 18


-- Inserção de jogos atualizada
INSERT INTO Jogo (Titulo, AnoLancamento, Descricao) VALUES 
('Grand Theft Auto: San Andreas', 2004, 'Um jogo de ação e aventura de mundo aberto que permite ao jogador explorar uma vasta cidade fictícia, realizando missões e interagindo com personagens em um ambiente dinâmico.'),
('Metal Gear Solid 3: Snake Eater', 2004, 'Um jogo de espionagem tática onde o jogador assume o papel de Snake, um espião infiltrado em uma selva soviética para parar uma ameaça nuclear.'),
('Final Fantasy X', 2001, 'Um RPG que segue a jornada de Tidus e Yuna em um mundo devastado por uma criatura chamada Sin, com uma história envolvente e um sistema de batalha baseado em turnos.'),
('Gran Turismo 4', 2004, 'Um simulador de corrida que oferece uma vasta gama de veículos e pistas, com gráficos realistas e uma física de direção precisa.'),
('Shadow of the Colossus', 2005, 'Um jogo de ação e aventura em que o jogador deve derrotar gigantes chamados Colossos em um vasto mundo vazio para ressuscitar uma jovem.'),
('Resident Evil 4', 2005, 'Um jogo de terror de sobrevivência e ação, onde o jogador controla Leon S. Kennedy, um agente do governo que deve resgatar a filha do presidente de um culto perigoso.'),
('God of War II', 2007, 'Um jogo de ação e aventura que segue a história de Kratos em sua busca por vingança contra os deuses do Olimpo, com jogabilidade baseada em combates e quebra-cabeças.'),
('Crash of Titans', 2007, 'Um jogo de ação e plataforma em que Crash Bandicoot enfrenta inimigos gigantes e monta em titãs, com muita ação e um estilo de combate único.'),
('Jak and Daxter: The Precursor Legacy', 2001, 'Um jogo de plataforma de ação e aventura em um mundo aberto, onde Jak e seu amigo Daxter exploram um mundo cheio de mistérios e desafios.'),
('Kingdom Hearts II', 2005, 'Um RPG de ação que mistura personagens da Disney e da Square Enix em uma aventura épica para proteger mundos da escuridão.'),
('Super Coleção 7.784 Jogos', 2007, 'Super Coleção 7.784 Jogos é um jogo para Playstation 2 que vem 5 emuladores de video games antigos, como Atari 2600, Nintendo Entertainment System, Super Nintendo, Master System e Mega Drive.'),
('Tekken 5', 2005, 'Um jogo de luta em 3D com uma variedade de personagens e estilos de luta, oferecendo tanto modos de história quanto de combate versus.'),
('Burnout 3: Takedown', 2004, 'Um jogo de corrida arcade onde o objetivo é destruir os carros dos oponentes e causar o maior dano possível em acidentes espetaculares.'),
('Okami', 2006, 'Um jogo de ação e aventura inspirado na mitologia japonesa, onde o jogador controla uma deusa lobo chamada Amaterasu em uma missão para salvar o mundo das trevas.'),
('Devil May Cry 3: Dante\'s Awakening', 2005, 'Um jogo de ação hack and slash onde o jogador controla Dante, um caçador de demônios, enfrentando hordas de inimigos e desafiando seu próprio irmão.'),
('Prince of Persia: The Sands of Time', 2003, 'Um jogo de ação e plataforma onde o jogador controla o Príncipe, que deve usar habilidades de parkour e manipulação do tempo para salvar seu reino.'),
('Silent Hill 2', 2001, 'Um jogo de terror psicológico em que o jogador assume o papel de James Sunderland, que procura sua esposa falecida em uma cidade estranha e aterrorizante.'),
('SSX Tricky', 2001, 'Um jogo de corrida de snowboard que oferece truques exagerados e acrobacias em pistas radicais, com uma jogabilidade arcade acelerada.'),
('SoulCalibur II', 2003, 'Um jogo de luta em 3D centrado em combates com armas, oferecendo uma variedade de personagens com estilos únicos e uma narrativa envolvente.'),
('Mortal Kombat: Shaolin Monks', 2005, 'Um jogo de ação e aventura em que os jogadores assumem o controle de Liu Kang e Kung Lao enquanto enfrentam hordas de inimigos no universo Mortal Kombat.'),
('PES 2013', 2012, 'Um simulador de futebol que oferece uma jogabilidade realista, com controles precisos e mecânicas de jogo detalhadas para uma experiência imersiva.');

-- Relacionamento entre jogos e gêneros atualizado
INSERT INTO JogoGenero (JogoID, GeneroID) VALUES 
(1, 1), (1, 2),  -- GTA San Andreas
(2, 2),          -- Metal Gear Solid 3: Snake Eater
(3, 3),          -- Final Fantasy X
(4, 6),          -- Gran Turismo 4
(5, 1), (5, 2),  -- Shadow of the Colossus
(6, 1), (6, 2),  -- Resident Evil 4
(7, 1),          -- God of War II
(8, 1), (8, 4),  -- Crash of Titans
(9, 2),          -- Jak and Daxter: The Precursor Legacy
(10, 3),         -- Kingdom Hearts II
(12, 8),         -- Tekken 5
(11, 9),		 -- Super Coleção 7.784 Jogos
(13, 6),         -- Burnout 3: Takedown
(14, 2),         -- Okami
(15, 1),         -- Devil May Cry 3: Dante's Awakening
(16, 2),         -- Prince of Persia: The Sands of Time
(17, 2),         -- Silent Hill 2
(18, 7),         -- SSX Tricky
(19, 8),         -- SoulCalibur II
(20, 8),         -- Mortal Kombat: Shaolin Monks
(21, 7);         -- PES 2013

-- Relacionamento entre jogos e desenvolvedores atualizado
INSERT INTO JogoDesenvolvedor (JogoID, DesenvolvedorID) VALUES 
(1, 1), (1, 11),   -- GTA San Andreas: Rockstar North e Rockstar Games
(2, 2),            -- Metal Gear Solid 3: Snake Eater: Konami
(3, 3),            -- Final Fantasy X: Square Enix
(4, 4),            -- Gran Turismo 4: Polyphony Digital
(5, 5),            -- Shadow of the Colossus: Team Ico
(6, 6),            -- Resident Evil 4: Capcom
(7, 17),            -- God of War II: Santa Monica Studios
(8, 18),            -- Crash of Titans: Capcom
(9, 7),            -- Jak and Daxter: The Precursor Legacy: Naughty Dog
(10, 3),		   -- Kingdom Hearts II: Square Enix 
(11, 15),          -- Super Coleção 7.784 Jogos
(12, 9),           -- Tekken 5: Namco
(13, 13),          -- Burnout 3: Takedown: Electronic Arts
(14, 6),           -- Okami: Capcom
(15, 6),           -- Devil May Cry 3: Capcom
(16, 14),          -- Prince of Persia: The Sands of Time: Ubisoft
(17, 2),           -- Silent Hill 2: Konami
(18, 13),          -- SSX Tricky: Electronic Arts
(19, 9),           -- SoulCalibur II: Namco
(20, 8),           -- Mortal Kombat: Shaolin Monks
(21, 10);          -- PES 2013: EA Sports

