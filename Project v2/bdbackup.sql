-- Создание таблицы Players
CREATE TABLE "Players" (
    Id SERIAL PRIMARY KEY,
    Name VARCHAR(50) NOT NULL
);

-- Создание таблицы Teams
CREATE TABLE "Teams" (
    Id SERIAL PRIMARY KEY,
    Name VARCHAR(50) NOT null Unique
);

-- Создание таблицы Achievements
CREATE TABLE "Achievements" (
    Id SERIAL PRIMARY KEY,
    AchieveName VARCHAR(50) NOT NULL,
    PlayerId INT,
    TeamId INT,
    FOREIGN KEY (PlayerId) REFERENCES "Players" (Id) ON DELETE cascade,
    FOREIGN KEY (TeamId) REFERENCES "Teams" (Id) ON DELETE cascade
);

-- Вставка данных в таблицу Players
INSERT INTO "Players" (Name) VALUES 
('Stephen Curry'),
('Lebron James'),
('Kobe Bryant'),
('Michael Jordan'),
('Bill Russell'),
('Dwayne Wade'),
('Tim Duncan');

-- Вставка данных в таблицу Teams
INSERT INTO "Teams" (Name) VALUES 
('Warriors'),
('Lakers'),
('Bulls'),
('Spurs'),
('Heat'),
('Celtics'),
('Cavaliers');

-- Вставка данных в таблицу Achievements
INSERT INTO "Achievements" (AchieveName, PlayerId, TeamId) VALUES 
('MVP 1996', 4, 3),
('MVP 2009', 2, 7),
('MVP 2010', 2, 7),
('NBA Champion 2010', 3, 2),
('5x times Champion', 7, 4),
('DPOY', 4, 3),
('NBA Champion 2016', 2, 7),
('NBA Champion 2015', 1, 1),
('Olympic games gold', 2, 5),
('GOAT', 2, 2);