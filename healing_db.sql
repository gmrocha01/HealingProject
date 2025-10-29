-- healing_db.sql
CREATE DATABASE IF NOT EXISTS healing_db;
USE healing_db;

CREATE TABLE IF NOT EXISTS usuarios (
  id INT AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(100) NOT NULL,
  usuario VARCHAR(50) NOT NULL UNIQUE,
  senha VARCHAR(100) NOT NULL
);

CREATE TABLE IF NOT EXISTS pessoas (
  id INT AUTO_INCREMENT PRIMARY KEY,
  nome VARCHAR(150) NOT NULL,
  telefone VARCHAR(20),
  email VARCHAR(100),
  data_nascimento DATE,
  observacoes TEXT
);

CREATE TABLE IF NOT EXISTS terapias_consultas (
  id INT AUTO_INCREMENT PRIMARY KEY,
  id_pessoa INT NOT NULL,
  data_consulta DATETIME NOT NULL,
  tipo_terapia VARCHAR(100),
  observacoes TEXT,
  FOREIGN KEY (id_pessoa) REFERENCES pessoas(id)
);

INSERT INTO usuarios (nome, usuario, senha) VALUES ('Administrador', 'admin', 'admin');
