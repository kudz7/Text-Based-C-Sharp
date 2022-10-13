CREATE DATABASE GameScoreboard;

CREATE TABLE GameScoreboard.Scores (
Identifier INT AUTO_INCREMENT NOT NULL,
CharacterName VARCHAR(255),
Score INT,
PRIMARY KEY (Identifier)
);

COMMIT;