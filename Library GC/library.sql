-- phpMyAdmin SQL Dump
-- version 4.9.1
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 11, 2020 at 10:37 PM
-- Server version: 10.4.8-MariaDB
-- PHP Version: 7.3.11

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `library`
--

-- --------------------------------------------------------

--
-- Table structure for table `book`
--

CREATE TABLE `book` (
  `id_book` int(50) NOT NULL,
  `titre` varchar(50) NOT NULL,
  `auteur` varchar(50) NOT NULL,
  `genre` varchar(50) NOT NULL,
  `prix` double NOT NULL,
  `language` varchar(50) NOT NULL,
  `publisher` varchar(50) NOT NULL,
  `pages` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `book`
--

INSERT INTO `book` (`id_book`, `titre`, `auteur`, `genre`, `prix`, `language`, `publisher`, `pages`) VALUES
(1, 'Les misérable', 'Victor Hugo ', 'Historical fiction,Epic novel', 3.5, 'French', 'A.Lacroix,Verboeckhoven & Cie', 0),
(2, 'Dracula', 'Bram Stocker', 'Horror', 4.3, 'English', 'Archiblad Constable and Companu (UK)', 236),
(3, 'War and Peace', 'Leo Tolstoy', 'Historical novel', 7.6, 'Russian', 'The Russian Messenger', 1225);

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `id_user` int(50) NOT NULL,
  `login` varchar(50) NOT NULL,
  `password` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`id_user`, `login`, `password`) VALUES
(1, 'Ahmed', 'Ahmed123'),
(3, 'Mohamed', 'Med1456'),
(4, 'Ghada', 'Ghada123'),
(5, 'HanenCH', 'ch12456H'),
(6, 'AnasCH', 'As254698'),
(7, 'Insaf', 'In4598545'),
(8, 'Iyed', 'Ar12545'),
(9, 'Ahlem', 'Ahghffgy545');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `book`
--
ALTER TABLE `book`
  ADD PRIMARY KEY (`id_book`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`id_user`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `book`
--
ALTER TABLE `book`
  MODIFY `id_book` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=5;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `id_user` int(50) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
